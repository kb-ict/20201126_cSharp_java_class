using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Problem 1 Answer");
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("1부터 100까지 중 3의 배수인 숫자의 합은 " + sum + " 이다.");


            Console.WriteLine("Problem 2 Answer");
            int Second = int.Parse(Console.ReadLine());
            Console.WriteLine($"{ Second / 60}분 {Second % 60}초");

            Console.WriteLine("Problem 3 Answer");
            Console.Write("숫자 입력");
            int pyramid = int.Parse(Console.ReadLine());

            for (int i = 0; i < pyramid; i++) //전체 층을 출력
            {
                //공백을 찍는 부분
                for (int j = pyramid; j > i; j--) //각 층을 출력(공백)
                {
                    Console.Write(' ');
                }

                //별을 찍는 부분 //각 층을 출력(별)
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine("Problem 4 Answer");
            for (int i = 2; i < 10; i++) //2단부터 9단
            {
                for (int j = 1; j < 10; j++) //x1부터 x9까지
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
            Console.WriteLine("Problem 5 Answer");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("숫자를 잘못 입력하였습니다.");
                    break;
            }
            Console.WriteLine("Problem 6 Answer");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else //둘 다 0인 경우
                Console.WriteLine("0");

            Console.WriteLine("Problem 7 Answer");
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0; //각 자리의 숫자의 개수
                string end = ""; //문자열을 누적시키는 변수
                Console.WriteLine($"{i + 1}번쨰 : {start}"); //말하기
                char number = start[0]; //내가 가리키는 숫자

                for (int j = 0; j < start.Length; j++) //읽어들이기
                {
                    if (number != start[j])
                    {
                        end = end + number + count; //end = ""+ '1' +1
                        number = start[j]; //가리키는 숫자를 다른 걸로 바꿈
                        count = 1; //count는 1로 초기화. 왜냐하면 다른 숫자가 있어서 이 조건문으로 들어왔으니까
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }
            Console.WriteLine("Problem 8 Answer");
            int input = int.Parse(Console.ReadLine());
            int max = 1; //각 벌집의 최대값
            int counter = 0; //임의의 카운트 변수
            while (true)
            {
                max = max + (6 * counter);
                if (max < input)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{input}은 {counter + 1}번째 벌집에 속함");

                break;
            }
            Console.WriteLine("Problem 8 Answer_Alternative");
            int input2 = int.Parse(Console.ReadLine());
            //패턴 정리

            //벌집안의 수    벌집번호    각 벌집 최대값의 차이
            //1             -1번 벌집 - 6
            //2~7           -2번 벌집 - 12
            //8~19          -3번 벌집 - 18
            //20~37         -4번 벌집 - 24
            //38~61         -5번 벌집 - 30

            if (input2 == 1)
                Console.WriteLine("1번 벌집");
            else if (input2 <= 7)
                Console.WriteLine("2번 벌집");
            else
            {
                int tempcount = 1;
                int sub = 6;
                while (input2 > 0)
                {
                    input2 = input2 - sub; //input -= sub; 
                    sub = sub + 6; //sub+=6;
                    tempcount++;
                    if (input2 <= 1)
                        break;
                }
                //Console.WriteLine(tempcount.ToString());
                Console.WriteLine(tempcount);
            }
        }
    }
}
