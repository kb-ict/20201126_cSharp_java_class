using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1번 문제 ●*/
               int hap = 0;
               for (int i = 0; i <100; i++)
               {
                   hap += (i + 1);

               }
               Console.WriteLine("1. 100까지 합: "+hap+"\n");


               /*
                2번 문제 ●*/
               Console.WriteLine("입력값을 분(min)으로 변환");
               int min = int.Parse(Console.ReadLine());
               int bun = min / 60;
               int cho = min % 60;
               Console.WriteLine($"2. {bun}분 {cho}초"+"\n");
               




            /*
             * 
             * 3.문제
             * 별나무 ㅡ.ㅡ
             * 
             */

            /*Console.Write("몇단을 쌓을거냐 ? => ");
            int d = int.Parse(Console.ReadLine());

            for (int i = 0; i < d; i++)
            {
                for (int j = 0; j < (i+1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/



            /*
             *4. 문제 ●*/
            Console.WriteLine("4. 곱하기할 숫자 입력");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"{a}*{i+1}= {a*(i+1)}");
            }



            /** 5. 문제● */
 

            Console.WriteLine("달을 입력해라");
            int dal = int.Parse(Console.ReadLine());

            switch (dal)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            


            /*
             * 
             * 6번 문제 ● */

            Console.Write("x값 입력 => ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y값 입력 => ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine(4);
            }
            else
            {
                Console.WriteLine("해당하는 값이 없습니다.");
            }

            /*
             * 못 푼거 : 3, 7, 8 
             * 7번 문제 */

            /*for (int z = 0; z < 20; z++)
            {
                // (z + 1); 번째까지가 20번째 숫자 및 반복횟수
                Console.WriteLine($"{z+1}번째 수열 : {z+1}");
                if ((z + 1).)
                {

                }
                
            }*/



        }

    }

}