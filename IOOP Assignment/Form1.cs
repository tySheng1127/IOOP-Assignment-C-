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
        public Employee cu;
        DatabaseManagement dm = new DatabaseManagement();
        
        public LoginScreen()
        {
            cu = new Employee();
            InitializeComponent();
            txtPassword.PasswordChar = '*';//protect user's password when input
        }

        public void ShowForm(){
            this.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //read data from Loginlist table to test whether the username and password input same as data from database
            cu.userName = txtUsername.Text;
            cu.passWord = txtPassword.Text;
            dm.Login(cu);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();//close the program
        }


            
      
    }
}
