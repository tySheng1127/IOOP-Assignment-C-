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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public CurrentStock()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()//display data in data grid view
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Product", con);
            adapt.Fill(dt);
            DGV_Stock.DataSource = dt;
            con.Close();
        }

        //Clear Data in Product Manage 
        private void ClearData()
        {
            txt_ID.Text = "";
            txt_Name.Text = "";
            cb_category.Text = "";
            txt_Price.Text = "";
            txt_Amount.Text = "";
            txt_Reorder.Text = "";
        }  

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_Name.Text != "" && cb_category.Text != "" && txt_Price.Text != "" && txt_Amount.Text != "" && txt_Reorder.Text != "")
            {
                cmd = new SqlCommand("insert into Product(ProductID,Name,Category,Price,StockAmount,ReorderThreshold) values(@id,@name,@category,@price,@amount,@reorder)",con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@category", cb_category.Text);
                cmd.Parameters.AddWithValue("@price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@amount", txt_Amount.Text);
                cmd.Parameters.AddWithValue("@reorder", txt_Reorder.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product is inserted !");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please fill in all the details!");  
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_Name.Text != "" && cb_category.Text != "" && txt_Price.Text != "" && txt_Amount.Text != "" && txt_Reorder.Text != "")
            {
                cmd = new SqlCommand("update Product set Name=@name,Category=@category,Price=@price,StockAmount=@Amount,ReorderThreshold=@reorder where ProductID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@category", cb_category.Text);
                cmd.Parameters.AddWithValue("@price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@amount", txt_Amount.Text);
                cmd.Parameters.AddWithValue("@reorder", txt_Reorder.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product is updated !");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select the item to update !");
            }
        }

        //when double click the data in data grid view, the item will pass to textbox
        private void DGV_Stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = DGV_Stock.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = DGV_Stock.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_category.Text = DGV_Stock.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Price.Text = DGV_Stock.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Amount.Text = DGV_Stock.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Reorder.Text = DGV_Stock.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                cmd = new SqlCommand("delete from Product where ProductID=@ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted !");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select the item to delete !");
            }
           
        }

    }
}
