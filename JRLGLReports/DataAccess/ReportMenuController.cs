using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class ReportMenuController
    {
        public GLReportsMenu glreports ;
        private ReportDataAccess db;
        public ICollection<GLReportsMenu> menuList;
        public ReportMenuController()
        {
            glreports = new GLReportsMenu();
            db = new ReportDataAccess();
            menuList = new HashSet<GLReportsMenu>();
            GetMenuList("");

        }
        public void GetMenus()
        {
            DataTable dt = new DataTable();

        }
        public void SaveMenu (GLReportsMenu menuobj)
        {
            SqlCommand sqlcmd = new SqlCommand();
            string strsql = "";
            if (!MenuMaster(menuobj.id))
            {
                strsql = "INSERT INTO gl_ReportsMainMenu (DefaultMenuName, Status,MenuLevel,DefaultLanguage,ParentMenuId)" +
                " VALUES ( @DefaultMenuName, @Status,@MenuLevel,@DefaultLanguage,@ParentMenuId)";
                sqlcmd.CommandText = strsql;
                
            }
            else
            {
                strsql = "UPDATE gl_ReportsMainMenu  SET DefaultMenuName = @DefaultMenuName, Status = @Status, MenuLevel = @MenuLevel ,DefaultLanguage =@DefaultLanguage " +
                   ", ParentMenuId = @ParentMenuId WHERE id = @id";
                sqlcmd.CommandText = strsql;
                sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = menuobj.id;
            }
            sqlcmd.Parameters.Add(new SqlParameter("@DefaultMenuName", SqlDbType.NVarChar)).Value = menuobj.DefaultMenuName;
            sqlcmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar)).Value = menuobj.Status==null ? "A" : menuobj.Status;
            sqlcmd.Parameters.Add(new SqlParameter("@MenuLevel", SqlDbType.Int)).Value = menuobj.MenuLevel;
            sqlcmd.Parameters.Add(new SqlParameter("@DefaultLanguage", SqlDbType.NVarChar)).Value = menuobj.DefaultLanguage;
            sqlcmd.Parameters.Add(new SqlParameter("@ParentMenuId", SqlDbType.NVarChar)).Value = menuobj.ParentMenuId;
            db.ExecuteCmd(sqlcmd);
            glreports = GetMenuMaster(menuobj.DefaultMenuName);
            sqlcmd = new SqlCommand();
            foreach ( MenuLanguage ml in menuobj.MenuLanguages)
            {
                if (!isLanguageExist(ml.id))
                {
                    strsql = "INSERT INTO menuLanguage(menuId,MenuName,menulanguage)  VALUES ( @menuId,@MenuName,@menuLanguage)";
                    sqlcmd.CommandText = strsql;
                }
                else
                {
                    strsql = " UPDATE menuLanguage SET menuId=@menuId, MenuName=@MenuName, menulanguage=@menuLanguage" +
                        " WHERE id=@id";
                    sqlcmd.CommandText = strsql;
                    sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = ml.id;
                }
                sqlcmd.Parameters.Add(new SqlParameter("@menuId", SqlDbType.Int)).Value = glreports.id;
                sqlcmd.Parameters.Add(new SqlParameter("@MenuName", SqlDbType.NVarChar)).Value = ml.MenuName;
                sqlcmd.Parameters.Add(new SqlParameter("@MenuLanguage", SqlDbType.NVarChar)).Value = ml.menulanguage;
                db.ExecuteCmd(sqlcmd);
            }
            sqlcmd = new SqlCommand();
            foreach (GLReportSubMenu submenu in menuobj.SubMenu)
            {
                if ( !isSubReport(submenu.id) && (submenu.formName !="" && submenu.formName !=null))
                {
                    strsql = "INSERT INTO ReportsSubMenu (menuId, formName, nameofDLL)" +
                      " VALUES (@menuId,@formName,@nameofDLL)";
                    sqlcmd.CommandText = strsql;

                }
                else
                {
                    strsql = "UPDATE ReportsSubMenu  SET menuId = @menuId, formName = @formName, nameofDLL=@nameofDLL " +
                    " WHERE id=@id";
                    sqlcmd.CommandText = strsql;
                    sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = submenu.id;
                }
                sqlcmd.Parameters.Add(new SqlParameter("@menuId", SqlDbType.Int)).Value = glreports.id;
                sqlcmd.Parameters.Add(new SqlParameter("@formName", SqlDbType.NVarChar)).Value = submenu.formName;
                sqlcmd.Parameters.Add(new SqlParameter("@nameofDLL", SqlDbType.NVarChar)).Value = submenu.nameofDLL;
                db.ExecuteCmd(sqlcmd);
            }
        }

        private bool isSubReport(int id)
        {
            bool retval = false;
            DataTable dt = db.GetTable("ReportsSubMenu", "id", id);
            if (dt.Rows.Count == 1)
                retval = true;
            return retval;//throw new NotImplementedException();
        }

        private bool isLanguageExist(int id)
        {
            bool retval = false;
            DataTable dt = db.GetTable("menuLanguage", "id", id);
            if (dt.Rows.Count == 1)
                retval = true;
            return retval;
            //throw new NotImplementedException();
        }

        private bool MenuMaster(int id)
        {
            bool retval = false;
            DataTable dt = db.GetTable("gl_ReportsMainMenu", "id", id);
            if (dt.Rows.Count == 1)
                retval = true;
            return retval;
        //throw new NotImplementedException();

        }
        private GLReportsMenu GetMenuMaster( string menuname)
        {
            GLReportsMenu mnutmp = new GLReportsMenu();
            DataTable dt = db.GetTable("gl_ReportsMainMenu", "DefaultMenuName", menuname);
            if (dt.Rows.Count == 1)
            {
                mnutmp.id = int.Parse( dt.Rows[0]["id"].ToString());
                mnutmp.DefaultMenuName = dt.Rows[0]["DefaultMenuName"].ToString();
                mnutmp.MenuLevel=int.Parse(dt.Rows[0]["MenuLevel"].ToString());
                mnutmp.Status = dt.Rows[0]["Status"].ToString();
            }
            dt = db.GetTable("menuLanguage", "menuId", mnutmp.id);
            if (dt.Rows.Count > 0)
            {
                foreach ( DataRow dr in dt.Rows)
                {
                    MenuLanguage mlng = new MenuLanguage();
                    mlng.id = int.Parse( dr["id"].ToString());
                    mlng.MenuName = dr["MenuName"].ToString();
                    mlng.menuId = int.Parse(dr["menuId"].ToString());
                    mnutmp.MenuLanguages.Add(mlng);
                }
                
            }
            return mnutmp;
        }
        public void GetMenuList(string culture)
        {
            SqlCommand cmd = new SqlCommand();
            string sql = " select a.*,b.id lanid, b.MenuName, b.menuId,b.menulanguage " + 
            " from gl_ReportsMainMenu a inner join menuLanguage b on a.id=b.menuId " +
            " Order by a.id" ;
            if (culture != "")
                sql = sql + " WHERE b.menulanguage='" + culture + "'";
            cmd.CommandText = sql;
            DataTable dt = db.GetTable(cmd);
            //DataTable dtModi = new DataTable();
            for  (int i = 0; i< dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                GLReportsMenu menu = new GLReportsMenu();
                menu.id = int.Parse( dr["id"].ToString());
                menu.DefaultLanguage = dr["DefaultLanguage"].ToString();
                menu.MenuLevel = int.Parse(dr["MenuLevel"].ToString());
                menu.DefaultMenuName = dr["DefaultMenuName"].ToString();
                int pmid = 0;
                pmid=String.IsNullOrEmpty( dr["ParentMenuId"].ToString()) ? 0 : int.Parse(dr["ParentMenuId"].ToString());
                menu.ParentMenuId= pmid;
                menu.Status = dr["Status"].ToString();
                while((i < dt.Rows.Count) && (dr["id"].ToString() == dt.Rows[i]["id"].ToString()) )
                {
                    MenuLanguage mlng = new MenuLanguage();
                    mlng.id = int.Parse(dt.Rows[i]["lanid"].ToString());
                    mlng.menuId= int.Parse(dt.Rows[i]["menuId"].ToString());
                    mlng.menulanguage = dt.Rows[i]["menulanguage"].ToString();
                    mlng.MenuName= dt.Rows[i]["MenuName"].ToString();
                    
                    i++;
                    menu.MenuLanguages.Add(mlng);
                    //if (i < dt.Rows.Count)
                    //    dr = dt.Rows[i];
                }
                i--;
                menu.SubMenu.Add( GetSubmenu(menu));
                menuList.Add(menu);

            }
        }

        private GLReportSubMenu GetSubmenu(GLReportsMenu menu)
        {
            GLReportSubMenu submenu= new GLReportSubMenu();
            SqlCommand cmd = new SqlCommand();
            string sql = " select * from ReportsSubMenu Where menuId=" + menu.id;
            
            cmd.CommandText = sql;
            DataTable dt = db.GetTable(cmd);
            if (dt.Rows.Count >0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    submenu = new GLReportSubMenu();
                    submenu.id = int.Parse(dr["id"].ToString());
                    submenu.menuId = int.Parse(dr["menuId"].ToString());
                    submenu.formName = dr["formName"].ToString();
                    submenu.nameofDLL = dr["nameofDLL"].ToString();
                    menu.SubMenu.Add(submenu);
                }

            }
            return submenu;
            //throw new NotImplementedException();
        }
    }
}
