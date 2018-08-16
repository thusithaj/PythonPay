using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class GLReportsMenu
    {
        public GLReportsMenu()
        {
            this.MenuLanguages = new HashSet<MenuLanguage>();
            this.SubMenu = new HashSet<GLReportSubMenu>();
        }
        //private ;
        public int id { get; set; }
        public string DefaultMenuName { get; set; }
        public string Status { get; set; }
        public int MenuLevel { get; set; }
        public int ParentMenuId { get; set; }
        public string DefaultLanguage { get; set; }
        public virtual ICollection<MenuLanguage> MenuLanguages { get; set; }
        public virtual ICollection<GLReportSubMenu> SubMenu { get; set; }
    }
}
