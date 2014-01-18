using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Packet;
using AddressLibrary;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace ControlCloudTester {
    public partial class ControlCloudTester : Form {

        delegate void SetTextCallback(string text);

        private IPAddress cloudAddress;        //Adres na którym chmura nasłuchuje
        private Int32 cloudPort;           //port chmury
        private IPEndPoint cloudEndPoint;
        private Socket cloudSocket;

        private Address myAddr;

        private Queue _whatToSendQueue;
        private Queue whatToSendQueue;

        private Thread receiveThread;     //wątek służący do odbierania połączeń
        private Thread sendThread;        // analogicznie - do wysyłania

        private NetworkStream networkStream;

        public bool isConnectedToCloud { get; private set; }
        public ControlCloudTester() {
            isConnectedToCloud = false;
            _whatToSendQueue = new Queue();
            whatToSendQueue = Queue.Synchronized(_whatToSendQueue);
            InitializeComponent();
        }

        private void conToCloudButton_Click(object sender, EventArgs e) {
            if (!isConnectedToCloud) {
                if (setAddress()) {
                    if (IPAddress.TryParse(cloudIPTextBox.Text, out cloudAddress)) {
                        SetText("IP ustawiono jako " + cloudAddress.ToString());
                    } else {
                        SetText("Błąd podczas ustawiania IP chmury (zły format?)");
                    }
                    if (Int32.TryParse(cloudPortTextBox.Text, out cloudPort)) {
                        SetText("Port chmury ustawiony jako " + cloudPort.ToString());
                    } else {
                        SetText("Błąd podczas ustawiania portu chmury (zły format?)");
                    }

                    cloudSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    cloudEndPoint = new IPEndPoint(cloudAddress, cloudPort);
                    try {
                        cloudSocket.Connect(cloudEndPoint);
                        isConnectedToCloud = true;
                        networkStream = new NetworkStream(cloudSocket);
                        sendButton.Enabled = true;
                        List<String> _welcArr = new List<String>();
                        _welcArr.Add("HELLO");
                        SPacket welcomePacket = new SPacket(myAddr.ToString(), new Address(0, 0, 0).ToString(), _welcArr);
                        whatToSendQueue.Enqueue(welcomePacket);
                        receiveThread = new Thread(this.receiver);
                        receiveThread.IsBackground = true;
                        receiveThread.Start();
                        sendThread = new Thread(this.sender);
                        sendThread.IsBackground = true;
                        sendThread.Start();
                        conToCloudButton.Text = "Rozłącz";
                        SetText("Połączono!");
                    } catch (SocketException) {
                        isConnectedToCloud = false;
                        SetText("Błąd podczas łączenia się z chmurą");
                        SetText("Złe IP lub port? Chmura nie działa?");
                    }
                }
            } else {
                conToCloudButton.Text = "Połącz";
                isConnectedToCloud = false;
                networkStream = null;
                cloudSocket = null;
            }
        }

        public void sender() {
            while (isConnectedToCloud) {
                //jeśli coś jest w kolejce - zdejmij i wyślij
                if (whatToSendQueue.Count != 0) {
                    SPacket _pck = (SPacket)whatToSendQueue.Dequeue();
                    BinaryFormatter bformatter = new BinaryFormatter();
                    bformatter.Serialize(networkStream, _pck);
                    networkStream.Flush();
                    String[] _argsToShow = _pck.getParames().ToArray();
                    String argsToShow = "";
                    foreach (String str in _argsToShow) {
                        argsToShow += str + " ";
                    }
                    SetText("Wysłano: " + _pck.getSrc() + ":" + _pck.getDest() + ":" + argsToShow);
                }
            }
        }

        public bool setAddress() {
            int _netNum;
            int _subnetNum;
            int _hostNum;
            if (int.TryParse(networkNumberTextBox.Text, out _netNum)){
                if (int.TryParse(subnetTextBox.Text, out _subnetNum)) {
                    if (int.TryParse(hostNumberTextBox.Text, out _hostNum)) {
                        myAddr = new Address(_netNum, _subnetNum, _hostNum);
                        return true;
                    } else return false;
                } else return false;
            }else return false;
        }
        private void sendButton_Click(object sender, EventArgs e) {
            try {
                Address source = new Address(int.Parse(srcNet.Text), int.Parse(srcSubnet.Text), int.Parse(srcHost.Text));
                Address destination = new Address(int.Parse(destNet.Text), int.Parse(destSubnet.Text), int.Parse(destHost.Text));
                SPacket packet = new SPacket(source.ToString(), destination.ToString(), msg.Text);
                whatToSendQueue.Enqueue(packet);
            } catch {
                SetText("Nie wysłało");
            }
        }

        public void SetText(string text) {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.log.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            } else {
                try {
                    this.log.AppendText(text + "\n");
                } catch { }
            }
        }

        public void receiver() {
            while (isConnectedToCloud) {
                BinaryFormatter bf = new BinaryFormatter();
                try {
                    SPacket receivedPacket = (Packet.SPacket)bf.Deserialize(networkStream);
                    SetText("Odczytano:\n" + receivedPacket.getSrc() + ":" + receivedPacket.getDest() + ":" + receivedPacket.getParames());
                } catch {
                    SetText("WUT");
                }
            }
        }
    }
}
