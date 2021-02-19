using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManageProgram
{
    class Customer
    {
        private String name;
        private String tel;
        private String address;
        Car car;
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


        public void printCustomerInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("전화번호: " + tel);
            Console.WriteLine("주소: " + address);
            car.printCarInfo();
        }
    }
}
