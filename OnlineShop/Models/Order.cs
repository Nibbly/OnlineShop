using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    class Order
    {
        public int OrderID { get; set; }

        //FK Customer
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
