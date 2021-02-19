using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Dab_20201218
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("문제풀이 시작");
             Console.WriteLine("1번 문제");
             int sum = 0;

             for (int i = 0; i < 100; i++)
             {
                 if (i%3==0)
                 //sum = sum + i;
                 sum += i;
             }
             Console.WriteLine($"1부터 100까지의 수 중 3의 배수 합은 " +
                 $"{sum}이다.");


             //-----------------------------------------------------------------
             Console.WriteLine("2번 문제");
             int inputSecond = int.Parse(Console.ReadLine());
             Console.WriteLine($"{inputSecond/60}분 {inputSecond%60}초");

             //-----------------------------------------------------------------
             Console.WriteLine("3번 문제");
             Console.WriteLine("몇층 쌓을것인가?");
             int floor = int.Parse(Console.ReadLine());

             for (int i = 0; i < floor; i++) //전체층 출력
             {
                 //공백 찍기
                 for (int j = floor; j > i; j--) //각층을 출력(공백)
                 {
                     Console.Write('-');
                 }

                 for (int k = 0; k < (2*i)+1; k++) //*은 2n+1
                 {
                     Console.Write('*');

                 }
                 Console.WriteLine();

                 //별 찍기

             }
             //-----------------------------------------------------------------

             Console.WriteLine("4번 문제");

             for (int i = 2; i < 10; i++)    //2단 
             {
                 for (int j = 1; j < 10; j++)   //x1~x9
                 {
                     Console.WriteLine($"{i}x{j}={i * j}");
                 }
             }*/

            //--- 1~4번 다중 주석처리 -----------------------------------------


            //-----------------------------------------------------------------
            /*
             * Console.WriteLine("5번 문제");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;

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

                default:
                    Console.WriteLine("잘못된 값입니다.");
                    break;

            }
            */

            //-----------------------------------------------------------------


            /*
               Console.WriteLine("6번 문제");
               int input1 = int.Parse(Console.ReadLine());
               int input2 = int.Parse(Console.ReadLine());

               if (input1>0&&input2>0)
               {
                   Console.WriteLine("1"); // 한줄만 있으면 중괄호 안써도 됨
               }
               else if (input1<0&&input2>0)
               {
                   Console.WriteLine(2);
               }
               else if (input1 < 0 && input2 > 0)
               {
                   Console.WriteLine(3);
               }
               else if (input1 > 0 && input2 < 0)
               {
                   Console.WriteLine(4);
               }
               else
               {
                   Console.WriteLine("0");
               }
   */
            //-----------------------------------------------------------------
            /*
            
            Console.WriteLine("7번 문제");
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0;      //각 자리 숫자의 갯수
                string end = "";    //문자열 누적시키는 변수
                Console.WriteLine($"{i + 1}번째: {start}");   //말하기
                char number = start[0]; //내가 가리키는 숫자.

                for (int j = 0; j < start.Length; j++)        //수열 읽어들이기
                {
                    if (number!=start[j])
                    {
                        end = end + number + count;           //end = ""+'1'+1
                        number = start[j];                    //가리키는 숫자를 다른 걸로 바꿈
                        count = 1;                            //count는 1로 초기화. 왜냐면 다른숫자가 
                                                              //있어서 이 조건문으로 들어와서
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }

*/

            //--- ㅇㅎㅊ -----------------------------------------

/*
            Console.WriteLine("8번 문제 (ㅇㅎㅊ)");

            *//*    6    6*2    6*3
             *   ↓     ↓     ↓
             * 1 --- 7 --- 19 --- 37 
             *//*

            int input = int.Parse(Console.ReadLine());
            int max = 1;     //각 벌집의 최대값
            int counter = 0; //임의의 카운트 변수
            while (true)
            {
                max = max + (6 * counter);
                if(max<input)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{input}은 {counter+1}번째 벌집에 속함");
                break;

            }
*/

            //-----------------------------------------------------------------

            Console.WriteLine("8번 문제 (선생님)");
            int input_dj = int.Parse(Console.ReadLine()); //값을 입력받음

            //패턴 정리
            //1       - 1번 벌집 - 각 벌집 최대값간의 차이
            //2~7     - 2번 벌집 - 6
            //8~19    - 3번 벌집 - 12
            //20~31   - 4번 벌집 - 18
            //34~61   - 5번 벌집 - 24

            int input = int.Parse(Console.ReadLine());


            if (input_dj == 1)
                Console.WriteLine("1번 벌집");
            else if(input_dj <= 7) //input이 2부터 7인 경우
                Console.WriteLine("2번 벌집");
            else
            {
                int tempCount = 1; //임의의 카운트 변수
                    int sub = 6; //뺄샘을 할 변수
                while(input_dj>0)
                {
                    input = input - sub; //input -= sub;
                    sub = sub + 6;//sub+=6;
                        tempCount++;
                    if (input_dj <= 1)
                        break;
                }
                //Console.WriteLine(tempCount.ToString());
                Console.WriteLine(tempCount);
            }
            

        }
    }
}
