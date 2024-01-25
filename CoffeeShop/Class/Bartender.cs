using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    internal class Bartender : Employees
    {
        public Bartender(string IdVal, string NameVal, DateTime YobVal, DateTime hire, int salary) : base(IdVal, NameVal, YobVal, hire, salary)
        {

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
        public void Message(string items)
        {
            MessageBox.Show($"Đã Hết {items}");
        }
    }
}
