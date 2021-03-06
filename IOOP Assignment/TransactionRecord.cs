﻿using System;
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
    public partial class TransactionRecord : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        SqlDataAdapter adapt;

        public TransactionRecord()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()//display data in data grid view
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [Transaction]", con);
            adapt.Fill(dt);
            DGV_TransactionRecord.DataSource = dt;
            con.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
