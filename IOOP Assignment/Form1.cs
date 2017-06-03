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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommand cmd;
        
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
            
            con.Open();
            cmd = new SqlCommand("select * from Loginlist where username='" + txtUsername.Text + "'and password='" + txtPassword.Text + "'and JobTitle='Supervisor'", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DateTime time = DateTime.Now;
                cmd = new SqlCommand("insert into LoggedSession(Username,LoginTime) values(@name,@login)", con);
                cmd.Parameters.AddWithValue("@name", txtUsername.Text);
                cmd.Parameters.AddWithValue("@login", time);
                cmd.ExecuteNonQuery();
                con.Close();
                cu.userName = txtUsername.Text;
                this.Hide();
                SupervisorForm sf = new SupervisorForm(cu);
                sf.ShowDialog();
            }
            else
            {
                cmd = new SqlCommand("select username,password from Loginlist where username='" + txtUsername.Text + "'and password='" + txtPassword.Text + "'", con);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    DateTime time = DateTime.Now;
                    cmd = new SqlCommand("insert into LoggedSession(Username,LoginTime) values(@name,@login)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@login", time);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    CashierForm cf = new CashierForm(cu);
                    cf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
  
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


            
      
    }
}
