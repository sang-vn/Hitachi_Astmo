namespace Hitachi_Astemo
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectPLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBlockEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.cogVerifierControl1 = new Cognex.VisionPro.Inspection.CogVerifierControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bnExportCVS = new System.Windows.Forms.Button();
            this.bnLive = new System.Windows.Forms.Button();
            this.bnTrigger = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cogDisplay1 = new Cognex.VisionPro.Display.CogDisplay();
            this.cogDisplay2 = new Cognex.VisionPro.Display.CogDisplay();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.setupCameraToolStripMenuItem,
            this.setupProgramsToolStripMenuItem,
            this.connectPLCToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.toolBlockEditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.mainToolStripMenuItem.Text = "MAIN";
            // 
            // setupCameraToolStripMenuItem
            // 
            this.setupCameraToolStripMenuItem.Name = "setupCameraToolStripMenuItem";
            this.setupCameraToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.setupCameraToolStripMenuItem.Text = "Setup Camera";
            this.setupCameraToolStripMenuItem.Click += new System.EventHandler(this.setupCameraToolStripMenuItem_Click);
            // 
            // setupProgramsToolStripMenuItem
            // 
            this.setupProgramsToolStripMenuItem.Name = "setupProgramsToolStripMenuItem";
            this.setupProgramsToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.setupProgramsToolStripMenuItem.Text = "Setup Programs";
            this.setupProgramsToolStripMenuItem.Click += new System.EventHandler(this.setupProgramsToolStripMenuItem_Click);
            // 
            // connectPLCToolStripMenuItem
            // 
            this.connectPLCToolStripMenuItem.Name = "connectPLCToolStripMenuItem";
            this.connectPLCToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.connectPLCToolStripMenuItem.Text = "Connect PLC";
            this.connectPLCToolStripMenuItem.Click += new System.EventHandler(this.connectPLCToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // toolBlockEditToolStripMenuItem
            // 
            this.toolBlockEditToolStripMenuItem.Name = "toolBlockEditToolStripMenuItem";
            this.toolBlockEditToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.toolBlockEditToolStripMenuItem.Text = "ToolBlockEdit";
            this.toolBlockEditToolStripMenuItem.Click += new System.EventHandler(this.toolBlockEditToolStripMenuItem_Click);
            // 
            // cogVerifierControl1
            // 
            this.cogVerifierControl1.Enabled = false;
            this.cogVerifierControl1.Location = new System.Drawing.Point(0, 0);
            this.cogVerifierControl1.Name = "cogVerifierControl1";
            this.cogVerifierControl1.Size = new System.Drawing.Size(800, 450);
            this.cogVerifierControl1.Subject = null;
            this.cogVerifierControl1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.bnTrigger, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bnLive, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bnExportCVS, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 568);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(541, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.UseWaitCursor = true;
            // 
            // bnExportCVS
            // 
            this.bnExportCVS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnExportCVS.Location = new System.Drawing.Point(327, 3);
            this.bnExportCVS.Name = "bnExportCVS";
            this.bnExportCVS.Size = new System.Drawing.Size(211, 38);
            this.bnExportCVS.TabIndex = 2;
            this.bnExportCVS.Text = "Export .cvs";
            this.bnExportCVS.UseVisualStyleBackColor = true;
            this.bnExportCVS.UseWaitCursor = true;
            // 
            // bnLive
            // 
            this.bnLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnLive.Location = new System.Drawing.Point(165, 3);
            this.bnLive.Name = "bnLive";
            this.bnLive.Size = new System.Drawing.Size(156, 38);
            this.bnLive.TabIndex = 1;
            this.bnLive.Text = "Live";
            this.bnLive.UseVisualStyleBackColor = true;
            this.bnLive.UseWaitCursor = true;
            this.bnLive.Click += new System.EventHandler(this.bnLive_Click);
            // 
            // bnTrigger
            // 
            this.bnTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnTrigger.Location = new System.Drawing.Point(3, 3);
            this.bnTrigger.Name = "bnTrigger";
            this.bnTrigger.Size = new System.Drawing.Size(156, 38);
            this.bnTrigger.TabIndex = 0;
            this.bnTrigger.Text = "Trigger";
            this.bnTrigger.UseVisualStyleBackColor = true;
            this.bnTrigger.UseWaitCursor = true;
            this.bnTrigger.Click += new System.EventHandler(this.bnTrigger_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1083, 615);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cogDisplay1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cogDisplay2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1077, 559);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(532, 553);
            this.cogDisplay1.TabIndex = 0;
            // 
            // cogDisplay2
            // 
            this.cogDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay2.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay2.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplay2.DoubleTapZoomCycleLength = 2;
            this.cogDisplay2.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay2.Location = new System.Drawing.Point(541, 3);
            this.cogDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay2.MouseWheelSensitivity = 1D;
            this.cogDisplay2.Name = "cogDisplay2";
            this.cogDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay2.OcxState")));
            this.cogDisplay2.Size = new System.Drawing.Size(533, 553);
            this.cogDisplay2.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "HITACHI ASTEMO INSPECTION SYSTEM";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectPLCToolStripMenuItem;
        private System.ServiceProcess.ServiceController serviceController1;
        private Cognex.VisionPro.Inspection.CogVerifierControl cogVerifierControl1;
        private System.Windows.Forms.ToolStripMenuItem toolBlockEditToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bnTrigger;
        private System.Windows.Forms.Button bnLive;
        private System.Windows.Forms.Button bnExportCVS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Cognex.VisionPro.Display.CogDisplay cogDisplay1;
        private Cognex.VisionPro.Display.CogDisplay cogDisplay2;
    }
}

