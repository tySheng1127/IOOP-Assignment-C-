using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class CurrentUser
    {
        string username, password;
        int InvoiceNo;

        public CurrentUser() {
            username = "";
            password = "";
            InvoiceNo = 1;
        }
        public string userName
        {
            set { username = value; }
            get { return username; }
        }
        public string passWord
        {
            set { password = value; }
            get { return password; }
        }
        public int IN
        {
            set { InvoiceNo = value; }
            get { return InvoiceNo; }
        }
    }
}
