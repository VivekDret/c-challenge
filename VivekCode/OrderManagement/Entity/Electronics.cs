using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Entity
{
    class Electronics : Product
    {
        private string brand;
        private int warrantyPeriod;

        public Electronics() //def const
        {

        }
        public Electronics(int productId, string productName, string description, decimal price, int quantityInStock, string _type, string _brand, int _warrantyPeriod) : base(productId, productName, description, price, quantityInStock, _type) //para const
        {
            brand = _brand;
            warrantyPeriod = _warrantyPeriod;
        }
        //getter setter

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int WarrantyPeriod
        {
            get { return warrantyPeriod; }
            set { warrantyPeriod = value; }
        }

    }
}
