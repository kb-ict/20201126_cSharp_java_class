using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.printCarInfo();

            Car c1 = new Car("현대", "그레이", "삼천만원", "G80");
            c1.printCarInfo();
        }
    }
}
