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
        SqlConnection con;
        SqlDataAdapter sda;
        
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
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select username,password from Loginlist where username='" + txtUsername.Text + "'and password='" + txtPassword.Text + "'", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (txtUsername.Text == "admin" || txtPassword.Text == "admin")
            {
                SupervisorForm sf = new SupervisorForm(cu);
                sf.ShowDialog();
            }
            else if (dt.Rows.Count > 0)  
            {
                this.Hide();
                MessageBox.Show("Login sucess");  
                CashierForm cf = new CashierForm(cu);
                cf.ShowDialog();
            }  
            else  
            {  
                MessageBox.Show("Invalid Login please check username and password");  
            }  
            con.Close(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
}
