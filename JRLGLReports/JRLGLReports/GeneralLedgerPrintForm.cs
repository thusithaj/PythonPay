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

namespace JRLGLReports
{
    public partial class GeneralLedgerPrintForm : Form
    {
        public string ReportName { get; set; }
        private const string ACCCODE = "@AccountCode";
        private const string ACCTYPE = "@AccountGroup";
        private const string COMPNAY = "@company";
        private const string FINYEAR = "@finfyear";
        private const string FINPEIORD = "@finperiod";
        private const string COMNAME = "CompanyName";
        private const string REPONAME = "ReportName";
        private const string ASATDATE = "AsAtDate";
        ReportDocument report;
        private string accountCode = "%";
        private string accountGroup;
        private string reportHeading;
        DataTable dtAS;
        DataTable dtAcc;
        DataTable dtRepo;
        public GeneralLedgerPrintForm()
        {
            InitializeComponent();
        }

        private void GeneralLedgerPrintForm_Load(object sender, EventArgs e)
        {
            LoadComboValues();
        }

        private void LoadComboValues()
        {
            ReportDataAccess ra = new ReportDataAccess();
            dtAS = ra.GetTable("[LED]", "[LED-TYPE]", "E");
            cbSeries.DataSource = dtAS;
            cbSeries.DisplayMember = "LED-NAME";
            cbSeries.ValueMember = "LED-CODE";

            string filter = "[ACC-LEDGER] <> ''";
            dtAcc = ra.GetTable("[ACC]");
            dtAcc = dtAcc.Select(filter).CopyToDataTable();
            dtAcc.Rows.Add(dtAcc.NewRow());
            dtAcc.Rows[dtAcc.Rows.Count-1]["ACC-ACCODE"] = "0";
            dtAcc.Rows[dtAcc.Rows.Count-1]["ACC-DESC"] = "(All)";
            cbAccounts.DataSource = dtAcc;
            cbAccounts.DisplayMember = "ACC-DESC";
            cbAccounts.ValueMember = "ACC-ACCODE";
            
            dtRepo = new DataTable();
            dtRepo.Columns.Add(new DataColumn("id", typeof(int)));
            dtRepo.Columns.Add(new DataColumn("ReportName", typeof(string)));
            dtRepo.Rows.Add(dtRepo.NewRow());
            dtRepo.Rows[0]["id"] = 0;
            dtRepo.Rows[0]["ReportName"] = "Cash Book";
            dtRepo.Rows.Add(dtRepo.NewRow());
            dtRepo.Rows[1]["id"] = 0;
            dtRepo.Rows[1]["ReportName"] = "General Ledger";
            cbReport.DataSource = dtRepo;
            cbReport.DisplayMember = "ReportName";
            cbReport.ValueMember = "ReportName"; ;
            //throw new NotImplementedException();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            report.FileName = Application.StartupPath + "\\" + ReportName;
            //report.D
            report.SetParameterValue(FINYEAR, dtPeriod.Value.Year);
            report.SetParameterValue(FINPEIORD, dtPeriod.Value.Month -2);
            report.SetParameterValue(ACCCODE, accountCode);
            report.SetParameterValue(ACCTYPE, accountGroup);
            report.SetParameterValue(COMPNAY, ConnectionInfo.companyCode);
            report.SetParameterValue("ReportName", reportHeading);
            report.SetParameterValue(COMNAME, ConnectionInfo.companyName);
            dtPeriod.Value = dtPeriod.Value.AddMonths(1).AddDays(dtPeriod.Value.Day * -1);
            report.SetParameterValue(ASATDATE, dtPeriod.Value);
            crglView.ParameterFieldInfo = new CrystalDecisions.Shared.ParameterFields();
            foreach (CrystalDecisions.Shared.ParameterField fld in report.ParameterFields)
            {

                crglView.ParameterFieldInfo.Add(fld);
                //fld.IsOptionalPrompt
            }
            report.SetDatabaseLogon(ConnectionInfo.userName, ConnectionInfo.password, ConnectionInfo.serverName, ConnectionInfo.database);
            //report.
            crglView.ReuseParameterValuesOnRefresh = true;


            //CrystalDecisions.
            //
            //crglView.ParameterFieldInfo.Count.ToString();
            crglView.ReportSource = ReportName;
            foreach (CrystalDecisions.Shared.TableLogOnInfo tbloginfo in crglView.LogOnInfo)
            {
                tbloginfo.ConnectionInfo.DatabaseName = ConnectionInfo.database;
                tbloginfo.ConnectionInfo.ServerName = ConnectionInfo.serverName;
                tbloginfo.ConnectionInfo.UserID = ConnectionInfo.userName;
                tbloginfo.ConnectionInfo.Password = ConnectionInfo.password;
            }
        }

        private void cbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountGroup = cbSeries.SelectedValue.ToString();
            accountGroup = accountGroup + "%";
        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportHeading = cbReport.SelectedValue.ToString();
        }
    }
}
