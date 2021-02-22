using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
#if false
            #region 3의 배수의 합
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.Write(sum);
            #endregion
            #region 시간
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a / 60}분 {a % 60}초");
            #endregion
            #region 피라미드
            int count = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < count; i++)
            {
                for (int j = i; j < count; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            #region 구구단
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            #endregion
            #region 계절
            int month = int.Parse(Console.ReadLine());
            if (month >= 3 && month <= 5)
                Console.WriteLine("봄");
            else if (month >= 6 && month <= 8)
                Console.WriteLine("여름");
            else if (month >= 9 && month <= 11)
                Console.WriteLine("가을");
            else if (month >= 12 && month <= 2)
                Console.WriteLine("겨울");
            #endregion
            #region 사분면
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pos = 0;
            if (x > 0 && y > 0)
                pos = 1;
            else if (x < 0 && y > 0)
                pos = 2;
            else if (x < 0 && y < 0)
                pos = 3;
            else if (x > 0 && y < 0)
                pos = 4;
            Console.WriteLine(pos);
            #endregion  
#endif
        }
    }
}
