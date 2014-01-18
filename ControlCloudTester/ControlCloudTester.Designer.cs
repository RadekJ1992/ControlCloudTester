namespace ControlCloudTester {
    partial class ControlCloudTester {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.subnetTextBox = new System.Windows.Forms.TextBox();
            this.networkNumberTextBox = new System.Windows.Forms.TextBox();
            this.subnetNumberLabel = new System.Windows.Forms.Label();
            this.networkNumerLabel = new System.Windows.Forms.Label();
            this.cloudPortTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.cloudIPTextBox = new System.Windows.Forms.TextBox();
            this.conToCloudButton = new System.Windows.Forms.Button();
            this.hostNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.srcNet = new System.Windows.Forms.TextBox();
            this.srcSubnet = new System.Windows.Forms.TextBox();
            this.srcHost = new System.Windows.Forms.TextBox();
            this.destHost = new System.Windows.Forms.TextBox();
            this.destSubnet = new System.Windows.Forms.TextBox();
            this.destNet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subnetTextBox
            // 
            this.subnetTextBox.Location = new System.Drawing.Point(92, 33);
            this.subnetTextBox.Name = "subnetTextBox";
            this.subnetTextBox.Size = new System.Drawing.Size(31, 20);
            this.subnetTextBox.TabIndex = 37;
            this.subnetTextBox.Text = "1";
            // 
            // networkNumberTextBox
            // 
            this.networkNumberTextBox.Location = new System.Drawing.Point(92, 9);
            this.networkNumberTextBox.Name = "networkNumberTextBox";
            this.networkNumberTextBox.Size = new System.Drawing.Size(31, 20);
            this.networkNumberTextBox.TabIndex = 36;
            this.networkNumberTextBox.Text = "1";
            // 
            // subnetNumberLabel
            // 
            this.subnetNumberLabel.AutoSize = true;
            this.subnetNumberLabel.Location = new System.Drawing.Point(6, 36);
            this.subnetNumberLabel.Name = "subnetNumberLabel";
            this.subnetNumberLabel.Size = new System.Drawing.Size(80, 13);
            this.subnetNumberLabel.TabIndex = 35;
            this.subnetNumberLabel.Text = "Numer podsieci";
            // 
            // networkNumerLabel
            // 
            this.networkNumerLabel.AutoSize = true;
            this.networkNumerLabel.Location = new System.Drawing.Point(6, 9);
            this.networkNumerLabel.Name = "networkNumerLabel";
            this.networkNumerLabel.Size = new System.Drawing.Size(62, 13);
            this.networkNumerLabel.TabIndex = 34;
            this.networkNumerLabel.Text = "Numer sieci";
            // 
            // cloudPortTextBox
            // 
            this.cloudPortTextBox.Location = new System.Drawing.Point(161, 59);
            this.cloudPortTextBox.Name = "cloudPortTextBox";
            this.cloudPortTextBox.Size = new System.Drawing.Size(85, 20);
            this.cloudPortTextBox.TabIndex = 33;
            this.cloudPortTextBox.Text = "13000";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(129, 62);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 32;
            this.portLabel.Text = "Port";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(129, 12);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(17, 13);
            this.ipLabel.TabIndex = 31;
            this.ipLabel.Text = "IP";
            // 
            // cloudIPTextBox
            // 
            this.cloudIPTextBox.Location = new System.Drawing.Point(152, 9);
            this.cloudIPTextBox.Name = "cloudIPTextBox";
            this.cloudIPTextBox.Size = new System.Drawing.Size(94, 20);
            this.cloudIPTextBox.TabIndex = 30;
            this.cloudIPTextBox.Text = "127.0.0.1";
            // 
            // conToCloudButton
            // 
            this.conToCloudButton.Location = new System.Drawing.Point(9, 85);
            this.conToCloudButton.Name = "conToCloudButton";
            this.conToCloudButton.Size = new System.Drawing.Size(237, 32);
            this.conToCloudButton.TabIndex = 29;
            this.conToCloudButton.Text = "Połącz";
            this.conToCloudButton.UseVisualStyleBackColor = true;
            this.conToCloudButton.Click += new System.EventHandler(this.conToCloudButton_Click);
            // 
            // hostNumberTextBox
            // 
            this.hostNumberTextBox.Location = new System.Drawing.Point(92, 59);
            this.hostNumberTextBox.Name = "hostNumberTextBox";
            this.hostNumberTextBox.Size = new System.Drawing.Size(31, 20);
            this.hostNumberTextBox.TabIndex = 39;
            this.hostNumberTextBox.Text = "99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Numer hosta";
            // 
            // srcNet
            // 
            this.srcNet.Location = new System.Drawing.Point(9, 142);
            this.srcNet.Name = "srcNet";
            this.srcNet.Size = new System.Drawing.Size(29, 20);
            this.srcNet.TabIndex = 40;
            // 
            // srcSubnet
            // 
            this.srcSubnet.Location = new System.Drawing.Point(44, 142);
            this.srcSubnet.Name = "srcSubnet";
            this.srcSubnet.Size = new System.Drawing.Size(29, 20);
            this.srcSubnet.TabIndex = 41;
            // 
            // srcHost
            // 
            this.srcHost.Location = new System.Drawing.Point(79, 142);
            this.srcHost.Name = "srcHost";
            this.srcHost.Size = new System.Drawing.Size(29, 20);
            this.srcHost.TabIndex = 42;
            // 
            // destHost
            // 
            this.destHost.Location = new System.Drawing.Point(217, 142);
            this.destHost.Name = "destHost";
            this.destHost.Size = new System.Drawing.Size(29, 20);
            this.destHost.TabIndex = 45;
            // 
            // destSubnet
            // 
            this.destSubnet.Location = new System.Drawing.Point(182, 142);
            this.destSubnet.Name = "destSubnet";
            this.destSubnet.Size = new System.Drawing.Size(29, 20);
            this.destSubnet.TabIndex = 44;
            // 
            // destNet
            // 
            this.destNet.Location = new System.Drawing.Point(147, 142);
            this.destNet.Name = "destNet";
            this.destNet.Size = new System.Drawing.Size(29, 20);
            this.destNet.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Message";
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(65, 168);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(181, 20);
            this.msg.TabIndex = 49;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Window;
            this.log.Location = new System.Drawing.Point(9, 232);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(235, 128);
            this.log.TabIndex = 50;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(9, 194);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(237, 32);
            this.sendButton.TabIndex = 51;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ControlCloudTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 372);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.log);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destNet);
            this.Controls.Add(this.destSubnet);
            this.Controls.Add(this.destHost);
            this.Controls.Add(this.srcHost);
            this.Controls.Add(this.srcSubnet);
            this.Controls.Add(this.srcNet);
            this.Controls.Add(this.hostNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subnetTextBox);
            this.Controls.Add(this.networkNumberTextBox);
            this.Controls.Add(this.subnetNumberLabel);
            this.Controls.Add(this.networkNumerLabel);
            this.Controls.Add(this.cloudPortTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.cloudIPTextBox);
            this.Controls.Add(this.conToCloudButton);
            this.Name = "ControlCloudTester";
            this.Text = "ControlCloudTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subnetTextBox;
        private System.Windows.Forms.TextBox networkNumberTextBox;
        private System.Windows.Forms.Label subnetNumberLabel;
        private System.Windows.Forms.Label networkNumerLabel;
        private System.Windows.Forms.TextBox cloudPortTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox cloudIPTextBox;
        private System.Windows.Forms.Button conToCloudButton;
        private System.Windows.Forms.TextBox hostNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srcNet;
        private System.Windows.Forms.TextBox srcSubnet;
        private System.Windows.Forms.TextBox srcHost;
        private System.Windows.Forms.TextBox destHost;
        private System.Windows.Forms.TextBox destSubnet;
        private System.Windows.Forms.TextBox destNet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button sendButton;
    }
}

