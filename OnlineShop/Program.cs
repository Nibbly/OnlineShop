using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopContext context = new ShopContext();

            Customer c = new Customer() { LastName = "Perry", FirstName = "John", Birthday = new DateTime(2000, 10, 10), Orders = new List<Order>() };


            List<Customer> custList = new List<Customer>()
            {
                new Customer() { LastName = "Perry", FirstName = "John", Birthday = new DateTime(2000, 10, 10), Orders = new List<Order>() },
                new Customer() { LastName = "Frazier", FirstName = "Beau", Birthday = new DateTime(1950, 12, 18), Orders = new List<Order>() },
                new Customer() { LastName = "Burton", FirstName = "Gregory", Birthday = new DateTime(1944, 06, 22), Orders = new List<Order>() },
                new Customer() { LastName = "Valdez", FirstName = "Wilhelmina", Birthday = new DateTime(1981, 09, 23), Orders = new List<Order>() },
                new Customer() { LastName = "Sargent", FirstName = "Germane", Birthday = new DateTime(1968, 02, 29), Orders = new List<Order>() },
                new Customer() { LastName = "Hines", FirstName = "Violet", Birthday = new DateTime(1971, 04, 07), Orders = new List<Order>() },
                new Customer() { LastName = "Steele", FirstName = "Dana", Birthday = new DateTime(1948, 10, 01), Orders = new List<Order>() },
                new Customer() { LastName = "Flowers", FirstName = "Alfonso", Birthday = new DateTime(2000, 02, 27), Orders = new List<Order>() },
                new Customer() { LastName = "Nash", FirstName = "Madeson", Birthday = new DateTime(1954, 09, 12), Orders = new List<Order>() },
                new Customer() { LastName = "Wilson", FirstName = "Karly", Birthday = new DateTime(1952, 04, 10), Orders = new List<Order>() },
            };

            List<Product> productList = new List<Product>()
            {
                new Product() { Name = "Computer", ProductType = ProductType.Electronics, Price = 2342.12, Description = "Ist Mist" },
                new Product() { Name = "Apple", ProductType = ProductType.Food, Price = 0.79, Description = "Auch Mist" },
                new Product() { Name = "Hammer", ProductType = ProductType.Living, Price = 9.99, Description = "Geht" },
                new Product() { Name = "Banana", ProductType = ProductType.Food, Price = 1.15, Description = "Solid" },
                new Product() { Name = "TV", ProductType = ProductType.Electronics, Price = 1542.19, Description = "Ok" },
                new Product() { Name = "Keyboard", ProductType = ProductType.Electronics, Price = 129.95, Description = "Sounds good" },
                new Product() { Name = "Stool", ProductType = ProductType.Living, Price = 74.95, Description = "If it fits it sits" },
                new Product() { Name = "Melon", ProductType = ProductType.Food, Price = 5.29, Description = "Delicious" }
            };

            foreach(var item in custList)
            {

            }

            Console.ReadKey();
        }

        static void DisplayAllCustomerData(Customer customer)
        {
            Console.WriteLine("Name: {0}, {1}", customer.LastName, customer.FirstName);
            Console.WriteLine("Birthday: {0}", customer.Birthday);
            Console.WriteLine();

            foreach (var order in customer.Orders)
            {
                Console.WriteLine("\tOrder #{0}: ", order.OrderID);
                foreach (var prod in order.Products)
                {
                    Console.WriteLine("\t\tObject: {0} Category: {1}", prod.Name, prod.ProductType);
                    Console.WriteLine("\t\tDescription: ");
                    Console.WriteLine("\t\t\t" + prod.Description);
                }
            }
        }
    }
}
