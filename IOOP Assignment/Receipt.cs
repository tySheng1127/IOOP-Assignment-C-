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
    public partial class Receipt : Form
    {
        List<Item> list = new List<Item>();
        CashierForm cf = new CashierForm();
        


        public Receipt(List<Item> listFromCashierForm, int paid, int bill)
        {
            list = listFromCashierForm;
            InitializeComponent();
            lb_currentdt.Text = DateTime.Now.ToString();
            rtb_receipt.Text = "Description             Price               Quantity\n";
            for (int i = 0; list.Count() > i; i++) {
                rtb_receipt.Text += list[i].description + "                " + list[i].price.ToString() + "                  " + list[i].quantity.ToString() + "\n";
            }
            rtb_Change.Text = "Total:" + bill.ToString()+"\n"+"Payment: "+paid.ToString()+"\n"+"Changes:" + (paid - bill).ToString(); 
           
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

    }
}
