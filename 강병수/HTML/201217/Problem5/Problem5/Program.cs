using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("달 입력: ");
            int month = int.Parse(Console.ReadLine());

            if(month == 2 || month == 3 || month == 4)
            {
                Console.WriteLine("봄입니다.");
            }
            else if(month == 5 || month == 6 || month == 7)
            { 
                Console.WriteLine("여름입니다."); 
            }
            else if (month == 8 || month == 9 || month == 10)
            {
                Console.WriteLine("가을입니다.");
            }
            else if (month == 11 || month == 12 || month == 1)
            {
                Console.WriteLine("겨울입니다.");
            }
        }
    }
}
