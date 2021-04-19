using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hap = 0;
            for(int i = 1; i < 101; i++)
            {
                if(i%3 == 0)
                {
                  hap = hap + i;
                }
            }
            Console.WriteLine($"{hap}");
        }

    }
}
