using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Customer : Car
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }

        public Customer(string name, string tel, string address,
            string model, string color, int year, string company)
            : base(model, color, year, company)
        {
            Name = name;
            Tel = tel;
            Address = address;
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine($"고객명: {Name}");
            Console.WriteLine($"전화번호: {Tel}");
            Console.WriteLine($"주소: {Address}");
            PrintCarInfo();
        }
    }
}
