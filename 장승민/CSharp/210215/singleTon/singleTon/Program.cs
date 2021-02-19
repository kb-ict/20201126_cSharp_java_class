using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTest st1 = new SingleTest();
            SingleTest st2 = new SingleTest();
            Console.WriteLine(st1.getData());
            Console.WriteLine(st2.getData());
        }
    }
}
