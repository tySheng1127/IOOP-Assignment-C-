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
    public partial class LoginScreen : Form
    {
        public CurrentUser cu;
        public LoginScreen()
        {
            cu = new CurrentUser();
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public void ShowForm(){
            this.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            cu.userName = txtUsername.Text;
            cu.passWord = txtPassword.Text;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\User\\Desktop\\IOOP Assignment C#\\IOOP Assignment\\Database.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LoginList WHERE Username ='" + txtUsername.Text + "' AND Password ='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (txtUsername.Text == "admin" || txtPassword.Text == "admin")
            {
                SupervisorForm sf = new SupervisorForm(cu);
                sf.ShowDialog();
            }
            else if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                CashierForm cashierform = new CashierForm(cu);
                cashierform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password !");
            }
            /*cu.userName = txtUsername.Text;
            cu.passWord = txtPassword.Text;
            if (txtPassword.Text == "" || txtUsername.Text == "" ) {
                MessageBox.Show("Please fill in the username and password.", "Login Error");
            }
            else if(txtUsername.Text=="admin" || txtUsername.Text=="admin") {
                this.Hide();
                SupervisorForm sf = new SupervisorForm(cu);
                sf.ShowDialog();
            }
            else
            {
                this.Hide();
                CashierForm cashierForm = new CashierForm(cu);
                cashierForm.ShowDialog();
            }*/

        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
