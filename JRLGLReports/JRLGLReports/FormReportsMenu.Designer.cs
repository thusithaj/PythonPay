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
            this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hierachyOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportsMenu
            // 
            this.reportsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trialBalanceToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.reportsMenu.Location = new System.Drawing.Point(0, 0);
            this.reportsMenu.MdiWindowListItem = this.windowToolStripMenuItem;
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(1018, 24);
            this.reportsMenu.TabIndex = 0;
            this.reportsMenu.Text = "menuStrip1";
            // 
            // trialBalanceToolStripMenuItem
            // 
            this.trialBalanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTB,
            this.ledgerReportsToolStripMenuItem,
            this.balanceSheetToolStripMenuItem,
            this.profitLossToolStripMenuItem,
            this.cashflowToolStripMenuItem});
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
            // balanceSheetToolStripMenuItem
            // 
            this.balanceSheetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("balanceSheetToolStripMenuItem.Image")));
            this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.balanceSheetToolStripMenuItem.Text = "Balance Sheet";
            this.balanceSheetToolStripMenuItem.Click += new System.EventHandler(this.balanceSheetToolStripMenuItem_Click);
            // 
            // profitLossToolStripMenuItem
            // 
            this.profitLossToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profitLossToolStripMenuItem.Image")));
            this.profitLossToolStripMenuItem.Name = "profitLossToolStripMenuItem";
            this.profitLossToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.profitLossToolStripMenuItem.Text = "Profit && Loss";
            this.profitLossToolStripMenuItem.Click += new System.EventHandler(this.profitLossToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hierachyOfAccountsToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // hierachyOfAccountsToolStripMenuItem
            // 
            this.hierachyOfAccountsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hierachyOfAccountsToolStripMenuItem.Image")));
            this.hierachyOfAccountsToolStripMenuItem.Name = "hierachyOfAccountsToolStripMenuItem";
            this.hierachyOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.hierachyOfAccountsToolStripMenuItem.Text = "Hierachy of Accounts";
            this.hierachyOfAccountsToolStripMenuItem.Visible = false;
            this.hierachyOfAccountsToolStripMenuItem.Click += new System.EventHandler(this.hierachyOfAccountsToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileToolStripMenuItem.Text = "Tile Horizontal";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHelpToolStripMenuItem.Image")));
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // cashflowToolStripMenuItem
            // 
            this.cashflowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cashflowToolStripMenuItem.Image")));
            this.cashflowToolStripMenuItem.Name = "cashflowToolStripMenuItem";
            this.cashflowToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cashflowToolStripMenuItem.Text = "Cashflow";
            this.cashflowToolStripMenuItem.Click += new System.EventHandler(this.cashflowToolStripMenuItem_Click);
            // 
            // formReports
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
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
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hierachyOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashflowToolStripMenuItem;
    }
}

