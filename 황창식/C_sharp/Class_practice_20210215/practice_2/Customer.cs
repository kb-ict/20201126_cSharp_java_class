using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    class Customer
    {
        private string name;
        private string tel;
        private string address;
        private Car car;

        public Customer(string name, string tel, string address, Car car)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.car = car;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        internal Car Car { get => car; set => car = value; }

        public void printCustomerInfo()
        {
            Console.WriteLine("----- 고객/차량 정보 -----");
            Console.WriteLine("고객 이름 : " + name);
            Console.WriteLine("고객 전화 : " + tel);
            Console.WriteLine("고객 주소 : " + address);
            car.printCarInfo();
        }
    }
}
