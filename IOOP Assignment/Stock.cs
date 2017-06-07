using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Stock
    {
        string productID, Name, Category;
        double Price;
        int Amount, Reorder;

        public Stock()
        {
            productID = "P00";
            Name = "Item";
            Category = "GST";
            Price = 1.00;
            Amount = 20;
            Reorder = 20;

        }

        public Stock(string product, string Pname, string Pcategory, double Pprice, int Pamount, int Preorder)
        {
            productID = product;
            Name = Pname;
            Category = Pcategory;
            Price = Pprice;
            Amount = Pamount;
            Reorder = Preorder;
        }

        public string product
        {
            get { return productID; }
            set { productID = value; }
        }

        public string Pname
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Pcategory
        {
            get { return Category; }
            set { Category = value; }
        }

        public double Pprice
        {
            get { return Price; }
            set { Price = value; }
        }

        public int Pamount
        {
            get { return Amount; }
            set { Amount = value; }
        }

        public int Preorder
        {
            get { return Reorder; }
            set { Reorder = value; }
        }
    }
}
