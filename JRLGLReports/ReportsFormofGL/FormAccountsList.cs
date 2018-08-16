using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsFormofGL
{
    

    public partial class FormAccountsList : Form
    {
        public string CompanyCode { get; set; }
        public string ComName { get; set; }
        public FormAccountsList()
        {
            InitializeComponent();
        }
        public FormAccountsList( string ComCode, string COmName)
        {
            InitializeComponent();
            CompanyCode = ComCode;
            ComName = COmName;
        }
    }
}
