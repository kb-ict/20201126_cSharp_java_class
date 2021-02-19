using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beakjun_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num = int.Parse(Console.ReadLine());
            int fack = 1;
            for (int i = 1; i <= num; i++)
            {
                fack = fack * i;

            }
            Console.WriteLine(fack);*/
            Console.WriteLine(factorial(1));
        }
        static int factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}
