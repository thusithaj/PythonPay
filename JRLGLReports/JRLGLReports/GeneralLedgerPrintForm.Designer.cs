namespace JRLGLReports
{
    partial class GeneralLedgerPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralLedgerPrintForm));
            this.crglView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.lReport = new System.Windows.Forms.Label();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.lAccounts = new System.Windows.Forms.Label();
            this.cbSeries = new System.Windows.Forms.ComboBox();
            this.laseries = new System.Windows.Forms.Label();
            this.bPrint = new System.Windows.Forms.Button();
            this.lperiod = new System.Windows.Forms.Label();
            this.dtPeriod = new System.Windows.Forms.DateTimePicker();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // crglView
            // 
            this.crglView.ActiveViewIndex = -1;
            this.crglView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crglView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crglView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crglView.Location = new System.Drawing.Point(0, 101);
            this.crglView.Name = "crglView";
            this.crglView.Size = new System.Drawing.Size(924, 318);
            this.crglView.TabIndex = 3;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.cbReport);
            this.gbFilters.Controls.Add(this.lReport);
            this.gbFilters.Controls.Add(this.cbAccounts);
            this.gbFilters.Controls.Add(this.lAccounts);
            this.gbFilters.Controls.Add(this.cbSeries);
            this.gbFilters.Controls.Add(this.laseries);
            this.gbFilters.Controls.Add(this.bPrint);
            this.gbFilters.Controls.Add(this.lperiod);
            this.gbFilters.Controls.Add(this.dtPeriod);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilters.Location = new System.Drawing.Point(0, 0);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilters.Size = new System.Drawing.Size(924, 101);
            this.gbFilters.TabIndex = 2;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // cbReport
            // 
            this.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(74, 57);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(127, 21);
            this.cbReport.TabIndex = 8;
            this.cbReport.SelectedIndexChanged += new System.EventHandler(this.cbReport_SelectedIndexChanged);
            // 
            // lReport
            // 
            this.lReport.AutoSize = true;
            this.lReport.Location = new System.Drawing.Point(22, 60);
            this.lReport.Name = "lReport";
            this.lReport.Size = new System.Drawing.Size(45, 13);
            this.lReport.TabIndex = 7;
            this.lReport.Text = "Report :";
            // 
            // cbAccounts
            // 
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(569, 26);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(215, 21);
            this.cbAccounts.TabIndex = 6;
            this.cbAccounts.SelectedIndexChanged += new System.EventHandler(this.cbAccounts_SelectedIndexChanged);
            // 
            // lAccounts
            // 
            this.lAccounts.AutoSize = true;
            this.lAccounts.Location = new System.Drawing.Point(505, 29);
            this.lAccounts.Name = "lAccounts";
            this.lAccounts.Size = new System.Drawing.Size(58, 13);
            this.lAccounts.TabIndex = 5;
            this.lAccounts.Text = "Accounts :";
            // 
            // cbSeries
            // 
            this.cbSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeries.FormattingEnabled = true;
            this.cbSeries.Location = new System.Drawing.Point(325, 24);
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Size = new System.Drawing.Size(160, 21);
            this.cbSeries.TabIndex = 4;
            this.cbSeries.SelectedIndexChanged += new System.EventHandler(this.cbSeries_SelectedIndexChanged);
            // 
            // laseries
            // 
            this.laseries.AutoSize = true;
            this.laseries.Location = new System.Drawing.Point(219, 29);
            this.laseries.Name = "laseries";
            this.laseries.Size = new System.Drawing.Size(90, 13);
            this.laseries.TabIndex = 3;
            this.laseries.Text = "Accounts Series :";
            // 
            // bPrint
            // 
            this.bPrint.Image = ((System.Drawing.Image)(resources.GetObject("bPrint.Image")));
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(569, 55);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 23);
            this.bPrint.TabIndex = 2;
            this.bPrint.Text = "&Print";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // lperiod
            // 
            this.lperiod.AutoSize = true;
            this.lperiod.Location = new System.Drawing.Point(7, 29);
            this.lperiod.Name = "lperiod";
            this.lperiod.Size = new System.Drawing.Size(60, 13);
            this.lperiod.TabIndex = 1;
            this.lperiod.Text = "GL Period :";
            // 
            // dtPeriod
            // 
            this.dtPeriod.AllowDrop = true;
            this.dtPeriod.CustomFormat = "MMM/yyyy";
            this.dtPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPeriod.Location = new System.Drawing.Point(73, 25);
            this.dtPeriod.Name = "dtPeriod";
            this.dtPeriod.Size = new System.Drawing.Size(128, 20);
            this.dtPeriod.TabIndex = 0;
            // 
            // GeneralLedgerPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 419);
            this.Controls.Add(this.crglView);
            this.Controls.Add(this.gbFilters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralLedgerPrintForm";
            this.Text = "General LedgerPrint Form";
            this.Load += new System.EventHandler(this.GeneralLedgerPrintForm_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crglView;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Label lperiod;
        private System.Windows.Forms.DateTimePicker dtPeriod;
        private System.Windows.Forms.ComboBox cbSeries;
        private System.Windows.Forms.Label laseries;
        private System.Windows.Forms.Label lAccounts;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Label lReport;
        private System.Windows.Forms.ComboBox cbReport;
    }
}