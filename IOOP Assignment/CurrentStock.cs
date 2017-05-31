using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class CurrentStock : Form
    {
        DatabaseManagement dbm = new DatabaseManagement();

        public CurrentStock()
        {
            InitializeComponent();
        }

        private void CurrentStock_Load(object sender, EventArgs e)
        {
            dbm.ViewAll();
        }
    }
}
