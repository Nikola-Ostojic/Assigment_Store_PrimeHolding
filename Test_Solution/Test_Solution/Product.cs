using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution
{
    public class Product
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        protected int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string name, string brand, int price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
        }
    }
}
