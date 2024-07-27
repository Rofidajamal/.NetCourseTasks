using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Association_composition
{
    internal class OrderItem
    {
        // Order Item has a Product
        public int Id { get; set; }

        public Product Product { get; set; } // Association because it's mandatory

        public decimal Price { get; set; }

        public int Quantaty { get; set; }

        OrderItem (Product product)
        {
            Product = product;
        }


    }
}
