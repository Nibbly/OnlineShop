using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public enum ProductType
    {
        Electronics = 1,
        Food = 2,
        Living = 3
    }

    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ProductType ProductType { get; set; }

        //Fk to Order
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

    }
}
