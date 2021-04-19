using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTest single1 = new SingleTest();
            Console.WriteLine(single1.getData());
            SingleTest single2 = new SingleTest();
            Console.WriteLine(single2.getData());

            Console.WriteLine(SingleTest.getInstance().getData());
            Console.WriteLine(SingleTest.getInstance().getData());


        }
    }

}
