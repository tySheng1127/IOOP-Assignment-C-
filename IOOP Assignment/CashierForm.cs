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
    public partial class CashierForm : Form
    {

        private int x;
        double total;
        Item selectedItem;
        CurrentUser cu = new CurrentUser();
        List<Item> list = new List<Item>();
        int paid, bill;
        

        public CashierForm(CurrentUser currentUser)
        {
            InitializeComponent();
            cu = currentUser;
            TimeNow.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
            x = 1;
            total = 0;
            rtbDetails.Text = cu.userName;
            selectedItem = new Item();
          
        }

        public CashierForm()
        {
            // TODO: Complete member initialization
        }

 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            this.Dispose();
            ls.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P01 Pen         ";
            selectedItem.price = 3.00;
            selectedItem.GST = 0;

        }

        private void btn_ruler_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P02 Ruler       ";
            selectedItem.price = 1.00;
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P03 Eraser     ";
            selectedItem.price = 0.50;
        }

        private void btn_CD_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P04 CD          ";
            selectedItem.price = 3.50;
        }

        private void btn_pendrive_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P05 Pendrive ";
            selectedItem.price = 32;
        }

        private void btn_SDcard_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P06 SD Card  ";
            selectedItem.price = 64;
        }

        private void btn_bread_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P07 Bread      ";
            selectedItem.price = 2.00;
        }

        private void btn_Biscuit_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P08 Biscuit     ";
            selectedItem.price = 1.50;
        }

        private void btn_Candy_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P09 Candy     ";
            selectedItem.price = 0.10;
        }

        private void btn_Panadol_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P10 Panadol  ";
            selectedItem.price = 12;
        }

        private void btn_drink_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P11 Drinks     ";
            selectedItem.price = 2.50;
        }

        private void btn_coffe_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P12 Coffee     ";
            selectedItem.price = 1.70;
        }

        private void btn_OJ_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P13 Orange J ";
            selectedItem.price = 4.00;
        }

        private void btn_milk_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P14 Milk         ";
            selectedItem.price = 3.50;
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P15 A4 Paper";
            selectedItem.price = 0.30;
        }

        private void btn_flower_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P16 Flower     ";
            selectedItem.price = 1.50;
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P17 Sandwich";
            selectedItem.price = 5.50;
        }

        private void btn_colour_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P18 Colour     ";
            selectedItem.price = 9.50;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            // if index == 0, do nothing
            if (lbItem.SelectedIndex >= 0)
            {
                int stupidIndex = lbItem.SelectedIndex;
                total -= list[stupidIndex].price * list[stupidIndex].quantity;
                rtbTotal.Text = total.ToString();
                list.RemoveAt(stupidIndex);
                lbItem.Items.Remove(lbItem.SelectedItem);
                x--;
            }
            
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {

            if (selectedItem.description == "error")
            {
                MessageBox.Show("Please Choose an Item");
            }
            else
            {
                selectedItem.quantity = int.Parse(txtQuantity.Text);
                lbItem.Items.Add(x.ToString() + "                             " + selectedItem.description + "                                 " + txtQuantity.Text +"          "+ selectedItem.price);
                x++;
                total += selectedItem.price * int.Parse(txtQuantity.Text);
                rtbTotal.Text = total.ToString();
                list.Add(selectedItem);
                selectedItem = new Item();
            }

        }

        private void btn_Changes_Click(object sender, EventArgs e)
        {
            paid = int.Parse(txtPrepaid.Text);
            bill = int.Parse(rtbTotal.Text);
            txtChange.Text = (paid - bill).ToString();

        }

        private void btn_GReceipt_Click(object sender, EventArgs e)
        {
            if (txtChange.Text == "")
            {
                MessageBox.Show("Payment must be made before generate receipt!");
            }
            else{
            Receipt rc = new Receipt(list, paid, bill);
            rc.ShowDialog();
            }
           
          

        }
        


    }
}
