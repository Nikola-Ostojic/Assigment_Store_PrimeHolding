using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution
{
    public enum PRODUCT_TYPE {APPLIANCE, FOOD, BEVERAGE, CLOTHES};

    public class Product
    {

        #region Properties

        private PRODUCT_TYPE product_type;

        public PRODUCT_TYPE ProductType
        {
            get { return product_type; }
            set { product_type = value; }
        }

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

        protected double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        protected double quantity = 0;
                
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private double discount;

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private double discountedPrice;

        public double DiscountedPrice
        {
            get { return discountedPrice; }
            set { discountedPrice = value; }
        }

        private DateTime purchase_datetime;

        public DateTime PurchaseDateTime
        {
            get { return purchase_datetime; }
            set { purchase_datetime = value; }
        }

        #endregion


        public Product(string name, string brand, double price, double quantity)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
