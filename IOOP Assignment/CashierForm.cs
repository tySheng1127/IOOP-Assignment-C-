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
        Employee cu = new Employee();
        List<Item> list = new List<Item>();
        double paid, bill,change;
        DateTime time = DateTime.Now;
        DatabaseManagement dm = new DatabaseManagement();


        public CashierForm(Employee currentUser)
        {
            InitializeComponent();
            cu = currentUser;
            x = 1;
            total = 0;

            rtbDetails.Text = cu.toString() + time; //show the current user's name and log in time who using the system
            selectedItem = new Item();
            Math.Round(change, 2);// round off the changes to 2 decimal places
          
        }

        public CashierForm()
        {
            // TODO: Complete member initialization
        }

 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            cmd = new SqlCommand("insert into LoggedSession(Username,LogoutTime) values(@name,@logout)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", cu.userName);
            cmd.Parameters.AddWithValue("@logout", time);
            cmd.ExecuteNonQuery();
            con.Close();
            // LoginScreen ls = new LoginScreen();
            this.Dispose();//back to login screen
            // ls.ShowDialog();
        }


        //details of the items sell
        private void btn_pen_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Pen       ";
            selectedItem.price = 3.00;
            selectedItem.GST = 0.18;
            selectedItem.product = "P01  ";
            selectedItem.pricewithoutGST = 2.82;
            selectedItem.rate = "S";
        }

        private void btn_ruler_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Ruler     ";
            selectedItem.price = 1.00;
            selectedItem.GST = 0.17;
            selectedItem.product = "P02  ";
            selectedItem.pricewithoutGST = 0.83;
            selectedItem.rate = "S";
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Eraser   ";
            selectedItem.price = 0.50;
            selectedItem.GST = 0.03;
            selectedItem.product = "P03  ";
            selectedItem.pricewithoutGST = 0.47;
            selectedItem.rate = "S";
        }

        private void btn_CD_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "CD        ";
            selectedItem.price = 3.50;
            selectedItem.GST = 0.21;
            selectedItem.product = "P04  ";
            selectedItem.pricewithoutGST = 3.29;
            selectedItem.rate = "S";
        }

        private void btn_pendrive_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Pendrive";
            selectedItem.price = 32;
            selectedItem.GST = 1.92;
            selectedItem.product = "P05  ";
            selectedItem.pricewithoutGST = 30.08;
            selectedItem.rate = "S";
        }

        private void btn_SDcard_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "SD Card";
            selectedItem.price = 64;
            selectedItem.GST = 3.84;
            selectedItem.product = "P06  ";
            selectedItem.pricewithoutGST = 60.16;
            selectedItem.rate = "S";
        }

        private void btn_bread_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Bread    ";
            selectedItem.price = 2.00;
            selectedItem.GST = 0.12;
            selectedItem.product = "P07  ";
            selectedItem.pricewithoutGST = 1.88;
            selectedItem.rate = "S";
        }

        private void btn_Biscuit_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Biscuit   ";
            selectedItem.price = 1.50;
            selectedItem.GST = 0.09;
            selectedItem.product = "P08  ";
            selectedItem.pricewithoutGST = 1.41;
            selectedItem.rate = "S";
        }

        private void btn_Candy_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Candy   ";
            selectedItem.price = 0.10;
            selectedItem.product = "P09  ";
            selectedItem.rate = "Z";

        }

        private void btn_Panadol_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Panadol";
            selectedItem.price = 12;
            selectedItem.product = "P10  ";
            selectedItem.rate = "Z";
        }

        private void btn_drink_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Drinks   ";
            selectedItem.price = 2.50;
            selectedItem.GST = 0.15;
            selectedItem.product = "P11  ";
            selectedItem.pricewithoutGST = 2.35;
            selectedItem.rate = "S";
        }

        private void btn_coffe_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Coffee   ";
            selectedItem.price = 1.70;
            selectedItem.product = "P12  ";
            selectedItem.rate = "Z";

        }

        private void btn_OJ_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Orange J";
            selectedItem.price = 4.00;
            selectedItem.GST = 0.24;
            selectedItem.product = "P13  ";
            selectedItem.pricewithoutGST = 3.76;
            selectedItem.rate = "S";
        }

        private void btn_milk_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Milk       ";
            selectedItem.price = 3.50;
            selectedItem.product = "P14  ";
            selectedItem.rate = "Z";
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "A4 Paper";
            selectedItem.price = 0.30;
            selectedItem.GST = 0.02;
            selectedItem.product = "P15  ";
            selectedItem.pricewithoutGST = 0.28;
            selectedItem.rate = "S";
        }

        private void btn_flower_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Flower   ";
            selectedItem.price = 1.50;
            selectedItem.GST = 0.09;
            selectedItem.product = "P16  ";
            selectedItem.pricewithoutGST = 1.41;
            selectedItem.rate = "S";
        }

        private void btn_sandwich_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Sandwich";
            selectedItem.price = 5.50;
            selectedItem.GST = 0.33;
            selectedItem.product = "P17  ";
            selectedItem.pricewithoutGST = 5.17;
            selectedItem.rate = "S";
        }

        private void btn_colour_Click(object sender, EventArgs e)
        {
            selectedItem = new Item();
            selectedItem.description = "Colour   ";
            selectedItem.price = 9.50;
            selectedItem.GST = 0.57;
            selectedItem.product = "P18  ";
            selectedItem.pricewithoutGST = 8.93;
            selectedItem.rate = "S";
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            //delete the listbox and transaction sales history 
            if (lbItem.SelectedIndex >= 0)
            {
                cmd = new SqlCommand("delete from [Transaction] where ProductID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id",list[lbItem.SelectedIndex].product);
                cmd.ExecuteNonQuery();
                con.Close();
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
                // display the item that customer buy in list box 
                selectedItem.quantity = int.Parse(txtQuantity.Text);
                lbItem.Items.Add(x.ToString() + "                   "+selectedItem.product+"                   " + selectedItem.description + "                     " + txtQuantity.Text +"          "+ selectedItem.price);
                dm.InsertTransaction(selectedItem,cu);
                x++;
                total += selectedItem.price * int.Parse(txtQuantity.Text);
                rtbTotal.Text = total.ToString();//total up the price and show in rich text box 
                list.Add(selectedItem);
                selectedItem = new Item();

            }

        }

        private void btn_Changes_Click(object sender, EventArgs e)
        {
            if (txtPrepaid.Text != "")
            {//calculate the changes 
                 paid = double.Parse(txtPrepaid.Text);
                 bill = double.Parse(rtbTotal.Text);
                 if (paid >= bill)
                 {
                     change = paid - bill;
                     txtChange.Text = change.ToString();
                 }
                 else
                 {//if insufficient cash paid by customer , system will give warning
                     MessageBox.Show("Insufficient Cash for payment !");
                 }

            }
            else
            {//if no payment made, changes cant be calculated
                MessageBox.Show("No Payment made !");
            }
         

        }

        private void btn_GReceipt_Click(object sender, EventArgs e)
        {
            
            if (txtChange.Text == "")
            {//if no payment made, no receipt cant be generated
                MessageBox.Show("Payment must be made before generate receipt!");
            }
            else{
                //generate receipt
                Receipt rc = new Receipt(cu,list, paid, bill);
                cu.IN++;
                cleardata();
                rc.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //digital clock in system
            lb_TimeNow.Text = DateTime.Now.ToString("yyyy/MM/dd  " + "HH:mm:ss");
        }

        private void btn_Transactionlist_Click(object sender, EventArgs e)
        {
            //show transaction history by clicking this button
            TransactionList tl = new TransactionList(cu);
            tl.ShowDialog();
        }

        private void btn_CReport_Click(object sender, EventArgs e)
        {
            //show report by clicking this button
            Report rp = new Report();
            rp.ShowDialog();
        }

        private void cleardata()
        {
            //clear the listed item in list box 
            lbItem.Text = "";
        }

    }
}
