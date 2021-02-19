using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("문제 풀이 시작");
            //Console.WriteLine("1번 문제"  );
            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i%3==0)
            //    {
            //        //sum = sum+i
            //        sum += i;
            //    }


            //}
            //Console.WriteLine($"1부터 100까지 수 중의 3의 배수의 합은{sum}이다");

            //Console.WriteLine("2번 문제");
            //int inputsecond = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{inputsecond/60}분 {inputsecond%60}초");

            //Console.WriteLine("3번 문제");
            //Console.WriteLine("몇 층까지 쌓을 것인가?");
            //int floor = int.Parse(Console.ReadLine());

            //for (int i = 0; i < floor; i++)
            //{
            //    //공백 찍는 부분
            //    for (int j = floor; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //별 찍는 부분
            //    for (int k = 0; k < (2*i)+1; k++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine();
            //}
            //Console.WriteLine("4번 문제");
            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}x{j}={i*j}");
            //    }
            //}
            //Console.WriteLine("5번 문제");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("겨울");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("봄");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("여름");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("가을");
            //        break;


            //    default:
            //        Console.WriteLine("잘못된 값입니다.");
            //        break;
            //}

            //Console.WriteLine("6번 문제");
            //Console.WriteLine("x,y값을 입력하세요 =>");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("1사분면입니다.");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("2사분면입니다.");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("3사분면입니다.");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("4사분면입니다.");
            //}

            //Console.WriteLine("7번 문제");
            //string start = "1";
            //for (int i = 0; i < 20; i++)
            //{
            //    int count = 0;//각자리 숫자의 개수
            //    string end = "";//문자열을 누적시키는 변수
            //    Console.WriteLine($"{i+1}번째 : {start}"); //말하기
            //    char number = start[0];//내가 가리키는 숫자

            //    for (int j = 0; j < start.Length; j++)//읽어들이기
            //    {
            //        if (number!=start[j])
            //        {
            //            end = end + number + count; //end = ""+ '1' +1
            //            number = start[j];//가리키는 숫자를 다른 걸로 바꿈
            //            count = 1;//count는 1로 초기화, 왜냐면 다른 숫자가
            //                        //있어서 이 조건문으로 들어왔으니까
            //        }
            //        else
            //        {
            //            count++;
            //        }


            //    }
            //    end = end + number + count;
            //    start = end;
            //}

            //Console.WriteLine("8번 문제");
            //int input = int.Parse(Console.ReadLine());
            //int max = 1;//각 벌집의 최대값
            //int count = 0;//임의의 카운트 변수

            //while (true)
            //{
            //    max = max + (6 * count);
            //    if (max<input)
            //    {
            //        count++;
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{input}은 {count+1}번째 벌집에 속함");
            //        }
            //    break;


            Console.WriteLine("8번문제(이동준선생님ver.)");
            int input2 = int.Parse(Console.ReadLine()); //값을 입력받음

            //패턴정리

            /*
             * 벌집안의 수    벌집번호
             * 1            -1
             * 2~7          -2
             * 8~19         -3
             * 20~37        -4
             * 26~61        -5
            */

            if (input2==1)
            {
                Console.WriteLine("1번벌집");

            }
            else if (input2<=7)
            {
                Console.WriteLine("2번벌집");
            }
            else
            {
                int tempCount = 1;//임의의 카운트 변수
                int sub = 6; //뺄셈을 할 변수
                while (input2>0)
                {
                    input2 = input2 - sub;//input2-=sub;
                    sub = sub + 6;//sub+=6;
                    tempCount++;
                    if (input2<=1)
                    {
                        break;

                    }
                  
                }
                Console.WriteLine(tempCount);
            }


            }




        }




    }

