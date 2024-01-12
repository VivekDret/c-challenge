using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Entity
{ 
        class Clothing : Product
        {
            private string size;
            private string color;
            public Clothing() //def const
            {

            }
            public Clothing(int productId, string productName, string description, decimal price, int quantityInStock, string _type, string _size, string _color) : base(productId, productName, description, price, quantityInStock, _type)
            {
                size = _size;
                color = _color;
            }

            //getter setter
            public string Size
            {
                get { return size; }
                set { size = value; }
            }

            public string Color
            {
                get { return color; }
                set { color = value; }
            }


        }

    
}
