using OnlineShop.Interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Repositories
{
    public class ProductRepository : IShopEntity<Product, int>
    {
        public void AddItem(Product item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int key)
        {
            throw new NotImplementedException();
        }

        public Product GetItem(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(int key, Product updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
