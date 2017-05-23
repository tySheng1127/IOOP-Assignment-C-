using System;
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
    public partial class CashierForm : Form
    {
        int x;
        int total;
        LoginScreen loginScreen = new LoginScreen();

        public CashierForm(LoginScreen loginS)
        {
            InitializeComponent();
            loginScreen = loginS;
            TimeNow.Text = DateTime.Now.Date.ToString();
            x = 0;
            Random ran = new Random();
            total = 0;



        }

 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginScreen.ShowForm();
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Logged in as:");
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(btn_pen.Text);
        }

        private void btn_ruler_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(btn_ruler.Text);
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(btn_Eraser.Text);
        }

        private void btn_CD_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(btn_CD.Text);
        }

        private void btn_pendrive_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(btn_pendrive.Text);
        }

        private void btn_SDcard_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(btn_SDcard.Text);
        }

        private void btn_bread_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(btn_bread.Text);
        }



    }
}
