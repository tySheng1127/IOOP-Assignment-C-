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
    public partial class SupervisorForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        CurrentUser cu = new CurrentUser();
        DateTime time = DateTime.Now;

        public SupervisorForm(CurrentUser currentuser)
        {
            InitializeComponent();
            cu = currentuser;
            rtb_detail.Text = "Logged in as: " + cu.userName + "\n Logged in since: " + time;

        }


       
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            
            cmd = new SqlCommand("insert into LoggedSession(Username,LogoutTime) values(@name,@logout)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", cu.userName);
            cmd.Parameters.AddWithValue("@logout", time);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            LoginScreen ls = new LoginScreen();
            ls.ShowForm();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            CurrentStock cs = new CurrentStock(cu);
            cs.ShowDialog();
        }

        private void btm_switchCashier_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierForm cashform = new CashierForm(cu);
            cashform.ShowDialog();
  

        }

        private void btn_EmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeList el = new EmployeeList();
            el.ShowDialog();
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("yyyy/MM/dd  "+"HH:mm:ss");
        }

        private void btn_Logged_Click(object sender, EventArgs e)
        {
            LoggedSession ls = new LoggedSession();
            ls.ShowDialog();
        }

        private void btn_Transacition_Click(object sender, EventArgs e)
        {
            TransactionRecord tr = new TransactionRecord();
            tr.ShowDialog();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ShowDialog();
        }
    }
}
