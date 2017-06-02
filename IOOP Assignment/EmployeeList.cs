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
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.databaseDataSet.Employee);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
