using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    public class Acc_Report
    {
        public int? id { get; set; }
        public string AccountCode { get; set; }
        public string ParentCode { get; set; }
        public string AccType { get; set; }
        public int LevelofDisplay { get; set; }
        public string AccountCat { get; set; }
        public string AccountDesc { get; set; }
        public string AccountDesc2 { get; set; }
        public int ReportHead { get; set; }

    }
}
