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
namespace JRLGLReports
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
        public GLPrintForm()
        {
            InitializeComponent();
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
            
            report.SetParameterValue(COMPNAY, ConnectionInfo.companyCode);
            report.SetParameterValue(COMNAME, ConnectionInfo.companyName);
            dtPeriod.Value = dtPeriod.Value.AddMonths(1).AddDays(dtPeriod.Value.Day *-1);
            report.SetParameterValue(ASATDATE, dtPeriod.Value);
            report.SetParameterValue(ZEROFLAG, zero);

            crglView.ParameterFieldInfo = new CrystalDecisions.Shared.ParameterFields();
            foreach ( CrystalDecisions.Shared.ParameterField fld in report.ParameterFields)
            {
                
                crglView.ParameterFieldInfo.Add(fld);
                //fld.IsOptionalPrompt
            }
            report.SetDatabaseLogon(ConnectionInfo.userName, ConnectionInfo.password, ConnectionInfo.serverName, ConnectionInfo.database);
            //report.
            crglView.ReuseParameterValuesOnRefresh = true;
            
            crglView.ReportSource = ReportName;
            foreach (CrystalDecisions.Shared.TableLogOnInfo tbloginfo in crglView.LogOnInfo)
            {
                tbloginfo.ConnectionInfo.DatabaseName = ConnectionInfo.database;
                tbloginfo.ConnectionInfo.ServerName = ConnectionInfo.serverName;
                tbloginfo.ConnectionInfo.UserID = ConnectionInfo.userName;
                tbloginfo.ConnectionInfo.Password = ConnectionInfo.password;
            }


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
