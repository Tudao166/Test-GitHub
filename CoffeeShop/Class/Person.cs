using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal abstract class Person
    {
        private string id;
        private string name;
        private DateTime yob;
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Yob { get => yob; set => yob = value; }
        public Person(string IdVal, string NameVal, DateTime YobVal)
        {
            this.Yob = YobVal;
            this.Id = IdVal;
            this.Name = NameVal;
        }
    }
}
