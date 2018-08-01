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

namespace JRLGLReports
{
    public partial class GeneralLedgerPrintForm : Form
    {
        public string ReportName { get; set; }
        public string SPName { get; set; }
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
            dtAS.Rows.Add(dtAS.NewRow());
            dtAS.Rows[dtAS.Rows.Count - 1]["LED-CODE"] = "All";
            dtAS.Rows[dtAS.Rows.Count - 1]["LED-NAME"] = "All Types";
            dtAS.DefaultView.Sort = "LED-CODE";
            dtAS = dtAS.DefaultView.ToTable();
            cbSeries.DataSource = dtAS;
            cbSeries.DisplayMember = "LED-NAME";
            cbSeries.ValueMember = "LED-CODE";
            cbSeries.SelectedIndex = 0;

            string filter = "[ACC-LEDGER] <> ''";
            dtAcc = ra.GetTable("[ACC]");
            dtAcc = dtAcc.Select(filter).CopyToDataTable();
            dtAcc.Rows.Add(dtAcc.NewRow());
            dtAcc.Rows[dtAcc.Rows.Count-1]["ACC-ACCODE"] = "0";
            dtAcc.Rows[dtAcc.Rows.Count-1]["ACC-DESC"] = "(All)";
            dtAcc.DefaultView.Sort = "ACC-ACCODE";
            dtAcc = dtAcc.DefaultView.ToTable();
            cbAccounts.DataSource = dtAcc;
            cbAccounts.DisplayMember = "ACC-DESC";
            cbAccounts.ValueMember = "ACC-ACCODE";
            cbAccounts.SelectedIndex = 0;
            dtRepo = new DataTable();
            dtRepo.Columns.Add(new DataColumn("id", typeof(int)));
            dtRepo.Columns.Add(new DataColumn("ReportName", typeof(string)));
            dtRepo.Columns.Add(new DataColumn("ReportFileName", typeof(string)));
            dtRepo.Columns.Add(new DataColumn("ReportSPName", typeof(string)));
            dtRepo.Rows.Add(dtRepo.NewRow());
            dtRepo.Rows[0]["id"] = 0;
            dtRepo.Rows[0]["ReportName"] = "Cash Book";
            dtRepo.Rows[0]["ReportFileName"] = "CashBookReport.rpt";
            dtRepo.Rows[0]["ReportSPName"] = "AccountLedgerbyAccount";
            dtRepo.Rows.Add(dtRepo.NewRow());
            dtRepo.Rows[1]["id"] = 0;
            dtRepo.Rows[1]["ReportName"] = "General Ledger";
            dtRepo.Rows[1]["ReportFileName"] = "LedgerReport.rpt";
            dtRepo.Rows[1]["ReportSPName"] = "AccountLedgerbyPrint";
            cbReport.DataSource = dtRepo;
            cbReport.DisplayMember = "ReportName";
            cbReport.ValueMember = "ReportName"; 
            cbReport.SelectedIndex = -1;
            //throw new NotImplementedException();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            if (ValidateSelection())
            {
                report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                report.FileName = Application.StartupPath + "\\" + ReportName;
                //report.D
                report.SetParameterValue(FINYEAR, dtPeriod.Value.Year);
                report.SetParameterValue(FINPEIORD, dtPeriod.Value.Month - 2);
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

                SqlCommand cmd = new SqlCommand();
                string sql = SPName +" @AccountCode, @AccountGroup,@finyear,@finperiod, @Company";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@AccountCode", SqlDbType.NVarChar)).Value = accountCode;
                cmd.Parameters.Add(new SqlParameter("@AccountGroup", SqlDbType.NVarChar)).Value = accountGroup;
                cmd.Parameters.Add(new SqlParameter("@finyear", SqlDbType.Int)).Value = dtPeriod.Value.Year;

                cmd.Parameters.Add(new SqlParameter("@finperiod", SqlDbType.Int)).Value = dtPeriod.Value.Month - 2;
                cmd.Parameters.Add(new SqlParameter("@Company", SqlDbType.NVarChar)).Value = ConnectionInfo.companyCode;

                DataTable dt = new DataTable();
                Acc_Report_CRUD acr = new Acc_Report_CRUD();
                dt = acr.GetReportData(cmd);
                report.SetDataSource(dt);
                //CrystalDecisions.
                //
                //crglView.ParameterFieldInfo.Count.ToString();
                crglView.ReportSource = report;
                foreach (CrystalDecisions.Shared.TableLogOnInfo tbloginfo in crglView.LogOnInfo)
                {
                    tbloginfo.ConnectionInfo.DatabaseName = ConnectionInfo.database;
                    tbloginfo.ConnectionInfo.ServerName = ConnectionInfo.serverName;
                    tbloginfo.ConnectionInfo.UserID = ConnectionInfo.userName;
                    tbloginfo.ConnectionInfo.Password = ConnectionInfo.password;
                }
            }
            else
            {
                MessageBox.Show("Selection not permitted");
            }
        }

        private bool ValidateSelection()
        {
            bool retVal = false;
            if (accountGroup.Contains("CB") && ReportName.Contains("CashBook"))
                retVal = true;
            else if (accountGroup.Contains("GL") || accountGroup.Contains("%"))
            {
                accountCode = "%";
                retVal = true;
            }
            return retVal;
            //throw new NotImplementedException();
        }

        private void cbSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dv = (DataRowView)cbSeries.SelectedItem;
            if (dv == null)
                cbSeries.SelectedIndex = 0;

            accountGroup = dv[1].ToString();
            if (dtAcc != null)
            {
                string filter = "[ACC-LEDGER]='" + accountGroup + "'";
                if (accountGroup != "All")
                {
                    DataTable filterAcc = dtAcc.Select(filter).CopyToDataTable();
                    filterAcc.Rows.Add(filterAcc.NewRow());
                    filterAcc.Rows[filterAcc.Rows.Count - 1]["ACC-ACCODE"] = "0";
                    filterAcc.Rows[filterAcc.Rows.Count - 1]["ACC-DESC"] = "(All)";
                    filterAcc.DefaultView.Sort = "ACC-ACCODE";
                    filterAcc = filterAcc.DefaultView.ToTable();
                    cbAccounts.DataSource = null;
                    cbAccounts.Refresh();
                    cbAccounts.DataSource = filterAcc;
                    cbAccounts.DisplayMember = "ACC-DESC";
                    cbAccounts.ValueMember = "ACC-ACCODE";
                    accountGroup = accountGroup + "%";
                }
                else
                    accountGroup =  "%";
            }
            

        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReport.SelectedItem != null)
            {
                DataRowView dv = (DataRowView)cbReport.SelectedItem;
                reportHeading = dv[1].ToString();
                ReportName = dv[2].ToString();
                SPName = dv[3].ToString();
            }
        }

        private void cbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccounts.SelectedItem != null)
            {
                DataRowView dv = (DataRowView) cbAccounts.SelectedItem;
                accountCode = dv["ACC-ACCODE"].ToString();
                if (accountCode == "0")
                    accountCode = "%";
                else
                    accountCode = accountCode + "%";
            }
        }
    }
}
