using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    class DatabaseManagement
    {
        public SqlConnection OpenConnection()
        {
            string connetionString = null;
            SqlConnection con;
            connetionString = "Data Source = (LocalDB)\\v11.0;AttachDbFilename=E:\\IOOP-Assignment-C-\\IOOP Assignment\\Database.mdf;Integrated Security=True";
            //Data Source=(LocalDB)\v11.0;AttachDbFilename="E:\IOOP-Assignment-C-\IOOP Assignment\Database.mdf";Integrated Security=True
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

        public void ViewAll()
        {
            SqlCommand command;
            string sql = null;
            SqlConnection con = OpenConnection();
            sql = "Select * from Product";

            try
            {
                command = new SqlCommand(sql, con);
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    Console.WriteLine(sqlReader.GetValue(0) + " \t " + sqlReader.GetValue(1) + " \t " + sqlReader.GetValue(2));  //you must know how many column
                }
                sqlReader.Close();
                command.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! \n" + ex.ToString());
            }
        }

        public void InsertRecord(CurrentStock cs)
        {
           
        }
    }
}
