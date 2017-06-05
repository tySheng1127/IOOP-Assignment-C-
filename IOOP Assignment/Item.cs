using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    public class Item
    {
        string productID;
        string itemDescription;
        double itemPrice;
        int itemQuantity;
        double itemGST;
        double OriginalPrice;
        string category;
     


        public Item() {
            itemDescription = "error";
            itemPrice = 3.00;
            quantity = 0;
            itemGST = 0;
            product = "error";
            OriginalPrice = 2.00;
            category = "S";
    

        }


        public string product
        {
            get { return productID;}
            set {productID = value;}
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
        public double GST 
        {
            get { return itemGST; }
            set { itemGST = value; ;} 
        }
        public double pricewithoutGST
        {
            get { return OriginalPrice; }
            set { OriginalPrice = value; }
        }
        public string rate
        {
            get { return category; }
            set { category = value; }
        }
        
    }
}
