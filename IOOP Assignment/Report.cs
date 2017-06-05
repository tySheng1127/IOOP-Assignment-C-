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
    public partial class Report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;MultipleActiveResultSets=true");
        SqlDataAdapter adapt;
        SqlCommand cmd;

        public Report()
        {
            InitializeComponent();
            DisplayData();
            
        }

        private void DisplayData()//display data in data grid view
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Report", con);
            adapt.Fill(dt);
            DGV_report.DataSource = dt;
            cmd = new SqlCommand("select sum(TotalSales) from Report", con);
           SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()){
                txt_TotalSales.Text = dr.GetValue(0).ToString();
            }
            cmd = new SqlCommand("select sum(GSTPayable) from Report", con);
            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                txt_TotalPayable.Text = drr.GetValue(0).ToString();
            }
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
