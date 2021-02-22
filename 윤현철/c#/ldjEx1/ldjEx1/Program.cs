using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ldjEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3번 문제");
            Console.WriteLine("층수를 입력 하세요");
            int floor = int.Parse(Console.ReadLine());
            for (int i = 0; i < floor; i++)
            {
                for (int j = i; j < floor-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2*i)+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("7번문제");
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0;// 각 자리 숫자의 개수
                string end ="";//문자열을 누적시키는 변수
                Console.WriteLine($"{i+1}번째 : {start}");
                char number = start[0];//내가 가리키는 숫자
                for (int j = 0; j < start.Length; j++)
                {
                    if (number != start[j])
                    {
                        end = end + number + count;//end = ""+'1'+1
                        number = start[j];
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("8번 문제");
            int input = int.Parse(Console.ReadLine());
            int max = 1;
            int counter = 0;
            while (true)
            {
                max = max + (6 * counter);
                if (max < input)
                {
                    counter++;
                    continue;
                }
                else
                {
                    Console.WriteLine($"{input}은/는 {counter + 1}번째 벌집군에 속함");
                }
                break;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("8번 문제 선생님꺼");

            int input1 = int.Parse(Console.ReadLine());
            if (input1==1)
            {
                Console.WriteLine("1번 벌집");
            }
            else if(input1<=7)
            {

            }
            else
            {
                int tempCount = 1;
                int sub = 6;
                while (input1>0)
                {
                    input1 = input1 - sub;
                    sub = sub + 6;
                    tempCount++;
                    if (input1 <= 1)
                        break;
                }
                Console.WriteLine(tempCount);
            }

        }
    }
}
