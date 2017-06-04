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

namespace IOOP_Assignment
{
    public partial class TransactionList : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlDataAdapter adapt;
        CurrentUser cu = new CurrentUser();
        public TransactionList(CurrentUser currentuser)
        {
            InitializeComponent();
            cu = currentuser;
            DisplayData();
        }

        private void DisplayData()//display data in data grid view
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [Transaction] where EmployeeInCharge='"+cu.userName+"'", con);
            adapt.Fill(dt);
            DGV_TransactionList.DataSource = dt;
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
