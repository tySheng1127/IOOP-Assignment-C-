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
    public partial class CashierForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
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
            TimeNow.Text = DateTime.Now.ToString("yyyy/MM/dd");
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



        private void btn_pen_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Pen         ";
            selectedItem.price = 3.00;
            selectedItem.GST = 0;
            selectedItem.product = "P01";

        }

        private void btn_ruler_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Ruler       ";
            selectedItem.price = 1.00;
            selectedItem.product = "P02";
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P03 Eraser     ";
            selectedItem.price = 0.50;
            selectedItem.product = "P03";
        }

        private void btn_CD_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P04 CD          ";
            selectedItem.price = 3.50;
            selectedItem.product = "P04";
        }

        private void btn_pendrive_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P05 Pendrive ";
            selectedItem.price = 32;
            selectedItem.product = "P05";
        }

        private void btn_SDcard_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P06 SD Card  ";
            selectedItem.price = 64;
            selectedItem.product = "P06";
        }

        private void btn_bread_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P07 Bread      ";
            selectedItem.price = 2.00;
            selectedItem.product = "P07";
        }

        private void btn_Biscuit_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P08 Biscuit     ";
            selectedItem.price = 1.50;
            selectedItem.product = "P08";
        }

        private void btn_Candy_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P09 Candy     ";
            selectedItem.price = 0.10;
            selectedItem.product = "P09";
        }

        private void btn_Panadol_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P10 Panadol  ";
            selectedItem.price = 12;
            selectedItem.product = "P10";
        }

        private void btn_drink_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P11 Drinks     ";
            selectedItem.price = 2.50;
            selectedItem.product = "P11";
        }

        private void btn_coffe_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P12 Coffee     ";
            selectedItem.price = 1.70;
            selectedItem.product = "P12";
        }

        private void btn_OJ_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P13 Orange J ";
            selectedItem.price = 4.00;
            selectedItem.product = "P13";
        }

        private void btn_milk_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P14 Milk         ";
            selectedItem.price = 3.50;
            selectedItem.product = "P14";
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P15 A4 Paper";
            selectedItem.price = 0.30;
            selectedItem.product = "P15";
        }

        private void btn_flower_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P16 Flower     ";
            selectedItem.price = 1.50;
            selectedItem.product = "P16";
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P17 Sandwich";
            selectedItem.price = 5.50;
            selectedItem.product = "P17";
        }

        private void btn_colour_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "P18 Colour     ";
            selectedItem.price = 9.50;
            selectedItem.product = "P18";
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
                cmd = new SqlCommand("INSERT INTO ItemSales values(@id,@product,@quantity,@price)",con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", "S"+ x.ToString());
                cmd.Parameters.AddWithValue("@product", selectedItem.product);
                cmd.Parameters.AddWithValue("@quantity", selectedItem.quantity);
                cmd.Parameters.AddWithValue("@price", selectedItem.price);
                
                cmd.ExecuteNonQuery();
                con.Close();


            }

        }

        private void btn_Changes_Click(object sender, EventArgs e)
        {
            if (txtChange.Text != "")
            {
                paid = int.Parse(txtPrepaid.Text);
                bill = int.Parse(rtbTotal.Text);
                txtChange.Text = (paid - bill).ToString();
            }
            else
            {
                MessageBox.Show("No Payment made !");
            }
         

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
