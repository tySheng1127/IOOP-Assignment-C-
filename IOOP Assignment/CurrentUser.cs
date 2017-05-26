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

        public CurrentUser() {
            username = "";
            password = "";
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
    }
}
