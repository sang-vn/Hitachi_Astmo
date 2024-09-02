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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.tbExposureTime = new System.Windows.Forms.TextBox();
            this.tbGain = new System.Windows.Forms.TextBox();
            this.tbFrameRate = new System.Windows.Forms.TextBox();
            this.bnGetPara = new System.Windows.Forms.Button();
            this.bnSetParameters = new System.Windows.Forms.Button();
            this.bnDrawPolygon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMERA 1";
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(28, 41);
            this.cbDeviceList.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(717, 24);
            this.cbDeviceList.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOpen.Location = new System.Drawing.Point(28, 80);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 28);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Device";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(28, 115);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close Device";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cbTriggerMode
            // 
            this.cbTriggerMode.FormattingEnabled = true;
            this.cbTriggerMode.Items.AddRange(new object[] {
            "Continious",
            "Trigger"});
            this.cbTriggerMode.Location = new System.Drawing.Point(231, 82);
            this.cbTriggerMode.Margin = new System.Windows.Forms.Padding(4);
            this.cbTriggerMode.Name = "cbTriggerMode";
            this.cbTriggerMode.Size = new System.Drawing.Size(160, 24);
            this.cbTriggerMode.TabIndex = 4;
            this.cbTriggerMode.Text = "Continious";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = global::Hitachi_Astemo.Properties.Resources.ảnh_phong_cảnh;
            this.pictureBox1.Location = new System.Drawing.Point(28, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cbSoftTrigger
            // 
            this.cbSoftTrigger.AutoSize = true;
            this.cbSoftTrigger.Location = new System.Drawing.Point(231, 119);
            this.cbSoftTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.cbSoftTrigger.Name = "cbSoftTrigger";
            this.cbSoftTrigger.Size = new System.Drawing.Size(128, 20);
            this.cbSoftTrigger.TabIndex = 6;
            this.cbSoftTrigger.Text = "Trigger Software";
            this.cbSoftTrigger.UseVisualStyleBackColor = true;
            // 
            // bnStart
            // 
            this.bnStart.Location = new System.Drawing.Point(442, 80);
            this.bnStart.Margin = new System.Windows.Forms.Padding(4);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(129, 28);
            this.bnStart.TabIndex = 7;
            this.bnStart.Text = "Start";
            this.bnStart.UseVisualStyleBackColor = true;
            // 
            // bnStop
            // 
            this.bnStop.Location = new System.Drawing.Point(442, 115);
            this.bnStop.Margin = new System.Windows.Forms.Padding(4);
            this.bnStop.Name = "bnStop";
            this.bnStop.Size = new System.Drawing.Size(129, 28);
            this.bnStop.TabIndex = 8;
            this.bnStop.Text = "Stop";
            this.bnStop.UseVisualStyleBackColor = true;
            // 
            // bnTrigger
            // 
            this.bnTrigger.Location = new System.Drawing.Point(621, 80);
            this.bnTrigger.Margin = new System.Windows.Forms.Padding(4);
            this.bnTrigger.Name = "bnTrigger";
            this.bnTrigger.Size = new System.Drawing.Size(124, 28);
            this.bnTrigger.TabIndex = 9;
            this.bnTrigger.Text = "Trigger Once";
            this.bnTrigger.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Exposure Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Frame Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(28, 650);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 120);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // tbExposureTime
            // 
            this.tbExposureTime.Location = new System.Drawing.Point(163, 27);
            this.tbExposureTime.Name = "tbExposureTime";
            this.tbExposureTime.Size = new System.Drawing.Size(100, 22);
            this.tbExposureTime.TabIndex = 16;
            // 
            // tbGain
            // 
            this.tbGain.Location = new System.Drawing.Point(163, 58);
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(100, 22);
            this.tbGain.TabIndex = 17;
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Location = new System.Drawing.Point(163, 88);
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(100, 22);
            this.tbFrameRate.TabIndex = 18;
            // 
            // bnGetPara
            // 
            this.bnGetPara.Location = new System.Drawing.Point(317, 680);
            this.bnGetPara.Name = "bnGetPara";
            this.bnGetPara.Size = new System.Drawing.Size(123, 23);
            this.bnGetPara.TabIndex = 17;
            this.bnGetPara.Text = "Get Parameters";
            this.bnGetPara.UseVisualStyleBackColor = true;
            // 
            // bnSetParameters
            // 
            this.bnSetParameters.Location = new System.Drawing.Point(317, 711);
            this.bnSetParameters.Name = "bnSetParameters";
            this.bnSetParameters.Size = new System.Drawing.Size(123, 23);
            this.bnSetParameters.TabIndex = 18;
            this.bnSetParameters.Text = "Set Parameters";
            this.bnSetParameters.UseVisualStyleBackColor = true;
            // 
            // bnDrawPolygon
            // 
            this.bnDrawPolygon.Location = new System.Drawing.Point(21, 21);
            this.bnDrawPolygon.Name = "bnDrawPolygon";
            this.bnDrawPolygon.Size = new System.Drawing.Size(177, 23);
            this.bnDrawPolygon.TabIndex = 19;
            this.bnDrawPolygon.Text = "Draw Polygon";
            this.bnDrawPolygon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save Origin Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Save Render Image";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.bnDrawPolygon);
            this.groupBox2.Location = new System.Drawing.Point(528, 650);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 120);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save/ Draw";
            // 
            // Setup_Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 782);
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
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cbDeviceList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setup_Camera";
            this.Text = "Setup_Camera";
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
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}