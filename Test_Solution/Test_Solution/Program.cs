using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Solution.Products;

namespace Test_Solution
{
    class Program
    {

        static void Main(string[] args)
        {
            int closing1 = 1;
            int closing2 = 1;

            PRODUCT_TYPE type_of_product;
            string name;
            double price;
            DateTime expirationDate;
            DateTime productionDate;

            string color;
            string brand;
            string model;
            double weight;

            Cashier cashier = new Cashier();

            cashier.AddToCart(new Food("apples", "BrandA", 1.5, 2.45, new DateTime(2022,01,16), new DateTime(2022,01,16)));

            cashier.AddToCart(new Beverages("milk", "BrandM", 0.99, 3, new DateTime(2022,01,22), new DateTime(2022, 01, 14)));

            cashier.AddToCart(new Clothes("T-shirt", "BrandT", 15.99, 2, SIZE.M, "violet"));

            cashier.AddToCart(new Appliances("laptop", "BrandL", 2345, 1, "ModelL", new DateTime(2021,03,03), 1.125));

            /*
            do
            {
                Console.WriteLine("Add products: \n");

                while(closing1 != 0)
                {
                    Console.WriteLine("Enter what type of product do you want (1: food, 2: beverage, 3:clothes, 4:appliance)?\n");
                    //type_of_product = ;
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            type_of_product = PRODUCT_TYPE.FOOD;

                            Console.WriteLine("Enter name of product:\n");
                            name = Console.ReadLine();

                            Console.WriteLine("Enter price: \n");
                            price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter quantity: \n");
                            quantity = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter date time (in format year-month-day):\n");
                            expirationDate = Convert.ToDateTime(Console.ReadLine());

                            Console.WriteLine("Enter brand of product:\n");
                            brand = Console.ReadLine();

                            cashier.AddToCart(new Food(name, brand, price, quantity, expirationDate));

                            break;
                        case 2:
                            type_of_product = PRODUCT_TYPE.BEVERAGE;

                            Console.WriteLine("Enter name of product:\n");
                            name = Console.ReadLine();

                            Console.WriteLine("Enter price: \n");
                            price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter quantity: \n");
                            quantity = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter brand of product:\n");
                            brand = Console.ReadLine();

                            Console.WriteLine("Enter date time (in format year-month-day):\n");
                            expirationDate = Convert.ToDateTime(Console.ReadLine());

                            cashier.AddToCart(new Beverages(name, brand, price, quantity, expirationDate));

                            break;
                        case 3:
                            type_of_product = PRODUCT_TYPE.CLOTHES;

                            Console.WriteLine("Enter name of product:\n");
                            name = Console.ReadLine();

                            Console.WriteLine("Enter price: \n");
                            price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter quantity: \n");
                            quantity = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter date time (in format year-month-day):\n");
                            expirationDate = Convert.ToDateTime(Console.ReadLine());

                            Console.WriteLine("Enter brand of product:\n");
                            brand = Console.ReadLine();

                            Console.WriteLine("Enter color for clothes: \n");
                            color = Console.ReadLine();

                            cashier.AddToCart(new Clothes(name, brand, price, quantity, SIZE.L, color));

                            break;
                        case 4:
                            type_of_product = PRODUCT_TYPE.APPLIANCE;

                            Console.WriteLine("Enter name of product:\n");
                            name = Console.ReadLine();

                            Console.WriteLine("Enter price: \n");
                            price = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter quantity: \n");
                            quantity = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter date time (in format year-month-day):\n");
                            productionDate = Convert.ToDateTime(Console.ReadLine());

                            Console.WriteLine("Enter brand of product:\n");
                            brand = Console.ReadLine();

                            Console.WriteLine("Enter color for model: \n");
                            model = Console.ReadLine();

                            Console.WriteLine("Enter color for weight: \n");
                            weight = Convert.ToDouble(Console.ReadLine());

                            cashier.AddToCart(new Appliances(name, brand, price, quantity, model, productionDate, weight));

                            break;
                        default:
                            closing1 = 0;
                            break;
                    }                 
                }                          

                Console.WriteLine("Do you want to exit purchasing? (Enter 0 for exit)\n\n");

                closing2 = Convert.ToInt32(Console.ReadLine());

            } while (closing2 != 0);*/

            cashier.PrintAllPurchasedProducts();

            Console.ReadLine();
        }
    }
}
