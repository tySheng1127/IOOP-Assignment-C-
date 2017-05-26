using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Item
    {
        string itemDescription;
        double itemPrice;
        int itemQuantity;
        public Item() {
            itemDescription = "error";
            itemPrice = 3.00;
            quantity = 0;
        }

        public string description
        {
            get { return itemDescription; }
            set {itemDescription = value; }
        }

        public double price
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        public int quantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }
    }
}
