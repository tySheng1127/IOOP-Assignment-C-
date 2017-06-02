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

        
        CurrentUser cu = new CurrentUser();

        public SupervisorForm(CurrentUser currentuser)
        {
            InitializeComponent();
            cu = currentuser;
            rtb_detail.Text = cu.userName;
            DateNow.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");

        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginScreen ls = new LoginScreen();
            ls.ShowForm();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            CurrentStock cs = new CurrentStock();
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
    }
}
