using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace ReportsFormofGL
{
    public partial class MenuCreation : Form
    {
        List<InputLanguage> languages;
        List<string> lngNames;
        InputLanguage selectLng;
        string fontName;
        GLReportsMenu glrmenu;
        ReportMenuController rmc;
        int mode = -1;
        const int ADD = 0;
        const int EDIT = 1;
        const int DELETE = 3;
        DataTable dtstat;
        int selectedLanguage = ConnectionInfo.Language;
        //DataGridView dgvSubMenu;
        public MenuCreation()
        {
            InitializeComponent();
        }

        private void SetButtons ( )
        {
            switch (mode)
            {
                case -1: 
                    bAdd.Enabled = true;
                    bEdit.Enabled = false;
                    bSave.Enabled = false;
                    break;
                case 0:
                    bAdd.Enabled = false;
                    bEdit.Enabled = false;
                    bSave.Enabled = true;
                    break;
                case 1:
                    bAdd.Enabled = false;
                    bEdit.Enabled = false;
                    bSave.Enabled = true;
                    bSave.Text = "Update";
                    break;

            }
        }
        private void MenuCreation_Load(object sender, EventArgs e)
        {
            LoadSystemLocales();
            lHelpMsg.Text = " Select the prefered language. Before add any other languages the English Language menuname has to be created\n" +
            " After that create the menu. By default the top level menu will be created and the next level will be auto adjusted. \n";
            LoadMenuList();
           
            SetButtons();
            tDefaultName.DataSource = rmc.menuList.ToList();
            tDefaultName.DisplayMember = "DefaultMenuName";
            tDefaultName.ValueMember = "id";
            SetActiveData();
        }

        private void LoadMenuList()
        {
            rmc = new ReportMenuController();
            dgvReportsMenus.DataSource = rmc.menuList.ToList();
            cbParentMenu.DataSource = rmc.menuList.ToList();
            cbParentMenu.DisplayMember = "DefaultMenuName";
            cbParentMenu.ValueMember = "id";
            cbParentMenu.SelectedIndex = -1;
            dgvSubMenu.Visible = false;
            FormatGrid();
            //throw new NotImplementedException();
        }

        private void SetActiveData()
        {
            dtstat = new DataTable();
            dtstat.Columns.Add(new DataColumn("Status", typeof(string)));
            dtstat.Columns.Add(new DataColumn("Description,", typeof(string)));
            dtstat.Rows.Add(dtstat.NewRow());
            dtstat.Rows[0][0] = "A";
            dtstat.Rows[0][1] = "Active";
            dtstat.Rows.Add(dtstat.NewRow());
            dtstat.Rows[1][0] = "I";
            dtstat.Rows[1][1] = "In-Active";
            cbStatus.DataSource = dtstat;
            cbStatus.DisplayMember = "Description";
            cbStatus.ValueMember = "Status";
            
        }

        private void FormatGrid()
        {
            foreach (DataGridViewColumn dgvc in dgvReportsMenus.Columns)
            {
                switch (dgvc.Index)
                {
                    case 1:
                        dgvc.Visible = true;
                        dgvc.HeaderText = "Default Menu Name ";
                        dgvc.Width = 200;
                        break;
                    case 2:
                        dgvc.Visible = true;
                        dgvc.HeaderText = "Menu Status  ";
                        dgvc.Width = 100;
                        break;
                    default:
                        dgvc.Visible = false;
                        break;
                }
            }
            dgvReportsMenus.Refresh();
        }

        private void LoadSystemLocales()
        {
            languages = new List<InputLanguage>();
            lngNames = new List<string>();
            foreach (InputLanguage inpl in InputLanguage.InstalledInputLanguages)
            {
                languages.Add(inpl);
                lngNames.Add(inpl.Culture.EnglishName);
            }

            lbLocale.DataSource = lngNames;
            fontName = "BhashitaComplex";
            
            
        }

        private void lbLocale_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectLng = languages[lbLocale.SelectedIndex];
            selectedLanguage = lbLocale.SelectedIndex;
            if (selectLng.Culture.EnglishName.Contains("Sinhala"))
                fontName = "BhashitaComplex";
            else
                fontName = "Microsoft Sans Serif";
            InputLanguage.CurrentInputLanguage = selectLng;
            //Font inputFont = new Font(FontFamily.GenericSerif, FontStyle.Regular);
            tMenuName.Font = new System.Drawing.Font(fontName, 15.75F, System.Drawing.FontStyle.Regular,
                                 System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            mode = ADD;
            SetButtons();
        }

        #region test
        //List<TextBox> menuNames = new List<TextBox>();
        //int lngCount = 0;
        //Point newLoc = new Point();
        //newLoc.X = tMenuName.Location.X + tMenuName.Width;
        //newLoc.Y = tMenuName.Location.Y;

        //InputLanguage defaultLng = InputLanguage.DefaultInputLanguage;
        //foreach (InputLanguage inpl in InputLanguage.InstalledInputLanguages)
        //{
        //    if (lngCount >= 1 && defaultLng.Culture.Name != inpl.Culture.Name)
        //    {
        //        TextBox tMenuName2 = new TextBox();

        //        if (newLoc.X == -1)
        //        {
        //            newLoc.X = tMenuName.Location.X + tMenuName.Width;
        //            newLoc.Y = tMenuName.Location.Y;
        //        }

        //        tMenuName2.Location = newLoc;
        //        tMenuName2.Size = tMenuName.Size;
        //        tMenuName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

        //        tMenuName2.TabIndex = tMenuName2.TabIndex + 1;
        //        menuNames.Add(tMenuName2);
        //        tMenuName2.Font = new System.Drawing.Font(fontName, 15.75F, System.Drawing.FontStyle.Regular,
        //                     System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //        tMenuName2.Enter += TMenuName2_Enter;
        //        tMenuName2.Leave += TMenuName2_Leave;
        //        this.SuspendLayout();
        //        this.tpMenuAdd.Controls.Add(tMenuName2);

        //        newLoc.X = newLoc.X + tMenuName2.Width;
        //        this.ResumeLayout();
        //    }
        //    lngCount++;
        //    defaultLng = inpl;
        //}
        //private void TMenuName2_Leave(object sender, EventArgs e)
        //{
        //    InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage;
        //    //throw new NotImplementedException();
        //}

        //private void TMenuName2_Enter(object sender, EventArgs e)
        //{
        //    if (fontName == "BhashitaComplex")
        //        InputLanguage.CurrentInputLanguage = languages[1];
        ////throw new NotImplementedException();
        //}
        #endregion test

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParentMenu.SelectedIndex > -1)
            {
                GLReportsMenu menu = (GLReportsMenu)cbParentMenu.SelectedItem;
                nMenuLevel.Value =menu.MenuLevel++ ;
                if (glrmenu != null)
                    glrmenu.ParentMenuId = menu.id;
            }
        }

        private void dgvReportsMenus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dgvSubMenu = new DataGridView();
            dgvReportsMenus.SuspendLayout();
            dgvSubMenu.Location = new Point( e.X+ 350 ,e.Y );
            
            glrmenu = (GLReportsMenu) dgvReportsMenus.Rows[e.RowIndex].DataBoundItem;
            dgvSubMenu.DataSource = glrmenu.MenuLanguages.ToList();
            //tabControl1.TabPages[0].Controls.Add(dgvSubMenu);
            dgvSubMenu.Visible = true;
            dgvSubMenu.Size = new Size(250, 150);
            FormatSubMenuGrid();
            dgvReportsMenus.ResumeLayout();
            
        }

        private void FormatSubMenuGrid()
        {
            //throw new NotImplementedException();
            foreach( DataGridViewColumn dgvc in dgvSubMenu.Columns)
            {
                switch (dgvc.Index)
                {
                    case 1:
                        dgvc.Visible = false;
                        break;
                    case 2:
                        dgvc.Visible = true;
                        dgvc.HeaderText = "Display Language ";
                        dgvc.Width = 200;
                        break;
                    default:
                        dgvc.Visible = false;
                        break;
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            LoadControlData();
            if (mode == 1)
                bSave.Text = "Save";
            try
            {
                rmc.SaveMenu(glrmenu);
                MessageBox.Show("Menu saving successful", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mode = -1;
                SetButtons();
                LoadMenuList();
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error occured during save\n" + ex.Message);
            }
            
        }

        private void LoadControlData()
        {
            if (mode == ADD)
            {
                glrmenu = new GLReportsMenu();
            }
            glrmenu.DefaultLanguage = languages[0].Culture.Name;
            glrmenu.DefaultMenuName = tDefaultName.Text;
            glrmenu.MenuLevel = (int)nMenuLevel.Value;
            glrmenu.Status = cbStatus.SelectedValue.ToString();
            glrmenu.ParentMenuId = GetParentMenu();
            
            MenuLanguage ml = new MenuLanguage();
            selectLng = languages[selectedLanguage];
            ml = glrmenu.MenuLanguages.Where(o => o.menulanguage == selectLng.Culture.Name).FirstOrDefault();
            if (ml != null)
            {
                ml.menulanguage = selectLng.Culture.Name;
                ml.MenuName = tMenuName.Text;
                
            }else
            {
                ml = new MenuLanguage();
                ml.menulanguage = selectLng.Culture.Name;
                ml.MenuName = tMenuName.Text;
                glrmenu.MenuLanguages.Add(ml);
            }

            if (tReportForm.Text != "" && tDllName.Text != "")
            {
                GLReportSubMenu glsubmenu = new GLReportSubMenu();
                glsubmenu = glrmenu.SubMenu.Where(o => o.formName == tReportForm.Text).FirstOrDefault();
                if (glsubmenu != null)
                {
                    glsubmenu.formName = tReportForm.Text;
                    glsubmenu.nameofDLL = tDllName.Text;
                }
                else
                {
                    glsubmenu = new GLReportSubMenu();
                    glsubmenu.formName = tReportForm.Text;
                    glsubmenu.nameofDLL = tDllName.Text;
                    glrmenu.SubMenu.Add(glsubmenu);
                }
            }
            
            
            
        }

        private int GetParentMenu()
        {
            int pmid = -1;
            GLReportsMenu pmenu = (GLReportsMenu) cbParentMenu.SelectedItem;
            if (pmenu != null)
                pmid=pmenu.id;
            return pmid;
        }

        private void dgvReportsMenus_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            glrmenu = (GLReportsMenu)dgvReportsMenus.Rows[e.RowIndex].DataBoundItem;
            mode = EDIT;
            ShowControlValue();
            SetButtons();
            tabControl1.SelectedIndex = 1;
        }

        private void ShowControlValue()
        {
            tDefaultName.Text = glrmenu.DefaultMenuName;
            nMenuLevel.Value = glrmenu.MenuLevel;

            tMenuName.Text = glrmenu.MenuLanguages.ToList()[ConnectionInfo.Language].MenuName;
            if ( glrmenu.ParentMenuId>0)
                cbParentMenu.SelectedValue = glrmenu.ParentMenuId;
            tDllName.Text = glrmenu.SubMenu.ToList()[0].nameofDLL;
            tReportForm.Text = glrmenu.SubMenu.ToList()[0].formName;
        
        }
    }
}
