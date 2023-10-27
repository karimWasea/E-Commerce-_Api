using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.OrderAggregate
{
    //related to the productItemOrdered and order class
    public class OrderItem : BaseEntity
    {
        public OrderItem()
        {
        }

        public OrderItem(ProductItemOrdered itemOrdered, decimal price, int quantity, decimal offer)
        {
            this.itemOrdered = itemOrdered;
            Price = price;
            Quantity = quantity;
            Offer = offer;
        }

        public ProductItemOrdered itemOrdered { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Offer { get; set; }


    }
}
