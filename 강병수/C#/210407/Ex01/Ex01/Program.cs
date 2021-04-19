using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Hello" + i);
                Console.WriteLine("Hello"[i]);
            }
            string name = "강병수";
            string[] names = { "고길동", "둘리", "또치", "도우너" };

            for (int i = 0; i<name.Length; i++)
                Console.WriteLine(name[i]);

            for (int i = 0; i<names.Length; i++)
                Console.WriteLine(names[i]);

            for (int i = (int)'1'; i <= (int)'힣'; i++)
            {
                Console.Write((char)i);
                if (i == (int)'강')
                    break;
                //Thread.Sleep(50);
                if (i == (int)'힣')
                { 
                  i = (int)'1';
                }
            }
            while (false)
            {
                Console.WriteLine(new Random().Next(int.MaxValue));
            }

            //for
            //do while
            //while
            //C#에서는 foreach

            while (false)
            { 
                Console.WriteLine("Hi");
            }
            do
            {
                Console.WriteLine("Hello");
            } while (false);

            int count = 100;
            while(count < 100)
            {
                Console.WriteLine("카운트값은" + count + "입니다");
            }
            do
            {
                Console.WriteLine("do while count" + count);
            } while (count < 100);

            int num = 0;
            for (int i = 0; i < 1001; i++)
            { 
                num += i;
            }
            Console.WriteLine(num);
            int sum = 0;
            for(int i = 1; i<101; i++)
            { if (i % 2 != 0)
                continue;

                sum += i;
                        
            }
            Console.WriteLine(sum);

            foreach (var item in names)
            {
                Console.WriteLine(item + " is good animal");
            }

            int abcd = 4;
            for (int a = 0; a < abcd; a++)
            {
                Console.WriteLine(abcd + "is good man");
            }

            int countindex = 0;
            for (int j = 0; j<names.Length; j++)
            {
                if (countindex == 0)
                {
                    countindex++;
                    continue;
                }

                Console.WriteLine(names[j] + "is good person");
            }
            //삼각 반갈죽
            for (int i = 0; i<10; i++)
            { 
                {   for(int j = 0; j< i; j++)
                        Console.Write("*");
                }
                Console.WriteLine("");
            }
            //역삼각
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            // 삼각형
            for (int i = 0; i< 7; i++)
            { 
                for (int j = 7; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2*i+1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            // 마름모
            for (int i = 0; i<7; i++)
            {
                for (int j = 7; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2*i+1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 6; i>0; i--)
            {
                for (int j = 7; j+1 > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2*i-1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //goto문

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j<10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto Example;
                }
            }

        Example:
            Console.WriteLine("go to");

            string student = Console.ReadLine();

            if (student == "강병수")
                goto Example;

            //ToUpper, ToLower
            string example = "exApple";
            Console.WriteLine(example.ToLower()); //전부 소문자로
            Console.WriteLine(example.ToUpper()); //전부 대문자로

            //Split -쪼개기
            string example2 = "블레미샤인,니어,위슬래시";
            string [] example2_array = example2.Split(',');
            foreach (var item in example2_array)
            {
                Console.WriteLine(item + "님 안녕하세요.");
            }

            //Join - Split의 반대
            string example3 = string.Join(",", example2_array);
            Console.WriteLine(example3);
            //Trim - 문자열 양 옆의 공백 제거
            string trim = "   호에에에 에에 에 에 에 엥    엥   ";
            Console.WriteLine("!" + trim + "!");
            Console.WriteLine("!" + trim.Trim() + "!");
            
        }
    }
}
