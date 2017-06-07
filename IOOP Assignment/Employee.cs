using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Employee : CurrentUser
    {
        string ID, realname, NRIC, gender,dob, address, bankinfo, jobtitle,contactnumber, username, password;

        public Employee()
        {
            ID = "E00";
            realname = "realname";
            NRIC = "123456121234";
            gender = "Male";
            dob = "1/1/2017";
            address = "Kuala Lumpur";
            bankinfo = "12345678890";
            jobtitle = "supervisor";
            contactnumber = "0123456789";
        }

        public Employee(string EmployeeID, string Username, string Realname, string IC, string Gender, string Dob, string ContactNo, string Address, string Bankinfo, string Password, string Jobtitle) : base (Username, Password)
        {
            ID = EmployeeID;
            realname = Realname;
            NRIC = IC;
            gender = Gender;
            dob = Dob;
            contactnumber = ContactNo;
            address = Address;
            bankinfo = Bankinfo;
            jobtitle = Jobtitle;
            username = Username;
            password = Password;
        }

 
        public string EmployeeID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Realname
        {
            get { return realname; }
            set { realname = value; }
        }

        public string IC
        {
            get { return NRIC; }
            set { NRIC = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Bankinfo
        {
            get { return bankinfo; }
            set { bankinfo = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Jobtitle
        {
            get { return jobtitle; }
            set { jobtitle = value; }
        }

        public string ContactNo
        {
            get { return contactnumber; }
            set { contactnumber = value; }
        }

        public override string toString()
        { //inherit & polymorphism here
            return base.toString() + "\nEmployeeID: " + EmployeeID + "\nJob title: " + Jobtitle + "\n";
        }

    }

   
}
