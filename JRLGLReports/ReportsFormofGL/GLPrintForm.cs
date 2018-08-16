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
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using DataAccess;

namespace ReportsFormofGL
{
    public partial class GLPrintForm : Form
    {
        public string ReportName {get;set;}
        private const string COMPNAY = "@Company";
        private const string FINYEAR = "@Finyear";
        private const string FINPEIORD = "@finperiod";
        private const string COMNAME = "CompanyName";
        private const string ASATDATE = "pAsAtDate";
        private const string ZEROFLAG = "@zeroFlag";
        private string zero; 
        ReportDocument report;
        private string[] strParams;
        public string CompanyCode { get; set; }
        public string ComName { get; set; }
        public GLPrintForm()
        {
            InitializeComponent();
        }

        public   GLPrintForm( string  companycode, string comname)
        {
            InitializeComponent();
            //int i = 0;

            //foreach(string val in args)
            //{
            //    strParams[i] = val;
            //}
            CompanyCode = companycode;
            ComName = comname;

            //GLPrintForm();
        }
        private void GLPrintForm_Load(object sender, EventArgs e)
        {

            LoadReports();
        }

        private void LoadReports()
        {
            DataTable dtrpt = new DataTable();
            dtrpt.Columns.Add(new DataColumn("ReportName", typeof(string)));
            dtrpt.Columns.Add(new DataColumn("ReportFile", typeof(string)));
            dtrpt.Rows.Add(dtrpt.NewRow());
            dtrpt.Rows[0][0] = "Trial Balance Summary";
            dtrpt.Rows[0][1] = "TrialBalance.rpt";
            dtrpt.Rows.Add(dtrpt.NewRow());
            dtrpt.Rows[1][0] = "Trial Balance Details";
            dtrpt.Rows[1][1] = "TrialBalanceDetails.rpt";
            cbReport.DataSource = dtrpt;
            cbReport.DisplayMember = "ReportName";
            cbReport.ValueMember = "ReportFile";
            //throw new NotImplementedException();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            SelectReport();
            report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            report.FileName = Application.StartupPath + "\\" + ReportName;
            //report.D
            report.SetParameterValue(FINYEAR, dtPeriod.Value.Year);
            report.SetParameterValue(FINPEIORD, dtPeriod.Value.Month -2);
            
            report.SetParameterValue(COMPNAY, CompanyCode);
            report.SetParameterValue(COMNAME, ComName);
            dtPeriod.Value = dtPeriod.Value.AddMonths(1).AddDays(dtPeriod.Value.Day *-1);
            report.SetParameterValue(ASATDATE, dtPeriod.Value);
            report.SetParameterValue(ZEROFLAG, zero);

            crglView.ParameterFieldInfo = new CrystalDecisions.Shared.ParameterFields();
            foreach ( CrystalDecisions.Shared.ParameterField fld in report.ParameterFields)
            {
                
                crglView.ParameterFieldInfo.Add(fld);

            }
            SqlCommand cmd = new SqlCommand();
            string sql = "LedgerDisplay @finyear, @finperiod, @Company, @zeroFlag";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@finyear", SqlDbType.Int)).Value = dtPeriod.Value.Year;

            cmd.Parameters.Add(new SqlParameter("@finperiod", SqlDbType.Int)).Value = dtPeriod.Value.Month - 2;
            cmd.Parameters.Add(new SqlParameter("@Company", SqlDbType.NVarChar)).Value = ComName;
            cmd.Parameters.Add(new SqlParameter("@zeroFlag", SqlDbType.NVarChar)).Value = zero;
            DataTable dt = new DataTable();
            Acc_Report_CRUD acr = new Acc_Report_CRUD();
            dt = acr.GetReportData(cmd);
            report.SetDataSource(dt);
            

            crglView.ReportSource = report;
            
        }

        
        private void SelectReport()
        {
            if (chkZero.Checked)
                zero = "N";
            else
                zero = "Y";
            ReportName = cbReport.SelectedValue.ToString();
            //throw new NotImplementedException();
        }
    }
}
