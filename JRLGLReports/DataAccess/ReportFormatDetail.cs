using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ReportFormatDetail
    {
        public int? id { get; set; }
        public int? FormatId { get; set; }
        public int? AccountId { get; set; }
        public int? ParentId { get; set; }
        public int? DisplayLevel { get; set; }

        public int? PrintOrder { get; set; }
    }
}
