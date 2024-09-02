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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setupProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.setupCameraToolStripMenuItem,
            this.setupProgramsToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mainToolStripMenuItem.Text = "MAIN";
            // 
            // setupCameraToolStripMenuItem
            // 
            this.setupCameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oKToolStripMenuItem1,
            this.nGToolStripMenuItem1});
            this.setupCameraToolStripMenuItem.Name = "setupCameraToolStripMenuItem";
            this.setupCameraToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.setupCameraToolStripMenuItem.Text = "Setup Camera";
            this.setupCameraToolStripMenuItem.Click += new System.EventHandler(this.setupCameraToolStripMenuItem_Click);
            // 
            // oKToolStripMenuItem1
            // 
            this.oKToolStripMenuItem1.Name = "oKToolStripMenuItem1";
            this.oKToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.oKToolStripMenuItem1.Text = "OK";
            // 
            // nGToolStripMenuItem1
            // 
            this.nGToolStripMenuItem1.Name = "nGToolStripMenuItem1";
            this.nGToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nGToolStripMenuItem1.Text = "NG";
            // 
            // setupProgramsToolStripMenuItem
            // 
            this.setupProgramsToolStripMenuItem.Name = "setupProgramsToolStripMenuItem";
            this.setupProgramsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.setupProgramsToolStripMenuItem.Text = "Setup Programs";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 591);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "HITACHI ASTEMO INSPECTION SYSTEM BY VISION";
            this.UseWaitCursor = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nGToolStripMenuItem1;
    }
}

