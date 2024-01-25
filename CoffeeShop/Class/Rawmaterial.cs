using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Rawmaterial
    {
        private string id;
        private string name;
        private int price;
        private double quantity; // đơn vị kg

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

    }
}
