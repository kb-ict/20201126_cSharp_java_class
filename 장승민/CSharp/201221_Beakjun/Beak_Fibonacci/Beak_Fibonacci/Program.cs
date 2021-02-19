using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beak_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(num));
        }
        static int fibonacci(int n)
        {

            if (n<0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2); 
            }
        }

    }
}
