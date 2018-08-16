namespace ReportsFormofGL
{
    partial class MenuCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCreation));
            this.buttonGroup = new System.Windows.Forms.GroupBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMenuList = new System.Windows.Forms.TabPage();
            this.dgvSubMenu = new System.Windows.Forms.DataGridView();
            this.dgvReportsMenus = new System.Windows.Forms.DataGridView();
            this.tpMenuAdd = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lHelpMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tReportForm = new System.Windows.Forms.TextBox();
            this.lDllName = new System.Windows.Forms.Label();
            this.tDllName = new System.Windows.Forms.TextBox();
            this.lMLevel = new System.Windows.Forms.Label();
            this.nMenuLevel = new System.Windows.Forms.NumericUpDown();
            this.lPMenu = new System.Windows.Forms.Label();
            this.cbParentMenu = new System.Windows.Forms.ComboBox();
            this.lMenuName = new System.Windows.Forms.Label();
            this.tMenuName = new System.Windows.Forms.TextBox();
            this.lbLocale = new System.Windows.Forms.ListBox();
            this.tDefaultName = new System.Windows.Forms.ComboBox();
            this.lStat = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lFilters = new System.Windows.Forms.Label();
            this.tFormFilter = new System.Windows.Forms.TextBox();
            this.buttonGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsMenus)).BeginInit();
            this.tpMenuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMenuLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGroup
            // 
            this.buttonGroup.Controls.Add(this.tFormFilter);
            this.buttonGroup.Controls.Add(this.lFilters);
            this.buttonGroup.Controls.Add(this.bClose);
            this.buttonGroup.Controls.Add(this.bSave);
            this.buttonGroup.Controls.Add(this.bEdit);
            this.buttonGroup.Controls.Add(this.bAdd);
            this.buttonGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroup.Location = new System.Drawing.Point(0, 0);
            this.buttonGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroup.Size = new System.Drawing.Size(1110, 66);
            this.buttonGroup.TabIndex = 1;
            this.buttonGroup.TabStop = false;
            // 
            // bClose
            // 
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(423, 9);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(126, 52);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "&Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.Image = ((System.Drawing.Image)(resources.GetObject("bSave.Image")));
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(288, 9);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(126, 52);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "&Save";
            this.bSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEdit
            // 
            this.bEdit.Image = ((System.Drawing.Image)(resources.GetObject("bEdit.Image")));
            this.bEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEdit.Location = new System.Drawing.Point(153, 9);
            this.bEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(126, 52);
            this.bEdit.TabIndex = 1;
            this.bEdit.Text = "&Edit";
            this.bEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Image = ((System.Drawing.Image)(resources.GetObject("bAdd.Image")));
            this.bAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAdd.Location = new System.Drawing.Point(18, 9);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(126, 52);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "&New";
            this.bAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMenuList);
            this.tabControl1.Controls.Add(this.tpMenuAdd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 514);
            this.tabControl1.TabIndex = 2;
            // 
            // tpMenuList
            // 
            this.tpMenuList.Controls.Add(this.dgvSubMenu);
            this.tpMenuList.Controls.Add(this.dgvReportsMenus);
            this.tpMenuList.Location = new System.Drawing.Point(4, 29);
            this.tpMenuList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpMenuList.Name = "tpMenuList";
            this.tpMenuList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpMenuList.Size = new System.Drawing.Size(1102, 481);
            this.tpMenuList.TabIndex = 0;
            this.tpMenuList.Text = "Menu List";
            this.tpMenuList.UseVisualStyleBackColor = true;
            // 
            // dgvSubMenu
            // 
            this.dgvSubMenu.AllowUserToAddRows = false;
            this.dgvSubMenu.AllowUserToDeleteRows = false;
            this.dgvSubMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSubMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubMenu.Location = new System.Drawing.Point(668, 102);
            this.dgvSubMenu.Name = "dgvSubMenu";
            this.dgvSubMenu.ReadOnly = true;
            this.dgvSubMenu.Size = new System.Drawing.Size(240, 150);
            this.dgvSubMenu.TabIndex = 1;
            // 
            // dgvReportsMenus
            // 
            this.dgvReportsMenus.AllowUserToAddRows = false;
            this.dgvReportsMenus.AllowUserToDeleteRows = false;
            this.dgvReportsMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportsMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportsMenus.Location = new System.Drawing.Point(4, 5);
            this.dgvReportsMenus.Name = "dgvReportsMenus";
            this.dgvReportsMenus.ReadOnly = true;
            this.dgvReportsMenus.Size = new System.Drawing.Size(1094, 471);
            this.dgvReportsMenus.TabIndex = 0;
            this.dgvReportsMenus.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReportsMenus_RowHeaderMouseClick);
            this.dgvReportsMenus.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReportsMenus_RowHeaderMouseDoubleClick);
            // 
            // tpMenuAdd
            // 
            this.tpMenuAdd.Controls.Add(this.cbStatus);
            this.tpMenuAdd.Controls.Add(this.lStat);
            this.tpMenuAdd.Controls.Add(this.tDefaultName);
            this.tpMenuAdd.Controls.Add(this.label2);
            this.tpMenuAdd.Controls.Add(this.lHelpMsg);
            this.tpMenuAdd.Controls.Add(this.label1);
            this.tpMenuAdd.Controls.Add(this.tReportForm);
            this.tpMenuAdd.Controls.Add(this.lDllName);
            this.tpMenuAdd.Controls.Add(this.tDllName);
            this.tpMenuAdd.Controls.Add(this.lMLevel);
            this.tpMenuAdd.Controls.Add(this.nMenuLevel);
            this.tpMenuAdd.Controls.Add(this.lPMenu);
            this.tpMenuAdd.Controls.Add(this.cbParentMenu);
            this.tpMenuAdd.Controls.Add(this.lMenuName);
            this.tpMenuAdd.Controls.Add(this.tMenuName);
            this.tpMenuAdd.Controls.Add(this.lbLocale);
            this.tpMenuAdd.Location = new System.Drawing.Point(4, 29);
            this.tpMenuAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpMenuAdd.Name = "tpMenuAdd";
            this.tpMenuAdd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpMenuAdd.Size = new System.Drawing.Size(1102, 481);
            this.tpMenuAdd.TabIndex = 1;
            this.tpMenuAdd.Text = "Menu Operations";
            this.tpMenuAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default Name :";
            // 
            // lHelpMsg
            // 
            this.lHelpMsg.ForeColor = System.Drawing.Color.Blue;
            this.lHelpMsg.Location = new System.Drawing.Point(527, 29);
            this.lHelpMsg.Name = "lHelpMsg";
            this.lHelpMsg.Size = new System.Drawing.Size(490, 267);
            this.lHelpMsg.TabIndex = 13;
            this.lHelpMsg.Text = "Menu Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Report Form :";
            // 
            // tReportForm
            // 
            this.tReportForm.Font = new System.Drawing.Font("BhashitaComplex", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tReportForm.Location = new System.Drawing.Point(149, 264);
            this.tReportForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tReportForm.Name = "tReportForm";
            this.tReportForm.Size = new System.Drawing.Size(357, 32);
            this.tReportForm.TabIndex = 12;
            // 
            // lDllName
            // 
            this.lDllName.AutoSize = true;
            this.lDllName.Location = new System.Drawing.Point(7, 225);
            this.lDllName.Name = "lDllName";
            this.lDllName.Size = new System.Drawing.Size(138, 20);
            this.lDllName.TabIndex = 9;
            this.lDllName.Text = "Name of the DLL :";
            // 
            // tDllName
            // 
            this.tDllName.Font = new System.Drawing.Font("BhashitaComplex", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDllName.Location = new System.Drawing.Point(149, 222);
            this.tDllName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tDllName.Name = "tDllName";
            this.tDllName.Size = new System.Drawing.Size(357, 32);
            this.tDllName.TabIndex = 10;
            // 
            // lMLevel
            // 
            this.lMLevel.AutoSize = true;
            this.lMLevel.Location = new System.Drawing.Point(47, 150);
            this.lMLevel.Name = "lMLevel";
            this.lMLevel.Size = new System.Drawing.Size(98, 20);
            this.lMLevel.TabIndex = 5;
            this.lMLevel.Text = "Menu Level :";
            // 
            // nMenuLevel
            // 
            this.nMenuLevel.Location = new System.Drawing.Point(149, 147);
            this.nMenuLevel.Name = "nMenuLevel";
            this.nMenuLevel.Size = new System.Drawing.Size(120, 26);
            this.nMenuLevel.TabIndex = 6;
            this.nMenuLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lPMenu
            // 
            this.lPMenu.AutoSize = true;
            this.lPMenu.Location = new System.Drawing.Point(37, 189);
            this.lPMenu.Name = "lPMenu";
            this.lPMenu.Size = new System.Drawing.Size(108, 20);
            this.lPMenu.TabIndex = 7;
            this.lPMenu.Text = "Parent Menu :";
            // 
            // cbParentMenu
            // 
            this.cbParentMenu.FormattingEnabled = true;
            this.cbParentMenu.Location = new System.Drawing.Point(149, 186);
            this.cbParentMenu.Name = "cbParentMenu";
            this.cbParentMenu.Size = new System.Drawing.Size(357, 28);
            this.cbParentMenu.TabIndex = 8;
            this.cbParentMenu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lMenuName
            // 
            this.lMenuName.AutoSize = true;
            this.lMenuName.Location = new System.Drawing.Point(42, 110);
            this.lMenuName.Name = "lMenuName";
            this.lMenuName.Size = new System.Drawing.Size(103, 20);
            this.lMenuName.TabIndex = 3;
            this.lMenuName.Text = "Menu Name :";
            // 
            // tMenuName
            // 
            this.tMenuName.Font = new System.Drawing.Font("BhashitaComplex", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMenuName.Location = new System.Drawing.Point(149, 107);
            this.tMenuName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tMenuName.Name = "tMenuName";
            this.tMenuName.Size = new System.Drawing.Size(357, 32);
            this.tMenuName.TabIndex = 4;
            // 
            // lbLocale
            // 
            this.lbLocale.FormattingEnabled = true;
            this.lbLocale.ItemHeight = 20;
            this.lbLocale.Location = new System.Drawing.Point(149, 19);
            this.lbLocale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbLocale.Name = "lbLocale";
            this.lbLocale.Size = new System.Drawing.Size(357, 44);
            this.lbLocale.TabIndex = 0;
            // 
            // tDefaultName
            // 
            this.tDefaultName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tDefaultName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tDefaultName.BackColor = System.Drawing.Color.LemonChiffon;
            this.tDefaultName.FormattingEnabled = true;
            this.tDefaultName.Location = new System.Drawing.Point(149, 69);
            this.tDefaultName.Name = "tDefaultName";
            this.tDefaultName.Size = new System.Drawing.Size(357, 28);
            this.tDefaultName.TabIndex = 2;
            // 
            // lStat
            // 
            this.lStat.AutoSize = true;
            this.lStat.Location = new System.Drawing.Point(76, 306);
            this.lStat.Name = "lStat";
            this.lStat.Size = new System.Drawing.Size(64, 20);
            this.lStat.TabIndex = 14;
            this.lStat.Text = "Status :";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(149, 304);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(205, 28);
            this.cbStatus.TabIndex = 15;
            // 
            // lFilters
            // 
            this.lFilters.AutoSize = true;
            this.lFilters.Location = new System.Drawing.Point(739, 41);
            this.lFilters.Name = "lFilters";
            this.lFilters.Size = new System.Drawing.Size(101, 20);
            this.lFilters.TabIndex = 12;
            this.lFilters.Text = "Form Filters :";
            this.lFilters.Visible = false;
            // 
            // tFormFilter
            // 
            this.tFormFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tFormFilter.Location = new System.Drawing.Point(847, 40);
            this.tFormFilter.MaxLength = 1;
            this.tFormFilter.Name = "tFormFilter";
            this.tFormFilter.Size = new System.Drawing.Size(36, 26);
            this.tFormFilter.TabIndex = 13;
            this.tFormFilter.Text = "A";
            this.tFormFilter.Visible = false;
            // 
            // MenuCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 580);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuCreation";
            this.Text = "MenuCreation";
            this.Load += new System.EventHandler(this.MenuCreation_Load);
            this.buttonGroup.ResumeLayout(false);
            this.buttonGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpMenuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsMenus)).EndInit();
            this.tpMenuAdd.ResumeLayout(false);
            this.tpMenuAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMenuLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox buttonGroup;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMenuList;
        private System.Windows.Forms.TabPage tpMenuAdd;
        private System.Windows.Forms.Label lPMenu;
        private System.Windows.Forms.ComboBox cbParentMenu;
        private System.Windows.Forms.Label lMenuName;
        private System.Windows.Forms.TextBox tMenuName;
        private System.Windows.Forms.ListBox lbLocale;
        private System.Windows.Forms.DataGridView dgvReportsMenus;
        private System.Windows.Forms.Label lMLevel;
        private System.Windows.Forms.NumericUpDown nMenuLevel;
        private System.Windows.Forms.Label lDllName;
        private System.Windows.Forms.TextBox tDllName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tReportForm;
        private System.Windows.Forms.Label lHelpMsg;
        private System.Windows.Forms.DataGridView dgvSubMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tDefaultName;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lStat;
        private System.Windows.Forms.Label lFilters;
        private System.Windows.Forms.TextBox tFormFilter;
    }
}