using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_carClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.showCarInfo();

            Car car2 = new Car("현대", "화이트", "코나", "이천오백만원");
            car2.showCarInfo();
            
        }
    }
}
