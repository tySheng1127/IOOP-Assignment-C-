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
    public partial class CurrentStock : Form
    {
        
        List<Stock> ls = new List<Stock>();
        CurrentUser cu = new CurrentUser();
        DatabaseManagement dm = new DatabaseManagement();
        Stock s;

        public CurrentStock(CurrentUser currentuser)
        {
            InitializeComponent();
            cu = currentuser;
            DisplayData();
        }

        private void DisplayData()//display data in data grid view
        {
            ls = dm.ViewAllStock();
            foreach (Stock s in ls)
            {
                object[] cellvalues = { s.product,s.Pname,s.Pcategory,s.Pprice,s.Pamount,s.Preorder};
                DGV_Stock.Rows.Add(cellvalues);
            }
        }


        //Clear Data in Product Manage 
        private void ClearData()
        {
            DGV_Stock.Rows.Clear();
            txt_ID.Text = "";
            txt_Name.Text = "";
            cb_category.Text = "";
            txt_Price.Text = "";
            txt_Amount.Text = "";
            txt_Reorder.Text = "";
        }  

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();//close this form
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // all textbox must be filled
            if (txt_ID.Text != "" && txt_Name.Text != "" && cb_category.Text != "" && txt_Price.Text != "" && txt_Amount.Text != "" && txt_Reorder.Text != "")
            {
                s = new Stock(txt_ID.Text,txt_Name.Text,cb_category.Text,double.Parse(txt_Price.Text),int.Parse(txt_Amount.Text),int.Parse(txt_Reorder.Text));
                try
                {
                    dm.InsertStock(s); 
                    MessageBox.Show("Product is inserted !");
                    ClearData();
                    DisplayData();
                    
                }
                catch
                {//if product name already existed, this message will be shown
                    MessageBox.Show("Product already existed !");
                }

            }
            else
            {//if any textbox is empty, this message will be shown
                MessageBox.Show("Please fill in all the details!");  
            }
        }

       
        
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                //delete the item 
                dm.DeleteStock(s);
                MessageBox.Show("Record deleted !");
                ClearData();
                DisplayData();
                
            }
            else
            {// if no item selected , this message will be shown
                MessageBox.Show("Please select the item to delete !");
            }
           
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_Name.Text != "" && cb_category.Text != "" && txt_Price.Text != "" && txt_Amount.Text != "" && txt_Reorder.Text != "")
            {
                //update the product 
                Stock s = new Stock();
                s.product = txt_ID.Text;
                s.Pname = txt_Name.Text;
                s.Pcategory = cb_category.Text;
                s.Pprice = double.Parse(txt_Price.Text);
                s.Pamount = int.Parse(txt_Amount.Text);
                s.Preorder = int.Parse(txt_Reorder.Text);
                dm.UpdateStock(s, cu);
                MessageBox.Show("Product is updated !");
                ClearData();
                DisplayData();

            }
            else
            {
                // if no item selected , this message will be shown
                MessageBox.Show("Please select the item to update !");
            }
        }

       
        private void DGV_Stock_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//when double click the data in data grid view, the item will pass to textbox
        {
            txt_ID.Text = DGV_Stock.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = DGV_Stock.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_category.Text = DGV_Stock.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Price.Text = DGV_Stock.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Amount.Text = DGV_Stock.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Reorder.Text = DGV_Stock.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            List<string> reorderList = new List<string>();
            foreach (Stock s in ls)
            {
                if(s.Pamount <= s.Preorder){
                    reorderList.Add(s.Pname);
                }
            }
            string combindedString = string.Join("\n", reorderList.ToArray());
            MessageBox.Show(combindedString, "Items to reorder");
        }

    }
}
