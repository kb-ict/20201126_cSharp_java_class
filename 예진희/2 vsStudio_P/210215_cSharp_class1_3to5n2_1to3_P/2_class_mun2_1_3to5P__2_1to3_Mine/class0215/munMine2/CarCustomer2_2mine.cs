using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munMine2
{
    class CarCustomer2_2mine
    {
        private string name;
        private string tel;
        private string address;
        private Car2_2mine car;

        public void CarCustomerSetInfo(string name, string tel, string address, Car2_2mine car)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.car = car;
        }
        public void printCustomerInfo()
        {
            Console.WriteLine($"- 고객명\t:{name}");
            Console.WriteLine($"- 전화번호\t:{tel}");
            Console.WriteLine($"- 주소\t\t:{address}");
            car.printCarInfo();
        }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
    }
}
