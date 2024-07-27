using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Association_composition
{
    internal class Order
    {
        //Order has an Item
        public int Id { get; set; }
        public string BuyerEmail { get; set; }

        public decimal SubTotal { get; set; }

        public OrderItem [] items { get; set; }

        public Order (string _Email, OrderItem[] items)
        {
            BuyerEmail = _Email;
            this.items = items;
        }


    }
}
