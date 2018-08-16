namespace ReportsFormofGL
{
    partial class ReportConfigurator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportConfigurator));
            this.ReportHeader = new System.Windows.Forms.GroupBox();
            this.nPrintOrder = new System.Windows.Forms.NumericUpDown();
            this.cbHeading = new System.Windows.Forms.ComboBox();
            this.bAddDef = new System.Windows.Forms.Button();
            this.tsReport = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsMsg = new System.Windows.Forms.ToolStripLabel();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMoveR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMoveL = new System.Windows.Forms.ToolStripButton();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.lReportType = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.lSection = new System.Windows.Forms.Label();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.nLOD = new System.Windows.Forms.NumericUpDown();
            this.lAccount = new System.Windows.Forms.Label();
            this.tParentDesc = new System.Windows.Forms.TextBox();
            this.lPHeading = new System.Windows.Forms.Label();
            this.lLOD = new System.Windows.Forms.Label();
            this.tHeading = new System.Windows.Forms.TextBox();
            this.lHeading = new System.Windows.Forms.Label();
            this.cbReportName = new System.Windows.Forms.ComboBox();
            this.lReport = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvReportFormat = new System.Windows.Forms.TreeView();
            this.dgvAcct = new System.Windows.Forms.DataGridView();
            this.lvSubAccts = new System.Windows.Forms.ListView();
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lmsg = new System.Windows.Forms.Label();
            this.lHead = new System.Windows.Forms.Label();
            this.lHeadAccount = new System.Windows.Forms.Label();
            this.bMove = new System.Windows.Forms.Button();
            this.ReportHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrintOrder)).BeginInit();
            this.tsReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLOD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.Add(this.nPrintOrder);
            this.ReportHeader.Controls.Add(this.cbHeading);
            this.ReportHeader.Controls.Add(this.bAddDef);
            this.ReportHeader.Controls.Add(this.tsReport);
            this.ReportHeader.Controls.Add(this.cbReportType);
            this.ReportHeader.Controls.Add(this.lReportType);
            this.ReportHeader.Controls.Add(this.cbSection);
            this.ReportHeader.Controls.Add(this.lSection);
            this.ReportHeader.Controls.Add(this.cbAccount);
            this.ReportHeader.Controls.Add(this.nLOD);
            this.ReportHeader.Controls.Add(this.lAccount);
            this.ReportHeader.Controls.Add(this.tParentDesc);
            this.ReportHeader.Controls.Add(this.lPHeading);
            this.ReportHeader.Controls.Add(this.lLOD);
            this.ReportHeader.Controls.Add(this.tHeading);
            this.ReportHeader.Controls.Add(this.lHeading);
            this.ReportHeader.Controls.Add(this.cbReportName);
            this.ReportHeader.Controls.Add(this.lReport);
            this.ReportHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportHeader.Location = new System.Drawing.Point(3, 3);
            this.ReportHeader.Margin = new System.Windows.Forms.Padding(4);
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new System.Windows.Forms.Padding(4);
            this.ReportHeader.Size = new System.Drawing.Size(837, 352);
            this.ReportHeader.TabIndex = 0;
            this.ReportHeader.TabStop = false;
            this.ReportHeader.Text = "Header ";
            // 
            // nPrintOrder
            // 
            this.nPrintOrder.Location = new System.Drawing.Point(349, 135);
            this.nPrintOrder.Name = "nPrintOrder";
            this.nPrintOrder.Size = new System.Drawing.Size(120, 22);
            this.nPrintOrder.TabIndex = 17;
            this.nPrintOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbHeading
            // 
            this.cbHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbHeading.FormattingEnabled = true;
            this.cbHeading.Location = new System.Drawing.Point(129, 78);
            this.cbHeading.Name = "cbHeading";
            this.cbHeading.Size = new System.Drawing.Size(365, 24);
            this.cbHeading.TabIndex = 16;
            this.cbHeading.SelectedIndexChanged += new System.EventHandler(this.cbHeading_SelectedIndexChanged);
            // 
            // bAddDef
            // 
            this.bAddDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bAddDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddDef.Image = ((System.Drawing.Image)(resources.GetObject("bAddDef.Image")));
            this.bAddDef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddDef.Location = new System.Drawing.Point(129, 156);
            this.bAddDef.Name = "bAddDef";
            this.bAddDef.Size = new System.Drawing.Size(121, 25);
            this.bAddDef.TabIndex = 14;
            this.bAddDef.Text = "Save Definition";
            this.bAddDef.UseVisualStyleBackColor = false;
            this.bAddDef.Visible = false;
            this.bAddDef.Click += new System.EventHandler(this.bAddDef_Click);
            // 
            // tsReport
            // 
            this.tsReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbView,
            this.tsbSave,
            this.tsMsg,
            this.tsbClose,
            this.toolStripSeparator1,
            this.tsMoveR,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.tsMoveL});
            this.tsReport.Location = new System.Drawing.Point(4, 321);
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(829, 27);
            this.tsReport.TabIndex = 15;
            this.tsReport.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.AutoSize = false;
            this.tsbAdd.BackColor = System.Drawing.Color.Yellow;
            this.tsbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(115, 24);
            this.tsbAdd.Text = "Define New";
            this.tsbAdd.ToolTipText = "Define New Report Format";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.AutoSize = false;
            this.tsbEdit.BackColor = System.Drawing.Color.Yellow;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(115, 24);
            this.tsbEdit.Text = "&Edit Format";
            this.tsbEdit.ToolTipText = "Edit Existing Report Format";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbView
            // 
            this.tsbView.AutoSize = false;
            this.tsbView.BackColor = System.Drawing.Color.SteelBlue;
            this.tsbView.ForeColor = System.Drawing.Color.Yellow;
            this.tsbView.Image = ((System.Drawing.Image)(resources.GetObject("tsbView.Image")));
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(115, 24);
            this.tsbView.Text = "&View Format";
            this.tsbView.Click += new System.EventHandler(this.tsbView_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.AutoSize = false;
            this.tsbSave.BackColor = System.Drawing.Color.MediumBlue;
            this.tsbSave.ForeColor = System.Drawing.Color.Yellow;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(115, 24);
            this.tsbSave.Text = "&Save Format";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsMsg
            // 
            this.tsMsg.AutoSize = false;
            this.tsMsg.ForeColor = System.Drawing.Color.Red;
            this.tsMsg.Name = "tsMsg";
            this.tsMsg.Size = new System.Drawing.Size(150, 24);
            this.tsMsg.Text = "Select ";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(105, 24);
            this.tsbClose.Text = "&Close Form";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsMoveR
            // 
            this.tsMoveR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMoveR.Image = ((System.Drawing.Image)(resources.GetObject("tsMoveR.Image")));
            this.tsMoveR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMoveR.Name = "tsMoveR";
            this.tsMoveR.Size = new System.Drawing.Size(23, 24);
            this.tsMoveR.Text = "Move Item Right";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(73, 20);
            this.toolStripLabel2.Text = "                ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsMoveL
            // 
            this.tsMoveL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMoveL.Image = ((System.Drawing.Image)(resources.GetObject("tsMoveL.Image")));
            this.tsMoveL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMoveL.Name = "tsMoveL";
            this.tsMoveL.Size = new System.Drawing.Size(23, 20);
            this.tsMoveL.Text = "MOve Item Left";
            // 
            // cbReportType
            // 
            this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Location = new System.Drawing.Point(500, 22);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(186, 24);
            this.cbReportType.TabIndex = 3;
            // 
            // lReportType
            // 
            this.lReportType.AutoSize = true;
            this.lReportType.Location = new System.Drawing.Point(388, 25);
            this.lReportType.Name = "lReportType";
            this.lReportType.Size = new System.Drawing.Size(106, 16);
            this.lReportType.TabIndex = 2;
            this.lReportType.Text = "2. Report Type : ";
            // 
            // cbSection
            // 
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(129, 51);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(252, 24);
            this.cbSection.TabIndex = 5;
            // 
            // lSection
            // 
            this.lSection.AutoSize = true;
            this.lSection.Location = new System.Drawing.Point(55, 51);
            this.lSection.Name = "lSection";
            this.lSection.Size = new System.Drawing.Size(72, 16);
            this.lSection.TabIndex = 4;
            this.lSection.Text = "3. Section :";
            // 
            // cbAccount
            // 
            this.cbAccount.BackColor = System.Drawing.Color.White;
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(129, 105);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(365, 24);
            this.cbAccount.TabIndex = 13;
            this.cbAccount.SelectedIndexChanged += new System.EventHandler(this.cbAccount_SelectedIndexChanged);
            // 
            // nLOD
            // 
            this.nLOD.Location = new System.Drawing.Point(130, 134);
            this.nLOD.Name = "nLOD";
            this.nLOD.Size = new System.Drawing.Size(120, 22);
            this.nLOD.TabIndex = 11;
            this.nLOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lAccount
            // 
            this.lAccount.AutoSize = true;
            this.lAccount.Location = new System.Drawing.Point(265, 136);
            this.lAccount.Name = "lAccount";
            this.lAccount.Size = new System.Drawing.Size(95, 16);
            this.lAccount.TabIndex = 12;
            this.lAccount.Text = "7.Note Level  : ";
            // 
            // tParentDesc
            // 
            this.tParentDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tParentDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tParentDesc.Location = new System.Drawing.Point(129, 108);
            this.tParentDesc.Name = "tParentDesc";
            this.tParentDesc.Size = new System.Drawing.Size(365, 22);
            this.tParentDesc.TabIndex = 9;
            // 
            // lPHeading
            // 
            this.lPHeading.AutoSize = true;
            this.lPHeading.Location = new System.Drawing.Point(15, 111);
            this.lPHeading.Name = "lPHeading";
            this.lPHeading.Size = new System.Drawing.Size(118, 16);
            this.lPHeading.TabIndex = 8;
            this.lPHeading.Text = "5.Parent Heading :";
            // 
            // lLOD
            // 
            this.lLOD.AutoSize = true;
            this.lLOD.Location = new System.Drawing.Point(10, 137);
            this.lLOD.Name = "lLOD";
            this.lLOD.Size = new System.Drawing.Size(123, 16);
            this.lLOD.TabIndex = 10;
            this.lLOD.Text = "6.Level of Display : ";
            // 
            // tHeading
            // 
            this.tHeading.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tHeading.Location = new System.Drawing.Point(129, 80);
            this.tHeading.Name = "tHeading";
            this.tHeading.Size = new System.Drawing.Size(365, 22);
            this.tHeading.TabIndex = 7;
            this.tHeading.Enter += new System.EventHandler(this.tHeading_Enter);
            // 
            // lHeading
            // 
            this.lHeading.AutoSize = true;
            this.lHeading.Location = new System.Drawing.Point(54, 82);
            this.lHeading.Name = "lHeading";
            this.lHeading.Size = new System.Drawing.Size(79, 16);
            this.lHeading.TabIndex = 6;
            this.lHeading.Text = "4.Heading : ";
            // 
            // cbReportName
            // 
            this.cbReportName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportName.FormattingEnabled = true;
            this.cbReportName.Location = new System.Drawing.Point(129, 22);
            this.cbReportName.Name = "cbReportName";
            this.cbReportName.Size = new System.Drawing.Size(252, 24);
            this.cbReportName.TabIndex = 1;
            this.cbReportName.SelectedIndexChanged += new System.EventHandler(this.cbReportName_SelectedIndexChanged);
            // 
            // lReport
            // 
            this.lReport.AutoSize = true;
            this.lReport.Location = new System.Drawing.Point(25, 25);
            this.lReport.Name = "lReport";
            this.lReport.Size = new System.Drawing.Size(111, 16);
            this.lReport.TabIndex = 0;
            this.lReport.Text = "1. Report Name : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 387);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ReportHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Report Heading";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbSetup);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail Accounts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.splitContainer1);
            this.gbSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSetup.Location = new System.Drawing.Point(3, 81);
            this.gbSetup.Margin = new System.Windows.Forms.Padding(4);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Padding = new System.Windows.Forms.Padding(4);
            this.gbSetup.Size = new System.Drawing.Size(837, 274);
            this.gbSetup.TabIndex = 4;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Setting Up";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 19);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvReportFormat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAcct);
            this.splitContainer1.Panel2.Controls.Add(this.lvSubAccts);
            this.splitContainer1.Size = new System.Drawing.Size(829, 251);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvReportFormat
            // 
            this.tvReportFormat.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tvReportFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReportFormat.Location = new System.Drawing.Point(0, 0);
            this.tvReportFormat.Margin = new System.Windows.Forms.Padding(4);
            this.tvReportFormat.Name = "tvReportFormat";
            this.tvReportFormat.Size = new System.Drawing.Size(418, 251);
            this.tvReportFormat.TabIndex = 0;
            this.tvReportFormat.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReportFormat_AfterSelect);
            // 
            // dgvAcct
            // 
            this.dgvAcct.AllowDrop = true;
            this.dgvAcct.AllowUserToAddRows = false;
            this.dgvAcct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAcct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAcct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcct.Location = new System.Drawing.Point(0, 0);
            this.dgvAcct.MultiSelect = false;
            this.dgvAcct.Name = "dgvAcct";
            this.dgvAcct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcct.Size = new System.Drawing.Size(406, 251);
            this.dgvAcct.StandardTab = true;
            this.dgvAcct.TabIndex = 1;
            this.dgvAcct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAcct_CellClick);
            // 
            // lvSubAccts
            // 
            this.lvSubAccts.BackColor = System.Drawing.Color.Wheat;
            this.lvSubAccts.CheckBoxes = true;
            this.lvSubAccts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AccountName,
            this.AccountDesc,
            this.check});
            this.lvSubAccts.Location = new System.Drawing.Point(484, 5);
            this.lvSubAccts.Name = "lvSubAccts";
            this.lvSubAccts.Size = new System.Drawing.Size(10, 10);
            this.lvSubAccts.TabIndex = 0;
            this.lvSubAccts.UseCompatibleStateImageBehavior = false;
            // 
            // AccountName
            // 
            this.AccountName.Text = "Account Name";
            // 
            // AccountDesc
            // 
            this.AccountDesc.Text = "Description";
            // 
            // check
            // 
            this.check.Text = "Select";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lmsg);
            this.groupBox1.Controls.Add(this.lHead);
            this.groupBox1.Controls.Add(this.lHeadAccount);
            this.groupBox1.Controls.Add(this.bMove);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lmsg
            // 
            this.lmsg.ForeColor = System.Drawing.Color.Red;
            this.lmsg.Location = new System.Drawing.Point(9, 7);
            this.lmsg.Name = "lmsg";
            this.lmsg.Size = new System.Drawing.Size(802, 32);
            this.lmsg.TabIndex = 3;
            this.lmsg.Text = "label1";
            this.lmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lHead
            // 
            this.lHead.AutoSize = true;
            this.lHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHead.Location = new System.Drawing.Point(6, 54);
            this.lHead.Name = "lHead";
            this.lHead.Size = new System.Drawing.Size(137, 16);
            this.lHead.TabIndex = 1;
            this.lHead.Text = "Accounts Hierachy";
            // 
            // lHeadAccount
            // 
            this.lHeadAccount.AutoSize = true;
            this.lHeadAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeadAccount.Location = new System.Drawing.Point(547, 50);
            this.lHeadAccount.Name = "lHeadAccount";
            this.lHeadAccount.Size = new System.Drawing.Size(185, 16);
            this.lHeadAccount.TabIndex = 2;
            this.lHeadAccount.Text = "Exisitng Header Accounts";
            // 
            // bMove
            // 
            this.bMove.Location = new System.Drawing.Point(363, 43);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(85, 27);
            this.bMove.TabIndex = 2;
            this.bMove.Text = "<<";
            this.bMove.UseVisualStyleBackColor = true;
            this.bMove.Click += new System.EventHandler(this.bMove_Click);
            // 
            // ReportConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 387);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportConfigurator";
            this.Text = "Report Configurator";
            this.Load += new System.EventHandler(this.ReportConfigurator_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ReportConfigurator_Paint);
            this.Resize += new System.EventHandler(this.ReportConfigurator_Resize);
            this.ReportHeader.ResumeLayout(false);
            this.ReportHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrintOrder)).EndInit();
            this.tsReport.ResumeLayout(false);
            this.tsReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLOD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbSetup.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ReportHeader;
        private System.Windows.Forms.TextBox tParentDesc;
        private System.Windows.Forms.Label lPHeading;
        private System.Windows.Forms.Label lLOD;
        private System.Windows.Forms.TextBox tHeading;
        private System.Windows.Forms.Label lHeading;
        private System.Windows.Forms.ComboBox cbReportName;
        private System.Windows.Forms.Label lReport;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.NumericUpDown nLOD;
        private System.Windows.Forms.Label lAccount;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Label lSection;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Label lReportType;
        private System.Windows.Forms.ToolStrip tsReport;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Button bAddDef;
        private System.Windows.Forms.ToolStripLabel tsMsg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsMoveR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsMoveL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ComboBox cbHeading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nPrintOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lHead;
        private System.Windows.Forms.Label lHeadAccount;
        private System.Windows.Forms.Button bMove;
        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvReportFormat;
        private System.Windows.Forms.DataGridView dgvAcct;
        private System.Windows.Forms.ListView lvSubAccts;
        private System.Windows.Forms.ColumnHeader AccountName;
        private System.Windows.Forms.ColumnHeader AccountDesc;
        private System.Windows.Forms.ColumnHeader check;
        private System.Windows.Forms.Label lmsg;
    }
}