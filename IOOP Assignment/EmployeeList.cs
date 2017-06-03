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
    public partial class EmployeeList : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public EmployeeList()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()//display data in data grid view
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Employee", con);
            adapt.Fill(dt);
            DGV_EmployeeList.DataSource = dt;
            con.Close();
        }

        //Clear Data in Manage Employee 
        private void ClearData()
        {
            txt_ID.Text = "";
            txt_username.Text = "";
            txt_Realname.Text = "";
            txt_NRIC.Text = "";
            cb_Gender.Text = "";
            txt_DOB.Text = "";
            txt_Contact.Text = "";
            txt_Address.Text = "";
            txt_Bank.Text = "";
            txt_Password.Text = "";
            cb_Jobtitle.Text = "";
        }  

       

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text!=""&&txt_username.Text!=""&&txt_Realname.Text!=""&&txt_NRIC.Text!=""&&cb_Gender.Text!=""&&txt_DOB.Text!=""&&txt_Contact.Text!=""&&txt_Address.Text!=""&&txt_Bank.Text!=""&&txt_Password.Text!=""&&cb_Jobtitle.Text!="")
            {
                cmd = new SqlCommand("update Employee set username=@usrname, realName=@name, NRIC=@IC,Gender=@gender,DoB=@dob,ContactNumber=@contact,Address=@address,BankInfo=@bank,password=@pw,Jobtitle=@title where EmployeeID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.Parameters.AddWithValue("@usrname", txt_username.Text);
                cmd.Parameters.AddWithValue("@name", txt_Realname.Text);
                cmd.Parameters.AddWithValue("@IC", txt_NRIC.Text);
                cmd.Parameters.AddWithValue("@gender", cb_Gender.Text);
                cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txt_DOB.Text));
                cmd.Parameters.AddWithValue("@contact", txt_Contact.Text);
                cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@bank", txt_Bank.Text);
                cmd.Parameters.AddWithValue("@pw", txt_Password.Text);
                cmd.Parameters.AddWithValue("@title", cb_Jobtitle.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand("update Loginlist set password=@pw,JobTitle=@title where username = @name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_username.Text);
                cmd.Parameters.AddWithValue("@pw", txt_Password.Text);
                cmd.Parameters.AddWithValue("@title", cb_Jobtitle.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("EmployeeList is updated !");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please select the Employee to update !");
            }
        }

        private void DGV_EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txt_ID.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_username.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Realname.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_NRIC.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_Gender.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_DOB.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Contact.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_Address.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_Bank.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_Password.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[9].Value.ToString();
            cb_Jobtitle.Text = DGV_EmployeeList.Rows[e.RowIndex].Cells[10].Value.ToString();
            
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_username.Text != "" && txt_Realname.Text != "" && txt_NRIC.Text != "" && cb_Gender.Text != "" && txt_DOB.Text != "" && txt_Contact.Text != "" && txt_Address.Text != "" && txt_Bank.Text != "" && txt_Password.Text != "" && cb_Jobtitle.Text != "")
            {
                cmd = new SqlCommand("insert into Employee(EmployeeID,username,realName,NRIC,Gender,DoB,ContactNumber,Address,BankInfo,password,JobTitle) values(@id,@usrname,@name,@IC,@gender,@dob,@contact,@address,@bank,@pw,@title)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.Parameters.AddWithValue("@usrname", txt_username.Text);
                cmd.Parameters.AddWithValue("@name", txt_Realname.Text);
                cmd.Parameters.AddWithValue("@IC", txt_NRIC.Text);
                cmd.Parameters.AddWithValue("@gender", cb_Gender.Text);
                cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txt_DOB.Text));
                cmd.Parameters.AddWithValue("@contact", txt_Contact.Text);
                cmd.Parameters.AddWithValue("@address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@bank", txt_Bank.Text);
                cmd.Parameters.AddWithValue("@pw", txt_Password.Text);
                cmd.Parameters.AddWithValue("@title", cb_Jobtitle.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("EmployeeID already exists!");
                }
                con.Close();

                cmd = new SqlCommand("insert into Loginlist(username,password,JobTitle) values(@name,@pw,@title)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_username.Text);
                cmd.Parameters.AddWithValue("@pw", txt_Password.Text);
                cmd.Parameters.AddWithValue("@title", cb_Jobtitle.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Employee is inserted !");
                    DisplayData();
                    ClearData();
                }
                catch
                {
                    MessageBox.Show("Username already exists!");
                }
                con.Close();

                
            }
            else
            {
                MessageBox.Show("Please fill in all the details !");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                cmd = new SqlCommand("delete from Employee where EmployeeID=@id",con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand("delete from Loginlist where username=@name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_username.Text);
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
