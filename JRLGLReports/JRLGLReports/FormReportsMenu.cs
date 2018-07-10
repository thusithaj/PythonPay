using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
using DataAccess;

namespace JRLGLReports
{
    public partial class formReports : Form
    {
       
        public formReports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SanitizeConnection();
        }

        private void SanitizeConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
            string[] values = constr.Split(';');
            ConnectionInfo.serverName = values[0].Substring(values[0].IndexOf('=') + 1, values[0].Length - ((values[0].IndexOf('=') + 1)));
            ConnectionInfo.database = values[1].Substring(values[1].IndexOf('=') + 1, values[1].Length - ((values[1].IndexOf('=') + 1)));
            ConnectionInfo.userName = values[2].Substring(values[2].IndexOf('=') + 1, values[2].Length - ((values[2].IndexOf('=') + 1)));
            ConnectionInfo.password = values[3].Substring(values[3].IndexOf('=') + 1, values[3].Length - ((values[3].IndexOf('=') + 1)));
            ReportDataAccess da = new ReportDataAccess();
            DataTable dt = da.GetTable("[PAR]");
            if (dt.Rows.Count == 1)
            {
                ConnectionInfo.companyName = dt.Rows[0][2].ToString();
                ConnectionInfo.companyCode = dt.Rows[0][1].ToString();
            }
            else
                ConnectionInfo.companyName = " No Company Setup Found";
            //throw new NotImplementedException();
        }

        private void toolStripMenuItemTB_Click(object sender, EventArgs e)
        {
            GLPrintForm glp = new GLPrintForm();
            glp.MdiParent = this;
            glp.ReportName = "TrialBalance.rpt";
            glp.WindowState = FormWindowState.Maximized;
            glp.Show();
        }

        private void ledgerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralLedgerPrintForm glpf = new GeneralLedgerPrintForm();
            glpf.ReportName = "LedgerReport.rpt";
            glpf.MdiParent = this;
            glpf.WindowState = FormWindowState.Maximized;
            glpf.Show();
        }
    }
}
