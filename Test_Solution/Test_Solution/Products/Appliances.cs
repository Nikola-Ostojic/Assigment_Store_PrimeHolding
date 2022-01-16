using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution.Products
{
    public class Appliances : Product
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private DateTime production_date;

        public DateTime ProductionDate
        {
            get { return production_date; }
            set { production_date = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Appliances(string name, string brand, double price, double quantity, string model, DateTime production_date, double weight) : base(name, brand, price, quantity)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.quantity = quantity;
            this.model = model;
            this.production_date = production_date;
            this.weight = weight;

            this.ProductType = PRODUCT_TYPE.APPLIANCE;
        }
    }
}
