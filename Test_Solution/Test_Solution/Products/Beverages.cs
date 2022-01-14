using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution.Products
{
    public class Beverages : Product
    {
        private DateTime expirationDate;

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public Beverages(string name, string brand, int price, DateTime expirationDate) : base(name, brand, price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.expirationDate = expirationDate;
        }
    }
}
