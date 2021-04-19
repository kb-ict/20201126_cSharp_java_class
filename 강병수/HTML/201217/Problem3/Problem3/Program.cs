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
            Console.Write("입력: ");
            int num = int.Parse(Console.ReadLine());
            int i, k;
            for(i = 1; i<=num ; i++) {
                Console.Write(" ");
                for (k = 1; k <= i; k++)
                {
                    
                    Console.Write("*");
                }
                    
                    Console.Write("\n");
            }
           
                
         }
    }
}
