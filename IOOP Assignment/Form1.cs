﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public void ShowForm(){
            this.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "" ) {
                MessageBox.Show("Please fill in the username and password.", "Login Error");
            }
            else
            {
                // if username and password matches the database
                // direct them to new form
                    //if supervisor -> supervisor form
                    //else -> cashier form
                this.Hide();
                CashierForm cashierForm = new CashierForm(this);
                cashierForm.ShowDialog();
            }

        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
