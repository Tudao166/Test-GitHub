using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    internal class Employees : Person
    {
        private DateTime hireDate;
        private int salary;
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
        public int Salary { get => salary; set => salary = value; }

        public Employees(string IdVal, string NameVal, DateTime YobVal, DateTime hire, int salary) : base(IdVal, NameVal, YobVal)
        {
            this.HireDate = hire;
            this.Salary = salary;
        }

        
    }
}
