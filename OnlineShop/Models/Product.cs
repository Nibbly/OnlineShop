using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    enum ProductType
    {
        Electronics = 1,
        Food = 2,
        Living = 3
    }

    class Product
    {
        public int ProductID { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }

    }
}
