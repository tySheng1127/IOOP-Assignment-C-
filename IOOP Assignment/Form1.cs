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
            }

        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
