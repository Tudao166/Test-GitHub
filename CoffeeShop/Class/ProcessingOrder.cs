using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class ProcessingOrder : EventArgs
    {
        private List<DetailOrder> detailOrders;
        public ProcessingOrder(List<DetailOrder> x)
        {
            this.DetailOrders = x;
        }

        internal List<DetailOrder> DetailOrders { get => detailOrders; set => detailOrders = value; }
    }
}
