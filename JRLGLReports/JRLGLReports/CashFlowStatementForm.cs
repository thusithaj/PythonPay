using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using DataAccess;
using System.Data.SqlClient;

namespace ReportsFormofGL
{
    public partial class CashFlowStatementForm : Form
    {
        public string ReportName { get; set; }
        private ReportDocument report;
        public CashFlowStatementForm()
        {
            InitializeComponent();
        }

        private void CashFlowStatementForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }
        private void LoadReports()
        {
            DataTable dtrpt = new DataTable();
            dtrpt.Columns.Add(new DataColumn("ReportName", typeof(string)));
            dtrpt.Columns.Add(new DataColumn("ReportFile", typeof(string)));
            dtrpt.Rows.Add(dtrpt.NewRow());
            dtrpt.Rows[0][0] = "General Cashflow Statement";
            dtrpt.Rows[0][1] = "CashFlow.rpt";
            cbReport.DataSource = dtrpt;
            cbReport.DisplayMember = "ReportName";
            cbReport.ValueMember = "ReportFile";
            //throw new NotImplementedException();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            SetRportParameters();
            crglView.ParameterFieldInfo = new CrystalDecisions.Shared.ParameterFields();
            foreach (CrystalDecisions.Shared.ParameterField fld in report.ParameterFields)
            {

                crglView.ParameterFieldInfo.Add(fld);
                //fld.IsOptionalPrompt
            }
            SqlCommand cmd = new SqlCommand();
            string sql = "CashFlowStatement @finyear, @finperiod, @Company";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@finyear", SqlDbType.Int)).Value = dtPeriod.Value.Year;

            cmd.Parameters.Add(new SqlParameter("@finperiod", SqlDbType.Int)).Value = dtPeriod.Value.Month;
            cmd.Parameters.Add(new SqlParameter("@Company", SqlDbType.NVarChar)).Value = ConnectionInfo.companyCode;
            
            DataTable dt = new DataTable();
            Acc_Report_CRUD acr = new Acc_Report_CRUD();
            dt = acr.GetReportData(cmd);
            report.SetDataSource(dt);


            crglView.ReportSource = report;
        }

        private void SetRportParameters()
        {
            switch (ReportName)    
            {
                case "CashFlow.rpt":
                    report = new ReportDocument();
                    report.FileName  = Application.StartupPath + "\\" + ReportName;
                    report.SetParameterValue("@finfyear", dtPeriod.Value.Year);
                    report.SetParameterValue("@finperiod", dtPeriod.Value.Month);
                    report.SetParameterValue("@Company", ConnectionInfo.companyCode);
                    report.SetParameterValue("CompanyName", ConnectionInfo.companyName);
                    report.SetParameterValue("SelectedDate", dtPeriod.Value);
                    break;
            }
        //throw new NotImplementedException();
        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
         if (cbReport.SelectedItem != null)
         {
                DataRowView dv = (DataRowView)cbReport.SelectedItem;
                ReportName = dv[1].ToString();
         }
        }
    }
}
