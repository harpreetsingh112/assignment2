using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    public class Product
    {
        protected int productID;
        protected string productName;
        protected double price;
        protected double stock;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Product(int id, string name, double price, int stock)
        {
            this.productID =id;
            this.productName = name;
            this.price = price;
            this.stock = stock;
        }

        public void IncreaseStockMethod(int amount)
        {
            Stock = Stock + amount;
        }

        public void DecreaseStockMethod(int amount)
        {
            Stock = Stock - amount;
        }
    }
}
