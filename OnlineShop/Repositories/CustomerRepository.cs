using OnlineShop.Interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public class CustomerRepository : IShopEntity<Customer, int, bool>
    {
        private ShopContext _context;

        public CustomerRepository()
        {
            _context = new ShopContext();
        }

        public void AddItem(Customer item)
        {
            if (!CustomerAlreadyInDb(item))
            {
                _context.Customer.Add(item);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("This customer already exists. Please enter other data");
            }
        }

        public void DeleteItem(int key)
        {
            var deletedCustomer = (from cust in _context.Customer
                                  where cust.CustomerId == key
                                  select cust).First();

            _context.Customer.Remove(deletedCustomer);
            _context.SaveChanges();
        }

        public Customer GetItem(int key)
        {
            var searchedItem = from item in _context.Customer
                               where item.CustomerId == key
                               select item;

            return searchedItem.Single();
        }

        public IEnumerable<Customer> GetItems()
        {
            var items = from cust in _context.Customer
                        select cust;

            return items.ToList();
        }

        public void UpdateItem(int key, Customer updatedItem)
        {
            throw new NotImplementedException();
        }

        public bool CustomerAlreadyInDb(Customer customer)
        {
            var newCustomersData = String.Format("{0}{1}{2}", customer.FirstName, customer.LastName, customer.Birthday);
            bool alreadyExists = false;
            var customers = from cust in _context.Customer
                            select cust;

            foreach(var cust in customers)
            {
                var customersData = String.Format("{0}{1}{2}", cust.FirstName, cust.LastName, cust.Birthday);

                if (newCustomersData == customersData)
                    alreadyExists = true;
            }

            return alreadyExists;
        }
    }
}
