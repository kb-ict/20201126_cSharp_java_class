using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Customer
    {
        string name;
        string tel;
        string address;
        string email;

        public Customer(string name, string address, string email, string tel)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
    }
}
