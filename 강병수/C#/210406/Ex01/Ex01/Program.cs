using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if(name == "강병수")
            {
                Console.WriteLine("가나다라마바아자차카타파하");
            }

            int a = 100;
            if(a>50)
            {
                Console.WriteLine("Large");
            }
            else
            {
                Console.WriteLine("Small");
            }
            // 짝수,홀수 판정
            Console.WriteLine("숫자 입력: ");
            int b = int.Parse(Console.ReadLine());
            if (b%2 == 1)
            {
                Console.WriteLine("홀수");
            }
            else
            {
                Console.WriteLine("짝수");
            }

            if (a>0)
            {
                Console.WriteLine("a is positive number");
                if(a>50)
                {
                    Console.WriteLine("a is larger than 50");
                }
                else
                {
                    Console.WriteLine("a is smaller than 50");
                }
            }
            else
            {
                Console.WriteLine("a is negative number");
                if(a>-50)
                {
                    Console.WriteLine("a is larger than -50");
                }
                else if (a<-50)
                {
                    Console.WriteLine("a is smaller than -50");
                }
            }

            int cm = 175;
            if(cm >= 100 ^ cm <=200) //XOR 형태만 봐두기
                Console.WriteLine("");
            // 삼항 연산자
            // 간단한 조건식은 한 줄로 다 표현함
            // 둘이 같은 코드

            int c = a % 2==0 ? -1 : 0;

            if (a % 2 == 0)
                c = -1;
            else
                c = 0;

            // string에 특정한 문장 혹은 글자가 있을 떄

            string ab = "강병수";
            if(ab.Contains("강"))
                Console.WriteLine("가나다");
            if(ab.Contains("병수"))
                Console.WriteLine("라마바");
        }
    }
}
