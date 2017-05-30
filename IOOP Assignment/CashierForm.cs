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
            selectedItem.description = "Pen         ";
            selectedItem.price = 3.00;

        }

        private void btn_ruler_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Ruler       ";
            selectedItem.price = 1.00;
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Eraser     ";
            selectedItem.price = 0.50;
        }

        private void btn_CD_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "CD          ";
            selectedItem.price = 3.50;
        }

        private void btn_pendrive_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Pendrive ";
            selectedItem.price = 32;
        }

        private void btn_SDcard_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "SD Card  ";
            selectedItem.price = 64;
        }

        private void btn_bread_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Bread      ";
            selectedItem.price = 2.00;
        }

        private void btn_Biscuit_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Biscuit     ";
            selectedItem.price = 1.50;
        }

        private void btn_Candy_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Candy     ";
            selectedItem.price = 0.10;
        }

        private void btn_Panadol_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Panadol  ";
            selectedItem.price = 12;
        }

        private void btn_drink_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Drinks     ";
            selectedItem.price = 2.50;
        }

        private void btn_coffe_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Coffee     ";
            selectedItem.price = 1.70;
        }

        private void btn_OJ_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Orange J ";
            selectedItem.price = 4.00;
        }

        private void btn_milk_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Milk         ";
            selectedItem.price = 3.50;
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "A4 Paper";
            selectedItem.price = 0.30;
        }

        private void btn_flower_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Flower     ";
            selectedItem.price = 1.50;
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Sandwich";
            selectedItem.price = 5.50;
        }

        private void btn_colour_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Colour     ";
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
