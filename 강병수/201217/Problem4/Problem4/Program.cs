using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            for (num = 2; num <=9; num++)
            { 
            
            for (i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{num} x {i} = {i*num}");
                }
            }
        }

    }
    
}

