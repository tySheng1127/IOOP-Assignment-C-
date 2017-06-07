using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    class DatabaseManagement
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter sda;
        public SqlConnection OpenConnection()//test and open the connection
        {
            string connetionString = null;
 
            connetionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            try
            {
                con.Open();
                Console.WriteLine("\nConnection Open ! ");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection !:\n " + ex.ToString());
            }
            return con;
        }

        public List<Employee> ViewAllEmployee()// add the data from Employee table to a employee list 
        {
            List<Employee> le = new List<Employee>(); 

            con = OpenConnection();
            string query = "select * from Employee";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee newel = new Employee(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                le.Add(newel);
            }
            reader.Close();
            cmd.Dispose();
            con.Close();

            return le;
 
        }

        public void InsertEmployee(Employee el)//insert the data into database Employee table
        {

            string query ="insert into Employee(EmployeeID,username,realName,NRIC,Gender,DoB,ContactNumber,Address,BankInfo,password,JobTitle) values(@id,@usrname,@name,@IC,@gender,@dob,@contact,@address,@bank,@pw,@title)";

            con = OpenConnection();
            cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@id", el.EmployeeID);
            cmd.Parameters.AddWithValue("@usrname", el.Username);
            cmd.Parameters.AddWithValue("@name", el.Realname);
            cmd.Parameters.AddWithValue("@IC", el.IC);
            cmd.Parameters.AddWithValue("@gender", el.Gender);
            cmd.Parameters.AddWithValue("@dob", el.Dob);
            cmd.Parameters.AddWithValue("@contact", el.ContactNo);
            cmd.Parameters.AddWithValue("@address", el.Address);
            cmd.Parameters.AddWithValue("@bank", el.Bankinfo);
            cmd.Parameters.AddWithValue("@pw", el.Password);
            cmd.Parameters.AddWithValue("@title", el.Jobtitle);
            cmd.ExecuteNonQuery(); 

            string query2 = "insert into Loginlist(username,password,JobTitle) values(@username,@pw,@title)";
            cmd = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@username", el.Username);
            cmd.Parameters.AddWithValue("@pw", el.Password);
            cmd.Parameters.AddWithValue("@title", el.Jobtitle);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void DeleteEmployee(Employee el)//delete data from Employee table
        {
   
            con = OpenConnection();
            string query = "delete from Employee where EmployeeID=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", el.EmployeeID);
            cmd.ExecuteNonQuery();

            string query2 = "delete from Loginlist where username=@name";
            cmd = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@name",el.Username);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }


        public void UpdateEmployee(Employee el)//update the data in Employee table based on the selected EmployeeID
        {

            string query = "update Employee set username=@usrname, realName=@name, NRIC=@IC,Gender=@gender,DoB=@dob,ContactNumber=@contact,Address=@address,BankInfo=@bank,password=@pw,Jobtitle=@title where EmployeeID=@id";

            con = OpenConnection();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", el.EmployeeID);
            cmd.Parameters.AddWithValue("@usrname", el.Username);
            cmd.Parameters.AddWithValue("@name", el.Realname);
            cmd.Parameters.AddWithValue("@IC", el.IC);
            cmd.Parameters.AddWithValue("@gender", el.Gender);
            cmd.Parameters.AddWithValue("@dob", el.Dob);
            cmd.Parameters.AddWithValue("@contact", el.ContactNo);
            cmd.Parameters.AddWithValue("@address", el.Address);
            cmd.Parameters.AddWithValue("@bank", el.Bankinfo);
            cmd.Parameters.AddWithValue("@pw", el.Password);
            cmd.Parameters.AddWithValue("@title", el.Jobtitle);
            cmd.ExecuteNonQuery();

            string query2 = "update Loginlist set password=@pw,JobTitle=@title where username = @name";
            cmd = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@name", el.Username);
            cmd.Parameters.AddWithValue("@pw", el.Password);
            cmd.Parameters.AddWithValue("@title", el.Jobtitle);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void InsertStock(Stock s)//insert the data into database product table 
        {

            string query = "insert into Product(ProductID,Name,Category,Price,StockAmount,ReorderThreshold) values(@id,@name,@category,@price,@amount,@reorder)";

            con = OpenConnection();
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id",s.product);
            cmd.Parameters.AddWithValue("@name", s.Pname);
            cmd.Parameters.AddWithValue("@category", s.Pcategory);
            cmd.Parameters.AddWithValue("@price", s.Pprice);
            cmd.Parameters.AddWithValue("@amount",s.Pamount);
            cmd.Parameters.AddWithValue("@reorder",s.Preorder);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void UpdateStock(Stock s,CurrentUser cu)//update the data in database product table and insert the purchase of item to transaction history
        {

            string query = "update Product set Name=@name,Category=@category,Price=@price,StockAmount=StockAmount + @Amount,ReorderThreshold=@reorder where ProductID=@id";
            con = OpenConnection();
            cmd = new SqlCommand(query, con);
            
            cmd.Parameters.AddWithValue("@id", s.product);
            cmd.Parameters.AddWithValue("@name", s.Pname);
            cmd.Parameters.AddWithValue("@category", s.Pcategory);
            cmd.Parameters.AddWithValue("@price",s.Pprice);
            cmd.Parameters.AddWithValue("@amount", s.Pamount);
            cmd.Parameters.AddWithValue("@reorder", s.Preorder);
            cmd.ExecuteNonQuery();
            string query2 = "insert into [Transaction](ProductID,Quantity,Price,EmployeeInCharge,Type) values(@product,@quantity,@price,@incharge,'Purchase')";
            cmd = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@product", s.product);
            cmd.Parameters.AddWithValue("@quantity", s.Pamount);
            cmd.Parameters.AddWithValue("@price", s.Pprice);
            cmd.Parameters.AddWithValue("@incharge", cu.userName);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

        }

        public void DeleteStock(Stock s)//delete the product data from database
        {
                con = OpenConnection();
                string query = "delete from Product where ProductID=@ID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", s.product);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
        }

        public List<Stock> ViewAllStock()//add data from product table to a list 
        {
            List<Stock> ls = new List<Stock>();

            con = OpenConnection();
            string query = "select * from Product";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Stock news = new Stock(reader.GetString(0), reader.GetString(1), reader.GetString(2),reader.GetDouble(3), reader.GetInt32(4), reader.GetInt32(5));
                ls.Add(news);
            }
            reader.Close();
            cmd.Dispose();
            con.Close();

            return ls;

        }

        public void Login(Employee cu)//function of login button
        {

            con = OpenConnection();
            cmd = new SqlCommand("select * from Loginlist where username='" + cu.userName + "'and password='" + cu.passWord + "'and JobTitle='Supervisor'", con);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);//insert data to a virtual table
            if (dt.Rows.Count > 0)//determine whether the data is inside the table or not 
            {
                DateTime time = DateTime.Now;
                cmd = new SqlCommand("insert into LoggedSession(Username,LoginTime) values(@name,@login)", con);//record the login data to database
                cmd.Parameters.AddWithValue("@name", cu.userName);
                cmd.Parameters.AddWithValue("@login", time);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select EmployeeID,Jobtitle from Employee where username ='" + cu.userName + "'", con);
                DataTable employeeStuff = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(employeeStuff);
                cu.EmployeeID = employeeStuff.Rows[0][0].ToString();
                cu.Jobtitle = employeeStuff.Rows[0][1].ToString();
               
                con.Close();
                SupervisorForm sf = new SupervisorForm(cu);//switch to supervisor form
                sf.ShowDialog();
            }
            else
            {//if the data is not inside the table, following code will execute
                cmd = new SqlCommand("select username,password from Loginlist where username='" +cu.userName + "'and password='" + cu.passWord + "'", con);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    DateTime time = DateTime.Now;
                    cmd = new SqlCommand("insert into LoggedSession(Username,LoginTime) values(@name,@login)", con);//record the login data to database
                    cmd.Parameters.AddWithValue("@name",cu.userName);
                    cmd.Parameters.AddWithValue("@login", time);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("select EmployeeID,Jobtitle from Employee where username ='" + cu.userName + "'",con);
                    DataTable employeeStuff = new DataTable();
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(employeeStuff);
                    cu.EmployeeID = employeeStuff.Rows[0][0].ToString();
                    cu.Jobtitle = employeeStuff.Rows[0][1].ToString();
                    con.Close();
                    CashierForm cf = new CashierForm(cu);//show cashier form
                    cf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");//if data input do not match any data in database
                }

            }
        }


        public void Logout(CurrentUser cu)//record the log out time and data to database
        {
            DateTime time = DateTime.Now;
            cmd = new SqlCommand("insert into LoggedSession(Username,LogoutTime) values(@name,@logout)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", cu.userName);
            cmd.Parameters.AddWithValue("@logout", time);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertTransaction(Item selectedItem,CurrentUser cu)//record this transaction in transaction history and deduct the stock amount in stock
        {
            con = OpenConnection();
            cmd = new SqlCommand("update Product set StockAmount = StockAmount - @amount where ProductID = '" + selectedItem.product + "'", con);
            con = OpenConnection();
            cmd.Parameters.AddWithValue("@amount", selectedItem.quantity);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("insert into [Transaction](ProductID,Quantity,Price,EmployeeInCharge,Type) values(@product,@quantity,@price,@incharge,'Sales')", con);
            cmd.Parameters.AddWithValue("@product", selectedItem.product);
            cmd.Parameters.AddWithValue("@quantity", selectedItem.quantity);
            cmd.Parameters.AddWithValue("@price", selectedItem.price);
            cmd.Parameters.AddWithValue("@incharge", cu.userName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteTransaction(Stock s)// delete the record in product table
        {

            con = OpenConnection();
            string query = "delete from Product where ProductID=@ID";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", s.Pname);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

    }
}
