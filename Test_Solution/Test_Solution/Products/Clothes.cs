using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution.Products
{
    public enum SIZE {XS, S, M, L, XL};

    public class Clothes : Product
    {
        private SIZE size;

        public SIZE Size
        {
            get { return size; }
            set { size = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Clothes(string name, string brand, int price, SIZE size, string color) : base(name, brand, price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.size = size;
            this.color = color;
        }
    }
}
