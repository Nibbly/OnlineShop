using OnlineShop.Interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public class CustomerRepository : IShopEntity<Customer, int>
    {
        private ShopContext _context;

        public CustomerRepository()
        {
            _context = new ShopContext();
        }

        public void AddItem(Customer item)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void UpdateItem(int key, Customer updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
