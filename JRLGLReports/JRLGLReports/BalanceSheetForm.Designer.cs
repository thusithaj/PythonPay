﻿namespace ReportsFormofGL
{
    partial class BalanceSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceSheetForm));
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lCPeriod = new System.Windows.Forms.Label();
            this.dtPrePeriod = new System.Windows.Forms.DateTimePicker();
            this.cbComparison = new System.Windows.Forms.CheckBox();
            this.chkZero = new System.Windows.Forms.CheckBox();
            this.lreport = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.lperiod = new System.Windows.Forms.Label();
            this.dtPeriod = new System.Windows.Forms.DateTimePicker();
            this.crglView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.lCPeriod);
            this.gbFilters.Controls.Add(this.dtPrePeriod);
            this.gbFilters.Controls.Add(this.cbComparison);
            this.gbFilters.Controls.Add(this.chkZero);
            this.gbFilters.Controls.Add(this.lreport);
            this.gbFilters.Controls.Add(this.cbReport);
            this.gbFilters.Controls.Add(this.bPrint);
            this.gbFilters.Controls.Add(this.lperiod);
            this.gbFilters.Controls.Add(this.dtPeriod);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilters.Location = new System.Drawing.Point(0, 0);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilters.Size = new System.Drawing.Size(852, 108);
            this.gbFilters.TabIndex = 0;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // lCPeriod
            // 
            this.lCPeriod.AutoSize = true;
            this.lCPeriod.Location = new System.Drawing.Point(484, 16);
            this.lCPeriod.Name = "lCPeriod";
            this.lCPeriod.Size = new System.Drawing.Size(110, 16);
            this.lCPeriod.TabIndex = 8;
            this.lCPeriod.Text = "Previous Period :";
            // 
            // dtPrePeriod
            // 
            this.dtPrePeriod.AllowDrop = true;
            this.dtPrePeriod.CustomFormat = "MMM/yyyy";
            this.dtPrePeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPrePeriod.Location = new System.Drawing.Point(600, 16);
            this.dtPrePeriod.Name = "dtPrePeriod";
            this.dtPrePeriod.Size = new System.Drawing.Size(110, 22);
            this.dtPrePeriod.TabIndex = 7;
            // 
            // cbComparison
            // 
            this.cbComparison.AutoSize = true;
            this.cbComparison.Location = new System.Drawing.Point(349, 16);
            this.cbComparison.Name = "cbComparison";
            this.cbComparison.Size = new System.Drawing.Size(129, 20);
            this.cbComparison.TabIndex = 6;
            this.cbComparison.Text = "With Comparison";
            this.cbComparison.UseVisualStyleBackColor = true;
            this.cbComparison.CheckedChanged += new System.EventHandler(this.cbComparison_CheckedChanged);
            // 
            // chkZero
            // 
            this.chkZero.AutoSize = true;
            this.chkZero.Location = new System.Drawing.Point(218, 16);
            this.chkZero.Name = "chkZero";
            this.chkZero.Size = new System.Drawing.Size(102, 20);
            this.chkZero.TabIndex = 5;
            this.chkZero.Text = "WIthout Zero";
            this.chkZero.UseVisualStyleBackColor = true;
            // 
            // lreport
            // 
            this.lreport.AutoSize = true;
            this.lreport.Location = new System.Drawing.Point(33, 45);
            this.lreport.Name = "lreport";
            this.lreport.Size = new System.Drawing.Size(49, 16);
            this.lreport.TabIndex = 2;
            this.lreport.Text = "Report";
            // 
            // cbReport
            // 
            this.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Location = new System.Drawing.Point(88, 42);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(286, 24);
            this.cbReport.TabIndex = 3;
            // 
            // bPrint
            // 
            this.bPrint.Image = ((System.Drawing.Image)(resources.GetObject("bPrint.Image")));
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(380, 42);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 23);
            this.bPrint.TabIndex = 4;
            this.bPrint.Text = "&Print";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // lperiod
            // 
            this.lperiod.AutoSize = true;
            this.lperiod.Location = new System.Drawing.Point(10, 16);
            this.lperiod.Name = "lperiod";
            this.lperiod.Size = new System.Drawing.Size(74, 16);
            this.lperiod.TabIndex = 0;
            this.lperiod.Text = "GL Period :";
            // 
            // dtPeriod
            // 
            this.dtPeriod.AllowDrop = true;
            this.dtPeriod.CustomFormat = "MMM/yyyy";
            this.dtPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPeriod.Location = new System.Drawing.Point(90, 16);
            this.dtPeriod.Name = "dtPeriod";
            this.dtPeriod.Size = new System.Drawing.Size(110, 22);
            this.dtPeriod.TabIndex = 1;
            this.dtPeriod.ValueChanged += new System.EventHandler(this.dtPeriod_ValueChanged);
            // 
            // crglView
            // 
            this.crglView.ActiveViewIndex = -1;
            this.crglView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crglView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crglView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crglView.Location = new System.Drawing.Point(0, 108);
            this.crglView.Name = "crglView";
            this.crglView.Size = new System.Drawing.Size(852, 355);
            this.crglView.TabIndex = 1;
            // 
            // BalanceSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 463);
            this.Controls.Add(this.crglView);
            this.Controls.Add(this.gbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BalanceSheetForm";
            this.Text = "Print GL Legal Reports";
            this.Load += new System.EventHandler(this.GLPrintForm_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Label lperiod;
        private System.Windows.Forms.DateTimePicker dtPeriod;
        private System.Windows.Forms.Button bPrint;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crglView;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.Label lreport;
        private System.Windows.Forms.CheckBox chkZero;
        private System.Windows.Forms.CheckBox cbComparison;
        private System.Windows.Forms.Label lCPeriod;
        private System.Windows.Forms.DateTimePicker dtPrePeriod;
    }
}