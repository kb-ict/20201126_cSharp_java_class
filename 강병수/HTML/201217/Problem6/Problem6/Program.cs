using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 값 입력: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 값 입력: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine("1사분면");
            }
            else if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine("2사분면");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("3사분면");
            }
            else if (num1 > 0 && num2 < 0)
            {
                Console.WriteLine("4사분면");
            }
            else if (num1 == 0 && num2 == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
