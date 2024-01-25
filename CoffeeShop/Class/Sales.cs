using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    internal class Sales : Employees, IOrder
    {
        private List<DetailOrder> _orders;

        private Bartender bartender;
        private Order od;

        public event EventHandler OrderReceived;

        public List<DetailOrder> Orders { get => _orders; set => _orders = value; }
        internal Bartender Bartender { get => bartender; set => bartender = value; }
        internal Order Od { get => od; set => od = value; }

        public Sales(string IdVal, string NameVal, DateTime YobVal, DateTime hire, int salary) : base(IdVal, NameVal, YobVal, hire, salary)
        {
            Bartender.sub(this);
            Od.sub(this);
        }

        public void makeOrder(DetailOrder order)
        {
            Orders.Add(order);
        }

        public void publisher()
        {
            OrderReceived?.Invoke(this, new ProcessingOrder(Orders));
        }

    }
}
