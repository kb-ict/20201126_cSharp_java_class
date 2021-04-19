using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Customer
    {
        private string name;
        private string tel;
        private string address;

        public Customer(string name, string tel, string address)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }

        public void showCustomerInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("번호: " + tel);
            Console.WriteLine("주소: " + address);
            Console.WriteLine("====================================");
        }
    }
}
