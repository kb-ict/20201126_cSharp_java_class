using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());
            int a;
            a = n % 2;
            if (a==0)
            {
                Console.WriteLine("짝수입니다");
            }
            else
            {
                Console.WriteLine("홀수입니다");
            }
        }
    }
}
