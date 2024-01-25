using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CoffeeShop
{
    internal class Admin : Person
    {
        private string account;
        private string password;
        DatabaseAdmin admin;
        public Admin(string IdVal, string NameVal, DateTime YobVal, string account, string pass) : base(IdVal, NameVal, YobVal)
        {
            this.Account = account;
            this.Password = pass;
        }

        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }

        private void insert(Employees employees)
        {
            admin.insert(employees);
        }
        
    }
}
