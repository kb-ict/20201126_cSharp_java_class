using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCar
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass car = new CarClass();
            car.Company = "기아";
            car.Color = "블랙";
            car.Model = "K7";
            car.Price = "사천만원";
            car.printCarInfo();
            int age = int.Parse(Console.ReadLine());
        }
    }
}
