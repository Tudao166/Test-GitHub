using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Product
    {
        private string type;
        private string name;
        private string id;
        private double price;
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public double Price { get => price; set => price = value; }
    }
}
