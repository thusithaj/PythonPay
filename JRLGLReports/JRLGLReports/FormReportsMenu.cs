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
using System.IO;
using DataAccess;

namespace ReportsFormofGL
{
    public partial class formReports : Form
    {
        private List<GLReportsMenu> reportMenuList;
        private int lngIndex = 1;
        public formReports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SanitizeConnection();
            lngIndex = ConnectionInfo.Language;
            CreateUserMenu();
        }

        private void CreateUserMenu()
        {
            reportMenuList = new ReportMenuController().menuList.ToList();
            int preitm = 0;
            ToolStripMenuItem topmenu = new ToolStripMenuItem();
            foreach ( GLReportsMenu menu in reportMenuList)
            {
                
                if (menu.MenuLevel == 0 && preitm >= 0)
                {
                    
                    topmenu = new ToolStripMenuItem();
                    topmenu.Name = menu.DefaultMenuName;
                    if (menu.MenuLanguages.ToList().Count >= 1)
                        topmenu.Text = menu.MenuLanguages.ToList()[lngIndex].MenuName;
                    this.reportsMenu.Items.Add(topmenu);
                    preitm++;
                   
                }
                else
                {
                    ToolStripMenuItem itm = new ToolStripMenuItem();
                    itm.Name = menu.DefaultMenuName;
                    itm.Text = menu.MenuLanguages.ToList()[lngIndex].MenuName;
                    itm.Click += Itm_Click;
                    topmenu.DropDownItems.Add(itm);
                }
            }
            //throw new NotImplementedException();
        }

        private void Itm_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(sender.ToString());
            string objectName = sender.ToString();
            GLReportsMenu menu = reportMenuList.Where(o => o.MenuLanguages.ToList()[lngIndex].MenuName == objectName).FirstOrDefault();
            string formName = menu.SubMenu.Where( o=>o.menuId == menu.id).FirstOrDefault().formName;
            string dllname = menu.SubMenu.Where(o => o.menuId == menu.id).FirstOrDefault().nameofDLL;
            //Assembly asm = null;
            string apppath = @dllname;
            Assembly asm = Assembly.Load(apppath);
            Type[] typeList = asm.GetTypes();
            Type type = typeList.Where( o=> o.Name == formName).FirstOrDefault();
            //typeList = 
            //Form frm = (Form) Activator.CreateInstance(type);frm.Show();
            string[] cominfo = new string[] { ConnectionInfo.companyCode, ConnectionInfo.companyName };
            
            //MethodInfo mi = type.GetMethod(formName, new Type[] { typeof(string), typeof(string) });
            
            Assembly myAssembly = Assembly.Load(apppath);

            // Set The Constructor
            Type myType = myAssembly.GetType(formName);
            Type[] types = new Type[2];
            types[0] = typeof(string[]);
            types[1] = typeof(string[]);
            //ConstructorInfo constructorInfoObj = type.GetConstructor(
            //    BindingFlags.Instance | BindingFlags.Public, null,
            //    CallingConventions.HasThis, types, null);
            ConstructorInfo constructorInfoObj = type.GetConstructor(
                                BindingFlags.Instance | BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.OptionalParamBinding|BindingFlags.GetField,
                                null, CallingConventions.VarArgs|CallingConventions.Standard|CallingConventions.HasThis,types,null);
            ConstructorInfo[] cons = type.GetConstructors();

            constructorInfoObj = cons[1];
            object[] myParams = new object[] { ConnectionInfo.companyCode, ConnectionInfo.companyName };
            // this opens the form but dosn't set the label.txtා
            Form myForm = (Form)constructorInfoObj.Invoke(myParams);
            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();


        }

        private void SanitizeConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DBCS"].ToString();
            string LanguageKey = ConfigurationManager.AppSettings["Language"].ToString();
            if (LanguageKey == "")
                ConnectionInfo.Language = 0;
            else
                ConnectionInfo.Language = int.Parse(LanguageKey);
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

        private void hierachyOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfigurator rcf = new ReportConfigurator();
            rcf.MdiParent = this;
            rcf.WindowState = FormWindowState.Maximized;
            rcf.Show();
            
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void profitLossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeStatementForm isf = new IncomeStatementForm();
            isf.MdiParent = this;
            isf.WindowState = FormWindowState.Maximized;
            isf.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceSheetForm bsf = new BalanceSheetForm();
            bsf.MdiParent = this;
            bsf.WindowState = FormWindowState.Maximized;
            bsf.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
        }

        private void cashflowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashFlowStatementForm cfs = new CashFlowStatementForm();
            cfs.MdiParent = this;
            cfs.WindowState = FormWindowState.Maximized;
            cfs.Show();
        }

        private void createMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCreation mcf = new MenuCreation();
            mcf.MdiParent = this;
            mcf.WindowState = FormWindowState.Maximized;
            mcf.Show();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "JRLGLHelp.chm");
        }
    }
}
