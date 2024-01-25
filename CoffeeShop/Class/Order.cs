using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Order
    {
        private List<DetailOrder> _orders;
        public List<DetailOrder> Orders { get => _orders; set => _orders = value; }

        public void makeOrder(DetailOrder order)
        {
            Orders.Add(order);
        }

        public void sub(Sales sales)
        {
            sales.OrderReceived += makeProduct;
        }


        public void makeProduct(object obj, EventArgs e)
        {
            ProcessingOrder processingOrder = (ProcessingOrder)e;
            List<DetailOrder> detailOrders = processingOrder.DetailOrders;

        }
    }
}
