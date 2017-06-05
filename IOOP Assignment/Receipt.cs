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
    public partial class Receipt : Form
    {
        List<Item> list = new List<Item>();
        CurrentUser cu = new CurrentUser();
        int total;
        double amounts,amountz,tax;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlCommand cmd;


        public Receipt(CurrentUser currentuser,List<Item> listFromCashierForm, double paid, double bill)
        {
            total = 0;
            cu = currentuser;
            list = listFromCashierForm;
            InitializeComponent();
            lb_currentdt.Text = DateTime.Now.ToString();
            txt_InvoiceNo.Text = "I00" + cu.IN.ToString();
      
            rtb_receipt.Text = "Description                   unit             Unit Price                 Total  \n";
            for (int i = 0; list.Count() > i; i++) {
                rtb_receipt.Text += list[i].description + "                        " + list[i].quantity.ToString() + "                  " + list[i].price.ToString() + "                    " + list[i].price * list[i].quantity+"   "+list[i].rate.ToString()+"\n";
                 total += list[i].quantity;
                 if (list[i].rate.ToString() == "S")
                 {
                     amounts += list[i].pricewithoutGST*list[i].quantity;
                     tax += amounts*0.06;
                     
                 }
                 else
                 {
                     amountz += list[i].price*list[i].quantity;
                 }
            }
  
            rtb_Change.Text = "Item Count: "+total.ToString()+"\nTotal Sales Inclusive GST @6%: " + bill.ToString()+"\nCash: "+paid.ToString()+"\nBalance:" + (paid - bill).ToString();
            rtb_GST.Text = "GST Summary                      Amount                     Tax(RM)  \n" + "S = 6%                                   " + amounts.ToString() + "                            " + Math.Round(tax,2).ToString() + "\nZ = 0%                                   " + amountz.ToString() + "                            0.00";
            lb_Cashier.Text = "Cashier : " + cu.userName;
            cmd = new SqlCommand("insert into Report(InvoiceNo,TotalSales,Date,GSTPayable)values(@IN,@Sales,@date,@gst)",con);
            con.Open();
            cmd.Parameters.AddWithValue("@IN", txt_InvoiceNo.Text);
            cmd.Parameters.AddWithValue("@Sales", bill.ToString());
            cmd.Parameters.AddWithValue("@date", lb_currentdt.Text);
            cmd.Parameters.AddWithValue("@gst", Math.Round(tax, 2));
            cmd.ExecuteNonQuery();
            con.Close();

        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

    }
}
