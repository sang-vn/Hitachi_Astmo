namespace Hitachi_Astemo
{
    partial class Connect_PLC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_PLC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.bnPing = new System.Windows.Forms.Button();
            this.bnConnect = new System.Windows.Forms.Button();
            this.lbNotice = new System.Windows.Forms.Label();
            this.tbReceivedData = new System.Windows.Forms.TextBox();
            this.tbSentData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnSend1 = new System.Windows.Forms.Button();
            this.cbHEX1 = new System.Windows.Forms.CheckBox();
            this.tbData1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNumRegisterRead = new System.Windows.Forms.TextBox();
            this.tbBeginRegisterRead = new System.Windows.Forms.TextBox();
            this.cbbRegister = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReadMode = new System.Windows.Forms.CheckBox();
            this.cbWriteMode = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(104, 10);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(99, 22);
            this.tbIpAddress.TabIndex = 2;
            this.tbIpAddress.Text = "192.168.1.10";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(104, 38);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(99, 22);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "8888";
            // 
            // bnPing
            // 
            this.bnPing.Location = new System.Drawing.Point(18, 72);
            this.bnPing.Name = "bnPing";
            this.bnPing.Size = new System.Drawing.Size(81, 30);
            this.bnPing.TabIndex = 4;
            this.bnPing.Text = "Ping";
            this.bnPing.UseVisualStyleBackColor = true;
            // 
            // bnConnect
            // 
            this.bnConnect.Location = new System.Drawing.Point(104, 72);
            this.bnConnect.Name = "bnConnect";
            this.bnConnect.Size = new System.Drawing.Size(99, 30);
            this.bnConnect.TabIndex = 5;
            this.bnConnect.Text = "Connect";
            this.bnConnect.UseVisualStyleBackColor = true;
            this.bnConnect.Click += new System.EventHandler(this.bnConnect_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.BackColor = System.Drawing.Color.Red;
            this.lbNotice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbNotice.Location = new System.Drawing.Point(18, 110);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(185, 44);
            this.lbNotice.TabIndex = 7;
            this.lbNotice.Text = "Disconnected";
            this.lbNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReceivedData
            // 
            this.tbReceivedData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbReceivedData.Location = new System.Drawing.Point(234, 33);
            this.tbReceivedData.Multiline = true;
            this.tbReceivedData.Name = "tbReceivedData";
            this.tbReceivedData.ReadOnly = true;
            this.tbReceivedData.Size = new System.Drawing.Size(422, 120);
            this.tbReceivedData.TabIndex = 8;
            // 
            // tbSentData
            // 
            this.tbSentData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSentData.Location = new System.Drawing.Point(234, 183);
            this.tbSentData.Multiline = true;
            this.tbSentData.Name = "tbSentData";
            this.tbSentData.ReadOnly = true;
            this.tbSentData.Size = new System.Drawing.Size(422, 120);
            this.tbSentData.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Received Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sent Data";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.textBox1);
            this.GroupBox1.Controls.Add(this.bnSend1);
            this.GroupBox1.Controls.Add(this.cbHEX1);
            this.GroupBox1.Controls.Add(this.tbData1);
            this.GroupBox1.Location = new System.Drawing.Point(18, 317);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(644, 131);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Data Send";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(9, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 69);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Ví dụ: \r\n+ Muốn viết 1234 lên D100, 4321 lên D101 thì chuỗi cuối là A8 | 02 00 | " +
    "d2 04 e1 10\r\n+ Muốn ON cả 5 địa chỉ từ Y0 đến Y4   thì chuỗi cuối là 9d | 05 00 " +
    "| 11 11 10 ";
            // 
            // bnSend1
            // 
            this.bnSend1.Location = new System.Drawing.Point(548, 22);
            this.bnSend1.Name = "bnSend1";
            this.bnSend1.Size = new System.Drawing.Size(64, 23);
            this.bnSend1.TabIndex = 2;
            this.bnSend1.Text = "Send";
            this.bnSend1.UseVisualStyleBackColor = true;
            this.bnSend1.Click += new System.EventHandler(this.bnSend1_Click);
            // 
            // cbHEX1
            // 
            this.cbHEX1.AutoSize = true;
            this.cbHEX1.Location = new System.Drawing.Point(477, 25);
            this.cbHEX1.Name = "cbHEX1";
            this.cbHEX1.Size = new System.Drawing.Size(56, 20);
            this.cbHEX1.TabIndex = 1;
            this.cbHEX1.Text = "HEX";
            this.cbHEX1.UseVisualStyleBackColor = true;
            // 
            // tbData1
            // 
            this.tbData1.Location = new System.Drawing.Point(7, 22);
            this.tbData1.Name = "tbData1";
            this.tbData1.Size = new System.Drawing.Size(456, 22);
            this.tbData1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbWriteMode);
            this.groupBox2.Controls.Add(this.tbNumRegisterRead);
            this.groupBox2.Controls.Add(this.tbBeginRegisterRead);
            this.groupBox2.Controls.Add(this.cbReadMode);
            this.groupBox2.Controls.Add(this.cbbRegister);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 144);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "R/W";
            // 
            // tbNumRegisterRead
            // 
            this.tbNumRegisterRead.Location = new System.Drawing.Point(71, 106);
            this.tbNumRegisterRead.Name = "tbNumRegisterRead";
            this.tbNumRegisterRead.Size = new System.Drawing.Size(97, 22);
            this.tbNumRegisterRead.TabIndex = 5;
            this.tbNumRegisterRead.Text = "3";
            this.tbNumRegisterRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBeginRegisterRead
            // 
            this.tbBeginRegisterRead.Location = new System.Drawing.Point(71, 80);
            this.tbBeginRegisterRead.Name = "tbBeginRegisterRead";
            this.tbBeginRegisterRead.Size = new System.Drawing.Size(97, 22);
            this.tbBeginRegisterRead.TabIndex = 4;
            this.tbBeginRegisterRead.Text = "0";
            this.tbBeginRegisterRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbRegister
            // 
            this.cbbRegister.FormattingEnabled = true;
            this.cbbRegister.Items.AddRange(new object[] {
            "Y",
            "M",
            "D",
            "X",
            "T",
            "C"});
            this.cbbRegister.Location = new System.Drawing.Point(94, 52);
            this.cbbRegister.Name = "cbbRegister";
            this.cbbRegister.Size = new System.Drawing.Size(51, 24);
            this.cbbRegister.TabIndex = 3;
            this.cbbRegister.Tag = "";
            this.cbbRegister.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Begin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Register";
            // 
            // cbReadMode
            // 
            this.cbReadMode.AutoSize = true;
            this.cbReadMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbReadMode.Location = new System.Drawing.Point(9, 21);
            this.cbReadMode.Name = "cbReadMode";
            this.cbReadMode.Size = new System.Drawing.Size(70, 24);
            this.cbReadMode.TabIndex = 6;
            this.cbReadMode.Text = "Read";
            this.cbReadMode.UseVisualStyleBackColor = true;
            this.cbReadMode.CheckedChanged += new System.EventHandler(this.cbReadMode_CheckedChanged);
            // 
            // cbWriteMode
            // 
            this.cbWriteMode.AutoSize = true;
            this.cbWriteMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbWriteMode.Location = new System.Drawing.Point(97, 21);
            this.cbWriteMode.Name = "cbWriteMode";
            this.cbWriteMode.Size = new System.Drawing.Size(71, 24);
            this.cbWriteMode.TabIndex = 7;
            this.cbWriteMode.Text = "Write";
            this.cbWriteMode.UseVisualStyleBackColor = true;
            this.cbWriteMode.CheckedChanged += new System.EventHandler(this.cbWriteMode_CheckedChanged);
            // 
            // Connect_PLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(674, 459);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSentData);
            this.Controls.Add(this.tbReceivedData);
            this.Controls.Add(this.lbNotice);
            this.Controls.Add(this.bnConnect);
            this.Controls.Add(this.bnPing);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connect_PLC";
            this.Text = "Connect_PLC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connect_PLC_FormClosing);
            this.Load += new System.EventHandler(this.Connect_PLC_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button bnPing;
        private System.Windows.Forms.Button bnConnect;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.TextBox tbReceivedData;
        private System.Windows.Forms.TextBox tbSentData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button bnSend1;
        private System.Windows.Forms.CheckBox cbHEX1;
        private System.Windows.Forms.TextBox tbData1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumRegisterRead;
        private System.Windows.Forms.TextBox tbBeginRegisterRead;
        private System.Windows.Forms.ComboBox cbbRegister;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbReadMode;
        private System.Windows.Forms.CheckBox cbWriteMode;
    }
}