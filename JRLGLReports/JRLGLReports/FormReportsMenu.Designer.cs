namespace JRLGLReports
{
    partial class formReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReports));
            this.reportsMenu = new System.Windows.Forms.MenuStrip();
            this.trialBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTB = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportsMenu
            // 
            this.reportsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trialBalanceToolStripMenuItem});
            this.reportsMenu.Location = new System.Drawing.Point(0, 0);
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(1018, 24);
            this.reportsMenu.TabIndex = 0;
            this.reportsMenu.Text = "menuStrip1";
            // 
            // trialBalanceToolStripMenuItem
            // 
            this.trialBalanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTB,
            this.ledgerReportsToolStripMenuItem});
            this.trialBalanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trialBalanceToolStripMenuItem.Image")));
            this.trialBalanceToolStripMenuItem.Name = "trialBalanceToolStripMenuItem";
            this.trialBalanceToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.trialBalanceToolStripMenuItem.Text = "Legal Reports";
            // 
            // toolStripMenuItemTB
            // 
            this.toolStripMenuItemTB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemTB.Image")));
            this.toolStripMenuItemTB.Name = "toolStripMenuItemTB";
            this.toolStripMenuItemTB.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemTB.Text = "Trial Balance";
            this.toolStripMenuItemTB.Click += new System.EventHandler(this.toolStripMenuItemTB_Click);
            // 
            // ledgerReportsToolStripMenuItem
            // 
            this.ledgerReportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ledgerReportsToolStripMenuItem.Image")));
            this.ledgerReportsToolStripMenuItem.Name = "ledgerReportsToolStripMenuItem";
            this.ledgerReportsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ledgerReportsToolStripMenuItem.Text = "Ledger Reports";
            this.ledgerReportsToolStripMenuItem.Click += new System.EventHandler(this.ledgerReportsToolStripMenuItem_Click);
            // 
            // formReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1018, 462);
            this.Controls.Add(this.reportsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.reportsMenu;
            this.Name = "formReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.reportsMenu.ResumeLayout(false);
            this.reportsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip reportsMenu;
        private System.Windows.Forms.ToolStripMenuItem trialBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTB;
        private System.Windows.Forms.ToolStripMenuItem ledgerReportsToolStripMenuItem;
    }
}

