using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess;
namespace JRLGLReports
{
    public partial class ReportConfigurator : Form
    {
        DataAccess.ReportDataAccess db;
        DataTable reportDt;
        DataTable accDt;
        DataTable secDt;
        DataTable balDt;
        DataTable iexDt;
        DataTable typDt;
        DataTable dtSubAcct;
        DataTable prntDt;
        Acc_Report accReport;
        List<Acc_Report> HeaderList;
        ReportFormat rptFormat;
        ReportFormatDetail rptFmtDetail;
        Acc_Report_CRUD accOpt;
        DataSet accountDataset;
        DataTable masterDt;
        DataTable detailDt;
        TreeNode selectedNode;
        //Windows.F DataGridRowView selecteddv;
        //AutoCompleteStringCollection parentSource;
        bool isEdit = false;

        public DataGridViewRow selecteddv { get; private set; }

        //bool chngdReportName = false;
        public ReportConfigurator()
        {
            InitializeComponent();
        }

        private void ReportConfigurator_Load(object sender, EventArgs e)
        {
            LoadGLReport();
            AddHeadtoList();
            LoadAccounts();
            LoadReportType();
            EnableControls(false);
        }

        private void EnableControls(bool v)
        {
            cbReportName.Enabled = v;
            cbAccount.Enabled = v;
            cbReportType.Enabled = v;
            cbSection.Enabled = v;
            tHeading.Enabled = v;
            tParentDesc.Enabled = v;
            nLOD.Enabled = v;
            bAddDef.Enabled = v;
            cbHeading.Enabled = v;
            //+ throw new NotImplementedException();
        }

        private void LoadReportType()
        {
            typDt = new DataTable();
            typDt.Columns.Add(new DataColumn("id", typeof(int)));
            typDt.Columns.Add(new DataColumn("ReportType", typeof(string)));
            typDt.Rows.Add(typDt.NewRow());
            typDt.Rows[0][0] = 0;
            typDt.Rows[0][1] = "Standard";
            typDt.Rows.Add(typDt.NewRow());
            typDt.Rows[1][0] = 0;
            typDt.Rows[1][1] = "Customized";
            cbReportType.DataSource = typDt;
            cbReportType.DisplayMember = "ReportType";
            cbReportType.ValueMember = "id";
            //throw new NotImplementedException();
        }

        private void LoadSections()
        {
            secDt = new DataTable();
            secDt.Columns.Add(new DataColumn("id", typeof(int)));
            secDt.Columns.Add(new DataColumn("SecName", typeof(string)));
            secDt.Columns.Add(new DataColumn("SecOrder", typeof(int)));
            secDt.Rows.Add(secDt.NewRow());
            secDt.Rows[0][0] = 0;
            secDt.Rows[0][1] = "Assets";
            secDt.Rows[0][2] = 0;
            secDt.Rows.Add(secDt.NewRow());
            secDt.Rows[1][0] = 0;
            secDt.Rows[1][1] = "Liabilities";
            secDt.Rows[1][2] = 1;
            secDt.Rows.Add(secDt.NewRow());
            secDt.Rows[2][0] = 0;
            secDt.Rows[2][1] = "Equity";
            secDt.Rows[2][2] = 2;
            secDt.Rows.Add(secDt.NewRow());
            secDt.Rows[3][0] = 0;
            secDt.Rows[3][1] = "Income";
            secDt.Rows[3][2] = 3;
            secDt.Rows.Add(secDt.NewRow());
            secDt.Rows[4][0] = 0;
            secDt.Rows[4][1] = "Expenses";
            secDt.Rows[4][2] = 4;
            cbSection.DataSource = null;
            cbSection.DataSource = secDt;
            cbSection.DisplayMember = "SecName";
            cbSection.ValueMember = "id";
            //throw new NotImplementedException();
        }

        private void LoadAccounts()
        {
            db = new ReportDataAccess();
            SqlCommand cmd = new SqlCommand();
            string sql = " select * from [ACC-REPORT] " +
                    " WHERE ParentCode IS NOT NULL AND  ReportHead = 0 order by AccountCat, ParentCode ";
            cmd.CommandText = sql;
            accDt = db.GetTable(cmd);
            
            
            ConfigureAccountDisplay();
            prntDt = new DataTable();
            prntDt = accDt.Copy();
            cbAccount.DataSource = prntDt;
            cbAccount.DisplayMember = "AccountWithName";
            cbAccount.ValueMember = "id";
           
            cbHeading.DataSource = accDt;
            cbHeading.DisplayMember = "AccountWithName";
            cbHeading.ValueMember = "id";

            //throw new NotImplementedException();
        }

        private void ConfigureAccountDisplay()
        {
            accDt.Columns.Add(new DataColumn("AccountWithName", typeof(string)));

            foreach( DataRow dr in accDt.Rows)
            {
                dr["AccountWithName"] = dr["AccountDesc"].ToString().PadLeft(int.Parse(dr["LevelOfDisplay"].ToString()));
            }
            string filter = "AccountCat='0' or AccountCat= '1'";
            balDt = accDt.Select(filter).CopyToDataTable();
            filter = "AccountCat='2' or AccountCat= '3'";
            try
            {
                iexDt = accDt.Select(filter).CopyToDataTable();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //throw new NotImplementedException();
        }

        private void LoadGLReport()
        {
            db = new ReportDataAccess();

            reportDt = db.GetTable("gl_ReportsMainMenu", "MenuLevel", 1);
            cbReportName.DataSource = reportDt;
            cbReportName.DisplayMember = "MenuName";
            cbReportName.ValueMember = "id";
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbReportName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReportName.SelectedValue != null)
            {
                //DataRow drselect =reportDt.NewRow();
                //drselect = (DataRow)( (DataRowView) cbReportName.SelectedItem);
                var selectVal = cbReportName.Text;
                //chngdReportName = true;
                //int selected =  int.Parse(selectVal.ToString());
                string selected = selectVal.ToString();
                if (rptFormat == null)
                    rptFormat = new ReportFormat();
                rptFormat.ReportFormatName = selected;
                switch (selected)
                {
                    case "Financial Reports":
                        break;
                    case "Trial Balance":
                        break;
                    case "Profit & Loss":
                        
                        SetPandLAccounts();
                        break;
                    case "Accounts Ledger":
                        break;
                    case "Balance Sheet":
                        
                        SetBalanceSheetAccounts();
                        break;
                }
            }
        }

        private void SetBalanceSheetAccounts()
        {
            LoadSections();
            string filter = "SecOrder =0 or SecOrder =1 or Secorder = 2";
            secDt = secDt.Select(filter).CopyToDataTable();
            cbSection.DataSource = null;
            cbSection.Refresh();
            cbSection.DataSource = secDt;
            cbSection.DisplayMember = "SecName";
            cbSection.ValueMember = "id";
            cbAccount.DataSource = null;
            cbAccount.Refresh();
            cbAccount.DataSource = balDt;
            cbAccount.DisplayMember = "AccountWithName";
            cbAccount.ValueMember = "id";
            if (accOpt == null)
            {
                accOpt = new Acc_Report_CRUD();
                
            }
            rptFormat = accOpt.GetExisitngFormat(rptFormat.ReportFormatName);


            // throw new NotImplementedException();
        }

        private void SetPandLAccounts()
        {

            LoadSections();
            string filter = "SecOrder =3 or SecOrder =4";
            secDt = secDt.Select(filter).CopyToDataTable();
            cbSection.DataSource = null;
            cbSection.Refresh();
            cbSection.DataSource = secDt;
            cbSection.DisplayMember = "SecName";
            cbSection.ValueMember = "id";
            cbAccount.DataSource = null;
            cbAccount.Refresh();
            cbAccount.DataSource = iexDt;
            cbAccount.DisplayMember = "AccountWithName";
            cbAccount.ValueMember = "id";

            //throw new NotImplementedException();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            cbHeading.DataSource = null;
            cbHeading.DropDownStyle = ComboBoxStyle.Simple;
            accReport = null;
        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccount.SelectedValue != null)
            {
                LoadSubAccounts();
            }
        }

        private void LoadSubAccounts()
        {
            int parentId = -1;
            if (cbAccount.SelectedIndex > -1)
            {
                DataRowView dv = (DataRowView) cbAccount.SelectedItem;
                parentId = int.Parse(dv[0].ToString());
            }
            
            SqlCommand cmd = new SqlCommand();
            string sql = "select * from dbo.viewAccountsRelation where ParentId =" + parentId +" AND AccountId != " + parentId;
            cmd.CommandText = sql;
            db = new ReportDataAccess();

            dtSubAcct = db.GetTable(cmd);
            lvSubAccts.Items.Clear();
            lvSubAccts.Columns.Clear();
            lvSubAccts.Refresh();
            lvSubAccts.Columns.Add("AccountCode",100,HorizontalAlignment.Left);
            lvSubAccts.Columns.Add("AccountDesc", -2, HorizontalAlignment.Left);
            lvSubAccts.View = View.Details;
            lvSubAccts.GridLines = true;
            lvSubAccts.FullRowSelect = true;
            if (dtSubAcct.Rows.Count > 0)
            {
                foreach (DataRow dr in dtSubAcct.Rows)
                {
                    ListViewItem lvitm = new ListViewItem();
                    //lvitm.Name = dr["AccountCode"].ToString();
                    lvitm.Text = dr["AccountCode"].ToString();
                    lvitm.SubItems.Add(dr["AccountDesc"].ToString());
                    //lvitm.SubItems.Add(dr["AccountDesc"].ToString());
                    lvSubAccts.Items.Add(lvitm);
                }
            }
            //throw new NotImplementedException();
        }

        private void tHeading_Enter(object sender, EventArgs e)
        {
            tsMsg.Text = "Type Main Heading ";
        }

        private void bAddDef_Click(object sender, EventArgs e)
        {
            //if ()
            SaveData();
            //AddToList();
            
            AddHeadtoList();
            LoadAccounts();
            
        }
        // We have check to remove duplicates
        private void SaveData()
        {
            if ( accReport == null)
                accReport = new Acc_Report();
            DataRowView dv = (DataRowView)cbSection.SelectedItem;
            accReport.AccountCat = dv["SecOrder"].ToString();
            accReport.AccType = dv["SecName"].ToString().Substring(0, 1);
            accReport.AccountCode = "    ";
            if (isEdit)
            {
                if (cbHeading.SelectedItem == null)
                {
                    accReport.AccountDesc = cbHeading.Text;
                }
                else
                {
                    dv = (DataRowView)cbHeading.SelectedItem;

                    accReport.AccountDesc = dv["AccountDesc"].ToString();
                }
            }
            else
                accReport.AccountDesc = cbHeading.Text;
            if (cbAccount.SelectedItem != null)
            {
                DataRowView dv2 = (DataRowView)cbAccount.SelectedItem;
                if (accReport.AccountDesc2 != dv2["AccountDesc"].ToString())
                {
                    if (MessageBox.Show("The Parent Code is changed do you want to Caontinue?", "Code Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }
                accReport.AccountDesc2 = dv2["AccountDesc"].ToString();
            }
            else
                accReport.AccountDesc2 = "";
            
            accReport.LevelofDisplay = (int)nLOD.Value;
            accReport.ParentCode = "";
            accReport.ReportHead = int.Parse(cbReportType.SelectedValue.ToString());
            accOpt = new Acc_Report_CRUD();
            accReport = accOpt.SaveHead(accReport);
            if (!isEdit)
            {
                if ((rptFormat == null) || (rptFormat.ReportFormatName != cbReportName.Text))
                {
                    rptFormat = new ReportFormat();
                    rptFormat.ReportCategory = cbReportName.Text;
                    rptFormat.ReportFormatName = cbReportName.Text;
                    rptFormat.CreatedDate = DateTime.Now;
                    rptFormat.CreatedBy = "System";
                    rptFormat = accOpt.SaveFormat(rptFormat);
                }
            }
            else
            {
                rptFormat = new ReportFormat();
                rptFormat =accOpt.GetExisitngFormat(cbReportName.Text);
            }
            if ( rptFmtDetail == null)
                rptFmtDetail = new ReportFormatDetail();
            rptFmtDetail = accOpt.GetFormatDetail(accReport.id, rptFormat.id);
            if (accReport.AccountDesc2 != "")
            {
                rptFmtDetail.AccountId = accReport.id;
                DataRowView dv1 = (DataRowView)cbAccount.SelectedItem;
                rptFmtDetail.ParentId = int.Parse(dv1[0].ToString());
                rptFmtDetail.FormatId = rptFormat.id;
                rptFmtDetail.DisplayLevel = (int)nLOD.Value;
                rptFmtDetail.PrintOrder = (int)nPrintOrder.Value;
                accOpt.SaveFormatDetail(rptFmtDetail);
            }
            isEdit = false;
            //throw new NotImplementedException();
        }

        private void AddToList()
        {
            if (HeaderList == null)
                HeaderList = new List<Acc_Report>();
            else
            {
                // Here we have to check the Header is available in the List
                Acc_Report oldOne = HeaderList.Where(o => o.id == accReport.id).FirstOrDefault();
                if (oldOne == null)
                {
                    HeaderList.Add(accReport);
                }
                else
                {
                    oldOne.AccountCat = accReport.AccountCat;
                    oldOne.AccountCode = accReport.AccountCode;
                    oldOne.AccountDesc = accReport.AccountDesc;
                    oldOne.AccountDesc2 = accReport.AccountDesc2;
                    oldOne.AccType = accReport.AccType;
                    oldOne.id = accReport.id;
                    oldOne.LevelofDisplay = accReport.LevelofDisplay;
                    oldOne.ParentCode = accReport.ParentCode;
                    oldOne.ReportHead = accReport.ReportHead;

                }
            }
            //throw new NotImplementedException();
        }

        private void AddHeadtoList()
        {
            DataTable listDt = new DataTable();
            db = new ReportDataAccess();
            SqlCommand cmd = new SqlCommand();
            string sql = " GetBalanceSheetAccounts @ReportHead";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@ReportHead", SqlDbType.Int)).Value = 0;
            listDt = db.GetTable(cmd);
            tvReportFormat.Nodes.Clear();
            TreeNode topNode = new TreeNode();
            topNode.Text = listDt.Rows[0][0].ToString();
            TreeNode lvl2Node = new TreeNode();
            lvl2Node.Text = listDt.Rows[0]["ParentDesc"].ToString();
            topNode.Nodes.Add(lvl2Node);
            tvReportFormat.Nodes.Add(topNode);
            int prid = -1;
            int lod = -1;
            prid = int.Parse(listDt.Rows[0]["ParentId2"].ToString());
            lod = int.Parse(listDt.Rows[0]["LevelofDisplay"].ToString());
            //int row = 0;
            for ( int row = 0; row < listDt.Rows.Count; row++)
            {
                TreeNode node = new TreeNode();
                prid = int.Parse(listDt.Rows[row]["ParentId2"].ToString());
                lod = int.Parse(listDt.Rows[row]["LevelofDisplay"].ToString());
                node.Text = listDt.Rows[row]["ParentDesc"].ToString();
                node.Name = listDt.Rows[row]["ParentId2"].ToString();
                switch (lod)
                {
                    case 1:
                        {
                            node.Text = listDt.Rows[row]["ParentDesc"].ToString();
                            break;
                        }
                    case 2:
                        {
                            while (prid == int.Parse(listDt.Rows[row]["ParentId2"].ToString()) && row < listDt.Rows.Count)
                            {
                                TreeNode subnode = new TreeNode();
                                subnode.Text = listDt.Rows[row]["AccountDesc"].ToString();
                                subnode.Name = listDt.Rows[row]["AccountId"].ToString();
                                node.Nodes.Add(subnode);
                                row++;
                                if (row >= listDt.Rows.Count)
                                    break;
                                
                            }
                            lvl2Node.Nodes.Add(node);
                            break;
                        }
                }
                
            }
            //foreach ( DataRow dr in listDt.Rows)
            //{
            //    if (int.Parse(dr["ParentId2"].ToString()) == prid && 
            //        int.Parse(listDt.Rows[0]["LevelofDisplay"].ToString()) == lod && 
            //        dr["AccountCode"].ToString().Trim() =="" )
            //    {
            //        TreeNode lvl3Node = new TreeNode();
            //        lvl3Node.Text = dr["AccountDesc"].ToString();
            //        lvl2Node.Nodes.Add(lvl3Node);
            //    }

            //}
           
          
            
            //throw new NotImplementedException();
        }

        private void cbHeading_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Here we have to load account report object
            GetAccountEntry();
            GetRelationEntry();
        }

        private void GetRelationEntry()
        {
            if (accOpt == null)
                accOpt = new Acc_Report_CRUD();
            int formatId = -1;
            DataRowView dv = (DataRowView) cbReportName.SelectedItem;
            formatId =int.Parse( dv[0].ToString());
            rptFmtDetail = accOpt.GetFormatDetail(accReport.id, formatId);
            //throw new NotImplementedException();
        }

        private void GetAccountEntry()
        {
            if (cbHeading.SelectedItem != null)
            {
                DataRowView dv = (DataRowView)cbHeading.SelectedItem;
                if (accReport == null)
                    accReport = new Acc_Report();
                accReport.AccountCat = dv["AccountCat"].ToString();
                accReport.AccountCode = dv["AccountCode"].ToString();
                accReport.AccountDesc = dv["AccountDesc"].ToString();
                accReport.AccountDesc2 = dv["AccountDesc2"].ToString();
                accReport.AccType = dv["AccType"].ToString();
                accReport.id = int.Parse(dv["id"].ToString());
                accReport.LevelofDisplay = int.Parse(dv["LevelofDisplay"].ToString());
                accReport.ParentCode = dv["ParentCode"].ToString();
                accReport.ReportHead = int.Parse(dv["ReportHead"].ToString());
                cbAccount.Text = accReport.AccountDesc2;
                nLOD.Value = accReport.LevelofDisplay;
                cbReportType.SelectedValue = accReport.ReportHead;
                if (accReport.AccType == "A")
                {
                    cbReportName.SelectedText = "Balance Sheet";
                    cbSection.SelectedValue = 0;
                }
                //db = new ReportDataAccess();

            }
            // accReport.AccType;
            //throw new NotImplementedException();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

            bAddDef_Click(sender, e);
            EnableControls(false);
            MessageBox.Show("Content saved ");
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (cbSection.DataSource == null)
                MessageBox.Show("Please Select format from List");
            else
            {
                //cbHeading.DropDownStyle = ComboBoxStyle.DropDownList;
                LoadAccounts();
                EnableControls(true);
                isEdit = true;
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            EnableControls(true);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIdx = -1;
            selIdx = tabControl1.SelectedIndex;
            switch (selIdx)
            {
                case 0:
                    break;
                case 1:
                {
                        LoadAccountsGrid();
                        lmsg.Text = "Select display node from the left three and select existing account header from the right grid\n " +
                        " press move << button to allocated headers.";
                        break;
                }
            }
        }

        private void LoadAccountsGrid()
        {
            accOpt = new Acc_Report_CRUD();

            accountDataset = new DataSet();
            accountDataset.Tables.Add(accOpt.GetMasterAccounts());
            accountDataset.Tables.Add(accOpt.GetDetailAcoounts());
            
            DataColumn keycol = accountDataset.Tables["Table1"].Columns[0];
            DataColumn foreignCol = accountDataset.Tables["Table2"].Columns[0];
            dgvAcct.AutoSize = true;
            dgvAcct.Refresh();
            dgvAcct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAcct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            accountDataset.Relations.Add("AccountRelation",keycol,foreignCol);
            dgvAcct.DataSource = accountDataset.Tables["Table1"];
            dgvAcct.Refresh();
        }

        private void tvReportFormat_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedNode = new TreeNode();
            selectedNode = e.Node;
        }

        private void dgvAcct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selecteddv = dgvAcct.Rows[e.RowIndex];
        }

        private void ReportConfigurator_Paint(object sender, PaintEventArgs e)
        {
            //if (selecteddv != null && selectedNode != null)
            //    bMove.Enabled = true;
            //else
            //    bMove.Enabled = false;
            int x = 0;
            //int y = 0;
            x = groupBox1.Width / 2;
            x = x - (int)(bMove.Width / 2);
            Point p = new Point();
            p.X = x - (int) bMove.Width /2 ;
            p.Y = bMove.Location.Y;
            bMove.Location = p;
            p.X = x + bMove.Width;
            p.Y = lHeadAccount.Location.Y;
            lHeadAccount.Location = p;
        }

        private void ReportConfigurator_Resize(object sender, EventArgs e)
        {
            
        }

        private void bMove_Click(object sender, EventArgs e)
        {
            if (rptFormat == null || rptFormat.id == null )
            {
                MessageBox.Show("Please select required report from the heading section");
                return;
            }
            if(selecteddv == null && selectedNode == null)
            {
                MessageBox.Show("No selected nodes or accounts");
                return;
            }
            else
            {
                TransferAccountsNode();
            }
        }

        private void TransferAccountsNode()
        {
            int selParentId = -1;
            selParentId = int.Parse(selecteddv.Cells["ParentId"].Value.ToString());
            DataTable selectedActsDt = new DataTable();
            selectedActsDt = accountDataset.Tables["Table2"].Select("ParentId=" + selParentId).CopyToDataTable();
            int lvl = selectedNode.Level;
            lvl--;
            foreach( DataRow dr in selectedActsDt.Rows)
            {
                if (accOpt == null)
                    accOpt = new Acc_Report_CRUD();
                rptFmtDetail = new ReportFormatDetail();
                rptFmtDetail.AccountId =(int) dr["AccountId"];
                rptFmtDetail.DisplayLevel = lvl;
                if (rptFormat == null)
                {
                    //rptFormat = accOpt.GetExisitngFormat();
                }
                rptFmtDetail.FormatId = rptFormat.id;
                rptFmtDetail.ParentId = selParentId;
                rptFmtDetail.PrintOrder = 0;
                
                rptFmtDetail = accOpt.SaveFormatDetail(rptFmtDetail);
                TreeNode subNode = new TreeNode();
                subNode.Text = dr["AccountDesc"].ToString();
                selectedNode.Nodes.Add(subNode);
            }
        //throw new NotImplementedException();
        }
    }
}
