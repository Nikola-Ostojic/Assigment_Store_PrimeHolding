using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Solution.Products;

namespace Test_Solution
{
    public class Cashier : Shop
    {
        private List<Product> products;

        private int number_of_food = 0;
        private int number_of_beverages = 0;
        private int number_of_clothes = 0;
        private int number_of_appliance = 0;

        public Cashier()
        {
            products = new List<Product>();
        }


        public void AddToCart(Product p)
        {

            products.Add(p);

            Cashier.CountDiscount(p);

            Console.WriteLine("Product " + p.Name + " added to cart");
        }

        public void DismissCart()
        {
            products.Clear();

            Console.WriteLine("Cart deleted");
        }

        private static void CountDiscount(Product p)
        {
            switch (p.ProductType)
            {
                case PRODUCT_TYPE.APPLIANCE:
                    Appliances a = (Appliances)p;
                    if (a.Price > 999 && (a.PurchaseDateTime.DayOfWeek >= DayOfWeek.Saturday))
                    {
                        a.Discount = 0.05;
                        a.DiscountedPrice = 0.05 * (a.Price * a.Quantity);
                    }
                    break;
                case PRODUCT_TYPE.CLOTHES:
                    Clothes c = (Clothes)p;
                    if (c.PurchaseDateTime.DayOfWeek < DayOfWeek.Saturday)
                    {
                        c.Discount = 0.1;
                        c.DiscountedPrice = 0.1 * (c.Price * c.Quantity);
                    }
                    break;
                case PRODUCT_TYPE.FOOD:
                    Food f = (Food)p;
                    if (f.PurchaseDateTime.CompareTo(f.ExpirationDate) == 0)                     
                    {
                        f.Discount = 0.5;
                        f.DiscountedPrice = 0.5 * (f.Price * f.Quantity);                       
                    }
                    else if (f.PurchaseDateTime.CompareTo(f.ExpirationDate) >= 5)
                    {
                        f.Discount = 0.1;
                        f.DiscountedPrice = 0.1 * (f.Price * f.Quantity);
                    }
                    break;
                case PRODUCT_TYPE.BEVERAGE:
                    Beverages b = (Beverages)p;
                    if (b.PurchaseDateTime.CompareTo(b.ExpirationDate) == 0)                      
                    {
                        
                        b.Discount = 0.5;
                        b.DiscountedPrice = 0.5 * (b.Price * b.Quantity);
                    }
                    else if (b.PurchaseDateTime.CompareTo(b.ExpirationDate) >= 5)
                    {
                        b.Discount = 0.1;
                        b.DiscountedPrice = 0.1 * (b.Price * b.Quantity);
                    }
                    break;

            }     
        }

        public void PrintAllPurchasedProducts()
        {
            double sum = 0;
            double discounted_sum = 0;

            Console.WriteLine("Date: " + products[0].PurchaseDateTime.ToString() + "\n");
            Console.WriteLine("--Products--\n\n");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name + " " + products[i].Brand + "\n");
                Console.WriteLine(products[i].Quantity.ToString() + " x " + products[i].Price.ToString() + "$" + " = " + (products[i].Quantity * products[i].Price).ToString() + "$" + "\n");

                if (products[i].DiscountedPrice != 0)
                Console.WriteLine("#discount " + products[i].Discount * 100 + "% " + " -" + products[i].DiscountedPrice + "$");

                Console.WriteLine("\n\n");

                sum += (products[i].Price * products[i].Quantity);
                discounted_sum += products[i].DiscountedPrice;
            }

            Console.WriteLine("\n-----------------------------------------------------\n");

            Console.WriteLine("SUBTOTAL: " + sum + "$" + "\n");
            Console.WriteLine("DISCOUNT: -" + discounted_sum + "$" + "\n\n");

            Console.WriteLine("TOTAL: " + (sum - discounted_sum).ToString() + "\n\n\n\n\n");
            
        }
    }
}
