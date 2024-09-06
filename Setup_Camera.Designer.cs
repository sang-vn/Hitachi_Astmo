namespace Hitachi_Astemo
{
    partial class Setup_Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup_Camera));
            this.label1 = new System.Windows.Forms.Label();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.bnOpen = new System.Windows.Forms.Button();
            this.bnClose = new System.Windows.Forms.Button();
            this.cbTriggerMode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSoftTrigger = new System.Windows.Forms.CheckBox();
            this.bnStart = new System.Windows.Forms.Button();
            this.bnStop = new System.Windows.Forms.Button();
            this.bnTrigger = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFrameRate = new System.Windows.Forms.TextBox();
            this.tbGain = new System.Windows.Forms.TextBox();
            this.tbExposureTime = new System.Windows.Forms.TextBox();
            this.bnGetPara = new System.Windows.Forms.Button();
            this.bnSetParameters = new System.Windows.Forms.Button();
            this.bnDrawPolygon = new System.Windows.Forms.Button();
            this.bnSaveOriginImage = new System.Windows.Forms.Button();
            this.bnSaveRenderImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnFindDevice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMERA 1";
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(173, 33);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(386, 21);
            this.cbDeviceList.TabIndex = 1;
            // 
            // bnOpen
            // 
            this.bnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnOpen.Location = new System.Drawing.Point(21, 65);
            this.bnOpen.Name = "bnOpen";
            this.bnOpen.Size = new System.Drawing.Size(118, 23);
            this.bnOpen.TabIndex = 2;
            this.bnOpen.Text = "Open Device";
            this.bnOpen.UseVisualStyleBackColor = true;
            this.bnOpen.Click += new System.EventHandler(this.bnOpen_Click);
            // 
            // bnClose
            // 
            this.bnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnClose.Location = new System.Drawing.Point(21, 93);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(118, 23);
            this.bnClose.TabIndex = 3;
            this.bnClose.Text = "Close Device";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // cbTriggerMode
            // 
            this.cbTriggerMode.FormattingEnabled = true;
            this.cbTriggerMode.Items.AddRange(new object[] {
            "Continious",
            "Trigger"});
            this.cbTriggerMode.Location = new System.Drawing.Point(173, 67);
            this.cbTriggerMode.Name = "cbTriggerMode";
            this.cbTriggerMode.Size = new System.Drawing.Size(121, 21);
            this.cbTriggerMode.TabIndex = 4;
            this.cbTriggerMode.Text = "Trigger Mode";
            this.cbTriggerMode.SelectedIndexChanged += new System.EventHandler(this.cbTriggerMode_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(21, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cbSoftTrigger
            // 
            this.cbSoftTrigger.AutoSize = true;
            this.cbSoftTrigger.Location = new System.Drawing.Point(173, 97);
            this.cbSoftTrigger.Name = "cbSoftTrigger";
            this.cbSoftTrigger.Size = new System.Drawing.Size(104, 17);
            this.cbSoftTrigger.TabIndex = 6;
            this.cbSoftTrigger.Text = "Trigger Software";
            this.cbSoftTrigger.UseVisualStyleBackColor = true;
            this.cbSoftTrigger.CheckedChanged += new System.EventHandler(this.cbSoftTrigger_CheckedChanged);
            // 
            // bnStart
            // 
            this.bnStart.Location = new System.Drawing.Point(332, 65);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(97, 23);
            this.bnStart.TabIndex = 7;
            this.bnStart.Text = "Start";
            this.bnStart.UseVisualStyleBackColor = true;
            this.bnStart.Click += new System.EventHandler(this.bnStart_Click);
            // 
            // bnStop
            // 
            this.bnStop.Location = new System.Drawing.Point(332, 93);
            this.bnStop.Name = "bnStop";
            this.bnStop.Size = new System.Drawing.Size(97, 23);
            this.bnStop.TabIndex = 8;
            this.bnStop.Text = "Stop";
            this.bnStop.UseVisualStyleBackColor = true;
            this.bnStop.Click += new System.EventHandler(this.bnStop_Click);
            // 
            // bnTrigger
            // 
            this.bnTrigger.Location = new System.Drawing.Point(466, 65);
            this.bnTrigger.Name = "bnTrigger";
            this.bnTrigger.Size = new System.Drawing.Size(93, 23);
            this.bnTrigger.TabIndex = 9;
            this.bnTrigger.Text = "Trigger Once";
            this.bnTrigger.UseVisualStyleBackColor = true;
            this.bnTrigger.Click += new System.EventHandler(this.bnTrigger_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Exposure Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Frame Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = ":";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFrameRate);
            this.groupBox1.Controls.Add(this.tbGain);
            this.groupBox1.Controls.Add(this.tbExposureTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 528);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(209, 98);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Location = new System.Drawing.Point(122, 72);
            this.tbFrameRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(76, 20);
            this.tbFrameRate.TabIndex = 18;
            // 
            // tbGain
            // 
            this.tbGain.Location = new System.Drawing.Point(122, 47);
            this.tbGain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(76, 20);
            this.tbGain.TabIndex = 17;
            // 
            // tbExposureTime
            // 
            this.tbExposureTime.Location = new System.Drawing.Point(122, 22);
            this.tbExposureTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbExposureTime.Name = "tbExposureTime";
            this.tbExposureTime.Size = new System.Drawing.Size(76, 20);
            this.tbExposureTime.TabIndex = 16;
            // 
            // bnGetPara
            // 
            this.bnGetPara.Location = new System.Drawing.Point(238, 552);
            this.bnGetPara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnGetPara.Name = "bnGetPara";
            this.bnGetPara.Size = new System.Drawing.Size(92, 19);
            this.bnGetPara.TabIndex = 17;
            this.bnGetPara.Text = "Get Parameters";
            this.bnGetPara.UseVisualStyleBackColor = true;
            this.bnGetPara.Click += new System.EventHandler(this.bnGetPara_Click);
            // 
            // bnSetParameters
            // 
            this.bnSetParameters.Location = new System.Drawing.Point(238, 578);
            this.bnSetParameters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnSetParameters.Name = "bnSetParameters";
            this.bnSetParameters.Size = new System.Drawing.Size(92, 19);
            this.bnSetParameters.TabIndex = 18;
            this.bnSetParameters.Text = "Set Parameters";
            this.bnSetParameters.UseVisualStyleBackColor = true;
            this.bnSetParameters.Click += new System.EventHandler(this.bnSetParameters_Click);
            // 
            // bnDrawPolygon
            // 
            this.bnDrawPolygon.Location = new System.Drawing.Point(16, 17);
            this.bnDrawPolygon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnDrawPolygon.Name = "bnDrawPolygon";
            this.bnDrawPolygon.Size = new System.Drawing.Size(133, 23);
            this.bnDrawPolygon.TabIndex = 19;
            this.bnDrawPolygon.Text = "Draw Polygon";
            this.bnDrawPolygon.UseVisualStyleBackColor = true;
            this.bnDrawPolygon.Click += new System.EventHandler(this.bnDrawPolygon_Click);
            // 
            // bnSaveOriginImage
            // 
            this.bnSaveOriginImage.Location = new System.Drawing.Point(16, 44);
            this.bnSaveOriginImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnSaveOriginImage.Name = "bnSaveOriginImage";
            this.bnSaveOriginImage.Size = new System.Drawing.Size(133, 23);
            this.bnSaveOriginImage.TabIndex = 20;
            this.bnSaveOriginImage.Text = "Save Origin Image";
            this.bnSaveOriginImage.UseVisualStyleBackColor = true;
            this.bnSaveOriginImage.Click += new System.EventHandler(this.bnSaveOriginImage_Click);
            // 
            // bnSaveRenderImage
            // 
            this.bnSaveRenderImage.Location = new System.Drawing.Point(16, 71);
            this.bnSaveRenderImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnSaveRenderImage.Name = "bnSaveRenderImage";
            this.bnSaveRenderImage.Size = new System.Drawing.Size(133, 23);
            this.bnSaveRenderImage.TabIndex = 21;
            this.bnSaveRenderImage.Text = "Save Render Image";
            this.bnSaveRenderImage.UseVisualStyleBackColor = true;
            this.bnSaveRenderImage.Click += new System.EventHandler(this.bnSaveRenderImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnSaveOriginImage);
            this.groupBox2.Controls.Add(this.bnSaveRenderImage);
            this.groupBox2.Controls.Add(this.bnDrawPolygon);
            this.groupBox2.Location = new System.Drawing.Point(396, 528);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(164, 98);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save/ Draw";
            // 
            // bnFindDevice
            // 
            this.bnFindDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bnFindDevice.Location = new System.Drawing.Point(21, 32);
            this.bnFindDevice.Name = "bnFindDevice";
            this.bnFindDevice.Size = new System.Drawing.Size(118, 23);
            this.bnFindDevice.TabIndex = 23;
            this.bnFindDevice.Text = "Find Device";
            this.bnFindDevice.UseVisualStyleBackColor = true;
            this.bnFindDevice.Click += new System.EventHandler(this.bnFindDevice_Click);
            // 
            // Setup_Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 635);
            this.Controls.Add(this.bnFindDevice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bnSetParameters);
            this.Controls.Add(this.bnGetPara);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnTrigger);
            this.Controls.Add(this.bnStop);
            this.Controls.Add(this.bnStart);
            this.Controls.Add(this.cbSoftTrigger);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbTriggerMode);
            this.Controls.Add(this.bnClose);
            this.Controls.Add(this.bnOpen);
            this.Controls.Add(this.cbDeviceList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Setup_Camera";
            this.Text = "Setup_Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setup_Camera_FormClosing);
            this.Load += new System.EventHandler(this.Setup_Camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDeviceList;
        private System.Windows.Forms.Button bnOpen;
        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.ComboBox cbTriggerMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbSoftTrigger;
        private System.Windows.Forms.Button bnStart;
        private System.Windows.Forms.Button bnStop;
        private System.Windows.Forms.Button bnTrigger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFrameRate;
        private System.Windows.Forms.TextBox tbGain;
        private System.Windows.Forms.TextBox tbExposureTime;
        private System.Windows.Forms.Button bnGetPara;
        private System.Windows.Forms.Button bnSetParameters;
        private System.Windows.Forms.Button bnDrawPolygon;
        private System.Windows.Forms.Button bnSaveOriginImage;
        private System.Windows.Forms.Button bnSaveRenderImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnFindDevice;
    }
}