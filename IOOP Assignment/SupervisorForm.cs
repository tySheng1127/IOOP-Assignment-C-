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
            

        }

        private void SupervisorForm_Tick(object sender, EventArgs e)
        {
            DateNow.Text = DateTime.Now.ToString("yyyy/MM/dd"+":HH:mm:ss");
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
