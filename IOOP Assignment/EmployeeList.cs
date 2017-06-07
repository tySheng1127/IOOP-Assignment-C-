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
        List<Employee> le = new List<Employee>();
        Employee el;
        DatabaseManagement dm = new DatabaseManagement();

        public EmployeeList()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()//display data in data grid view
        {
            List<Employee> le = dm.ViewAllEmployee();
            foreach (Employee e in le)
            {
                object[] cellvalues = { e.EmployeeID, e.Username, e.Realname, e.IC, e.Gender, e.Dob, e.ContactNo, e.Address, e.Bankinfo, e.Password, e.Jobtitle };
                DGV_EmployeeList.Rows.Add(cellvalues);
            }
        }

        //Clear Data in Manage Employee 
        private void ClearData()
        {
            DGV_EmployeeList.Rows.Clear();
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
            this.Close();//close this form
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text!=""&&txt_username.Text!=""&&txt_Realname.Text!=""&&txt_NRIC.Text!=""&&cb_Gender.Text!=""&&txt_DOB.Text!=""&&txt_Contact.Text!=""&&txt_Address.Text!=""&&txt_Bank.Text!=""&&txt_Password.Text!=""&&cb_Jobtitle.Text!="")
            {
                Employee el = new Employee();
                el.EmployeeID = txt_ID.Text;
                el.Username = txt_username.Text;
                el.Realname = txt_Realname.Text;
                el.IC = txt_NRIC.Text;
                el.Gender = cb_Gender.Text;
                el.Dob =  txt_DOB.Text;
                el.ContactNo = txt_Contact.Text;
                el.Address = txt_Address.Text;
                el.Bankinfo = txt_Bank.Text;
                el.Password = txt_Password.Text;
                el.Jobtitle = cb_Jobtitle.Text;
                dm.UpdateEmployee(el);
                MessageBox.Show("EmployeeList is updated !");
                ClearData();
                DisplayData();

                
            }
            else
            {//if textbox is blank , this message will be shown
                MessageBox.Show("Please select the Employee to update !");
            }
        }

        private void DGV_EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when double click the data in data grid view, the item will pass to textbox
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
                el = new Employee(txt_ID.Text, txt_username.Text, txt_Realname.Text, txt_NRIC.Text, cb_Gender.Text, txt_DOB.Text, txt_Contact.Text, txt_Address.Text, txt_Bank.Text, txt_Password.Text, cb_Jobtitle.Text);
                try
                {
                    dm.InsertEmployee(el);//insert new employee to database
                    MessageBox.Show("New Employee is inserted !");
                    ClearData();
                    DisplayData();
                                       
                }
                catch
                {//if employee name aldready in the table , this message will be shown
                    MessageBox.Show("EmployeeID or Username already existed!");
                }
 
            }
            else
            {//if textbox is blank , this message will be shown
                MessageBox.Show("Please fill in all the details !");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
            {
                dm.DeleteEmployee(el);//delete the employee from database
                MessageBox.Show("Record deleted !");
                ClearData();
                DisplayData();
                
            }
            else
            {//if no employee selected, this message will be shown
                MessageBox.Show("Please select the item to delete !");
            }
        }


        
    }
}
