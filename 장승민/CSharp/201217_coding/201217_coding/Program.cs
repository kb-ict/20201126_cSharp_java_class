using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201217_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문제 1번
            //  Console.WriteLine("1. 1부터 100까지의 합을 구하되, 3의 배수에 해당하는 것만 구해라.");
            //  int sum=0;
            //  for (int i = 0; i < 100; i++)
            //  {
            //      if ((i+1)%3==0)
            //      {
            //          sum = sum + (i + 1);
            //      }
            //  }
            //  Console.WriteLine(sum);

            //  Console.WriteLine();

            //  //문제 2번
            //  Console.WriteLine("2.숫자를 입력받고 다음과 같은 출력을 보여주세요.");
            //  Console.Write("입력 : ");
            //  int sec = int.Parse(Console.ReadLine());
            //  Console.WriteLine($"출력 : {sec/60}분 {sec%60}초");

            //  Console.WriteLine();

            //  //문제 3번
            //  Console.WriteLine("3. 피라미드 출력");
            //  Console.Write("피라미드 층수를 입력하시오 => ");
            //  int floor = int.Parse(Console.ReadLine());
            //  for (int j = 1; j < floor+1; j++)
            //  {
            //      for (int i = 0; i < floor-j; i++)
            //      {
            //          Console.Write(" ");
            //      }
            //      for (int g = 0; g < (j*2)-1; g++)
            //      {
            //          Console.Write("*");
            //      }
            //      Console.WriteLine();



            //  }
            //  //문제 4번
            //  Console.WriteLine();

            //  Console.WriteLine("4.구구단 출력");

            //  for (int a = 1; a < 9; a++)
            //  {
            //      for (int b = 0; b < 9; b++)
            //      {
            //          Console.WriteLine($"{a + 1}x{b + 1}={(a + 1) * (b + 1)}");
            //      }
            //  }
            //  Console.WriteLine();
            //  //문제 5번
            //  Console.WriteLine("5.계절 출력 프로그램");
            //  Console.Write("현재 달을 입력하시오=>");
            //  int month = int.Parse(Console.ReadLine());
            //  switch (month)
            //  {
            //      case 12:
            //      case 1:
            //      case 2:
            //              Console.WriteLine("겨울");
            //          break;
            //      case 3:
            //      case 4:
            //      case 5:
            //          Console.WriteLine("봄");
            //          break;
            //      case 6:
            //      case 7:
            //      case 8:
            //          Console.WriteLine("여름");
            //          break;
            //      case 9:
            //      case 10:
            //      case 11:
            //          Console.WriteLine("가을");
            //          break;

            //  }
            //  Console.WriteLine();
            //  //문제 6번
            //  Console.WriteLine("6. 4분면 문제");
            //  Console.WriteLine("x,y값을 입력하세요 =>");
            //  int x = int.Parse(Console.ReadLine());
            //  int y = int.Parse(Console.ReadLine());

            //  if (x>0&&y>0)
            //  {
            //      Console.WriteLine("1사분면입니다.");
            //  }
            //  else if(x<0&&y>0)
            //  {
            //      Console.WriteLine("2사분면입니다.");
            //  }
            //  else if (x < 0 && y < 0)
            //  {
            //      Console.WriteLine("3사분면입니다.");
            //  }
            //  else if (x < 0 && y < 0)
            //  {
            //      Console.WriteLine("4사분면입니다.");
            //  }

            Console.WriteLine();
            //문제 7번
            int soo = int.Parse(Console.ReadLine());
            int cnt = 0;
            int sooyear = 0;
            for (int i = 0; i < 3; i++)
            {
                if (sooyear)
                {

                }
                if (soo == 1)
                {
                    cnt++;
                    
                }
               

            }



            Console.WriteLine();
            //문제 8번
           // int eight = int.Parse(Console.ReadLine());

        }

    }
}
