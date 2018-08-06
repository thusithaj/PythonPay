using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccess
{
    public class MenuLanguage
    {
        public int id { get; set; }
        public int menuId { get; set; }
        public string MenuName { get; set; }
        public string menulanguage { get; set; }

    }
}
