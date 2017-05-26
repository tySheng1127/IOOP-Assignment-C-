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
    public partial class SupervisorForm : Form
    {
        LoginScreen loginScreen = new LoginScreen();
        public SupervisorForm(LoginScreen LoginS)
        {
            InitializeComponent();
            loginScreen = LoginS; 
        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            loginScreen.ShowForm();
            this.Dispose();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {

        }
    }
}
