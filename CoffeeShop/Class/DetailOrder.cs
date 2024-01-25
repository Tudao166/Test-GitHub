using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class DetailOrder
    {
        private string _id;
        private string _name;
        private double _price;
        private int _quantity;
        private DateTime _created;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public DateTime Created { get => _created; set => _created = value; }

        public DetailOrder(string Id, string Name, double Price, int Quantity, DateTime created)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Id = Id;
            this.Created = created;
        }

    }
}
