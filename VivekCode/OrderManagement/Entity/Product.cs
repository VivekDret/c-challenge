using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Entity
{
    class Product
    {
        private int productId;
        private string productName;
        private string description;
        private decimal price;
        public int quantityInStock;
        public string Type;


        public Product() //def const
        {

        }

        public Product(int productId, string productName, string description, decimal price, int quantityInStock, string _type) //para const
        {

            product_id = product_id;
            ProductName = productName;
            Description = description;
            Price = price;
            type = _type;
        }
        //get set
        public int product_id
        {
            get { return productId; }
            set { productId = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string type
        {
            get { return Type; }
            set { Type = value; }
        }




    }
}
