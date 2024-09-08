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
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbWriteMode = new System.Windows.Forms.CheckBox();
            this.tbNumRegisterRead = new System.Windows.Forms.TextBox();
            this.tbBeginRegisterRead = new System.Windows.Forms.TextBox();
            this.cbReadMode = new System.Windows.Forms.CheckBox();
            this.cbbRegister = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnSave = new System.Windows.Forms.Button();
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
            this.GroupBox1.Controls.Add(this.button12);
            this.GroupBox1.Controls.Add(this.button11);
            this.GroupBox1.Controls.Add(this.button9);
            this.GroupBox1.Controls.Add(this.button10);
            this.GroupBox1.Controls.Add(this.button5);
            this.GroupBox1.Controls.Add(this.button6);
            this.GroupBox1.Controls.Add(this.button7);
            this.GroupBox1.Controls.Add(this.button8);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.button4);
            this.GroupBox1.Controls.Add(this.button3);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GroupBox1.Location = new System.Drawing.Point(18, 317);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(644, 178);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Test Data";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(214, 144);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 25);
            this.button12.TabIndex = 22;
            this.button12.Text = "M1030";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(214, 116);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 25);
            this.button11.TabIndex = 21;
            this.button11.Text = "D1000";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(304, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 25);
            this.button9.TabIndex = 20;
            this.button9.Text = "M1021";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(214, 88);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 25);
            this.button10.TabIndex = 19;
            this.button10.Text = "M1020";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(484, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "M1013";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(394, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 25);
            this.button6.TabIndex = 17;
            this.button6.Text = "M1012";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(304, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 25);
            this.button7.TabIndex = 16;
            this.button7.Text = "M1011";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(214, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 25);
            this.button8.TabIndex = 15;
            this.button8.Text = "M1010";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Heart Bits";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Read Model";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Write Vision Result";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Write Trigger OK";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Read Trigger";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(484, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "M1003";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(394, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "M1002";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(304, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "M1001";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "M1000";
            this.button1.UseVisualStyleBackColor = true;
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
            // bnSave
            // 
            this.bnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnSave.Location = new System.Drawing.Point(21, 502);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(99, 30);
            this.bnSave.TabIndex = 15;
            this.bnSave.Text = "SAVE";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // Connect_PLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 539);
            this.Controls.Add(this.bnSave);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect_PLC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Connect_PLC_FormClosing);
            this.Load += new System.EventHandler(this.Connect_PLC_Load);
            this.GroupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbIpAddress;
        public System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button bnPing;
        private System.Windows.Forms.Button bnConnect;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.TextBox tbReceivedData;
        private System.Windows.Forms.TextBox tbSentData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumRegisterRead;
        private System.Windows.Forms.TextBox tbBeginRegisterRead;
        private System.Windows.Forms.ComboBox cbbRegister;
        private System.Windows.Forms.CheckBox cbReadMode;
        private System.Windows.Forms.CheckBox cbWriteMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bnSave;
    }
}