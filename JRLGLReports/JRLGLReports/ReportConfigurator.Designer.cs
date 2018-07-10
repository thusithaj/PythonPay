namespace JRLGLReports
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
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvReportsHeadings = new System.Windows.Forms.TreeView();
            this.lReport = new System.Windows.Forms.Label();
            this.cbReportName = new System.Windows.Forms.ComboBox();
            this.lHeading = new System.Windows.Forms.Label();
            this.tHeading = new System.Windows.Forms.TextBox();
            this.lLOD = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lPHeading = new System.Windows.Forms.Label();
            this.lAccount = new System.Windows.Forms.Label();
            this.nLOD = new System.Windows.Forms.NumericUpDown();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.ReportHeader.SuspendLayout();
            this.gbSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLOD)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.Add(this.cbAccount);
            this.ReportHeader.Controls.Add(this.nLOD);
            this.ReportHeader.Controls.Add(this.lAccount);
            this.ReportHeader.Controls.Add(this.textBox1);
            this.ReportHeader.Controls.Add(this.lPHeading);
            this.ReportHeader.Controls.Add(this.lLOD);
            this.ReportHeader.Controls.Add(this.tHeading);
            this.ReportHeader.Controls.Add(this.lHeading);
            this.ReportHeader.Controls.Add(this.cbReportName);
            this.ReportHeader.Controls.Add(this.lReport);
            this.ReportHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportHeader.Location = new System.Drawing.Point(0, 0);
            this.ReportHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReportHeader.Size = new System.Drawing.Size(901, 204);
            this.ReportHeader.TabIndex = 0;
            this.ReportHeader.TabStop = false;
            this.ReportHeader.Text = "Header ";
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.splitContainer1);
            this.gbSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSetup.Location = new System.Drawing.Point(0, 204);
            this.gbSetup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSetup.Size = new System.Drawing.Size(901, 313);
            this.gbSetup.TabIndex = 1;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Setting Up";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 19);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvReportsHeadings);
            this.splitContainer1.Size = new System.Drawing.Size(893, 290);
            this.splitContainer1.SplitterDistance = 435;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvReportsHeadings
            // 
            this.tvReportsHeadings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReportsHeadings.Location = new System.Drawing.Point(0, 0);
            this.tvReportsHeadings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvReportsHeadings.Name = "tvReportsHeadings";
            this.tvReportsHeadings.Size = new System.Drawing.Size(435, 290);
            this.tvReportsHeadings.TabIndex = 0;
            // 
            // lReport
            // 
            this.lReport.AutoSize = true;
            this.lReport.Location = new System.Drawing.Point(25, 25);
            this.lReport.Name = "lReport";
            this.lReport.Size = new System.Drawing.Size(98, 16);
            this.lReport.TabIndex = 0;
            this.lReport.Text = "Report Name : ";
            // 
            // cbReportName
            // 
            this.cbReportName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportName.FormattingEnabled = true;
            this.cbReportName.Location = new System.Drawing.Point(129, 22);
            this.cbReportName.Name = "cbReportName";
            this.cbReportName.Size = new System.Drawing.Size(374, 24);
            this.cbReportName.TabIndex = 1;
            // 
            // lHeading
            // 
            this.lHeading.AutoSize = true;
            this.lHeading.Location = new System.Drawing.Point(54, 56);
            this.lHeading.Name = "lHeading";
            this.lHeading.Size = new System.Drawing.Size(69, 16);
            this.lHeading.TabIndex = 2;
            this.lHeading.Text = "Heading : ";
            // 
            // tHeading
            // 
            this.tHeading.Location = new System.Drawing.Point(129, 54);
            this.tHeading.Name = "tHeading";
            this.tHeading.Size = new System.Drawing.Size(678, 22);
            this.tHeading.TabIndex = 3;
            // 
            // lLOD
            // 
            this.lLOD.AutoSize = true;
            this.lLOD.Location = new System.Drawing.Point(10, 114);
            this.lLOD.Name = "lLOD";
            this.lLOD.Size = new System.Drawing.Size(113, 16);
            this.lLOD.TabIndex = 4;
            this.lLOD.Text = "Level of Display : ";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(129, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(678, 22);
            this.textBox1.TabIndex = 6;
            // 
            // lPHeading
            // 
            this.lPHeading.AutoSize = true;
            this.lPHeading.Location = new System.Drawing.Point(15, 85);
            this.lPHeading.Name = "lPHeading";
            this.lPHeading.Size = new System.Drawing.Size(108, 16);
            this.lPHeading.TabIndex = 5;
            this.lPHeading.Text = "Parent Heading :";
            // 
            // lAccount
            // 
            this.lAccount.AutoSize = true;
            this.lAccount.Location = new System.Drawing.Point(55, 140);
            this.lAccount.Name = "lAccount";
            this.lAccount.Size = new System.Drawing.Size(68, 16);
            this.lAccount.TabIndex = 7;
            this.lAccount.Text = "Account  : ";
            // 
            // nLOD
            // 
            this.nLOD.Location = new System.Drawing.Point(130, 108);
            this.nLOD.Name = "nLOD";
            this.nLOD.Size = new System.Drawing.Size(120, 22);
            this.nLOD.TabIndex = 8;
            this.nLOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbAccount
            // 
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(130, 137);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(352, 24);
            this.cbAccount.TabIndex = 9;
            // 
            // ReportConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 517);
            this.Controls.Add(this.gbSetup);
            this.Controls.Add(this.ReportHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportConfigurator";
            this.Text = "Report Configurator";
            this.ReportHeader.ResumeLayout(false);
            this.ReportHeader.PerformLayout();
            this.gbSetup.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nLOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ReportHeader;
        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvReportsHeadings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lPHeading;
        private System.Windows.Forms.Label lLOD;
        private System.Windows.Forms.TextBox tHeading;
        private System.Windows.Forms.Label lHeading;
        private System.Windows.Forms.ComboBox cbReportName;
        private System.Windows.Forms.Label lReport;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.NumericUpDown nLOD;
        private System.Windows.Forms.Label lAccount;
    }
}