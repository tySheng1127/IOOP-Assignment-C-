using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    class EmployeeManagement
    {
        public SqlConnection OpenConnection()
        {
            string connetionString = null;
            SqlConnection con;
            connetionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\User\\Desktop\\IOOP Assignment C#\\IOOP Assignment\\EmployeeList.mdf;Integrated Security=True";

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
    }
}
