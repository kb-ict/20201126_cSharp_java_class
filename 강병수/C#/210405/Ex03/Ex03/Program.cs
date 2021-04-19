using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("Hello, My Name is " + input);

            // 숫자 입력 받기

            int number = int.Parse(Console.ReadLine()); // 정수 입력
            double num = double.Parse(Console.ReadLine()); // 실수 입력
            Console.WriteLine(number/num);
        }
    }
}
