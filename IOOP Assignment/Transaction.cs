using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Transaction
    {
        string PID, EInCharge, Type;
        int QTY;
        double price;

        public Transaction()
        {
            PID = "P00";
            EInCharge = "Admin";
            Type = "Sales";
            QTY = 1;
            price = 1.00;
        }

        public void Transaction1(string productID, string EmployeeInCharge, string type, int quantity, double Price)
        {
            PID = productID;
            EInCharge = EmployeeInCharge;
            Type = type;
            QTY = quantity;
            price = Price;
        }

        public string productID
        {
            get { return PID; }
            set { PID = value;}
        }

        public string EmployeeInCharge
        {
            get { return EInCharge; }
            set { EInCharge = value; }
        }

        public string type
        {
            get { return Type; }
            set { Type = value; }
        }

        public int quantity
        {
            get { return QTY; }
            set { QTY = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
