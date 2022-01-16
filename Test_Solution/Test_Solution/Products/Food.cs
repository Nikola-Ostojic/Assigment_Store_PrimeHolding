using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution.Products
{
    public class Food : Product
    {
        private DateTime expirationDate;

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }


        public Food(string name, string brand, double price, double quantity, DateTime expirationDate, DateTime purchaseDate) : base(name, brand, price, quantity)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
            this.PurchaseDateTime = purchaseDate;
            this.ProductType = PRODUCT_TYPE.FOOD;
        }


    }
}
