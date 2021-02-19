using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201218_coding_sol
{
    class Program
    {
        static void Main(string[] args)
        {

            //프로그램 실행법
            //java : ctrl + F11
            //C# : ctrl + F5

            //java :  System.out.println("Hello") => 한줄 출력하고 한줄 띄는것
            //C# : Console.WriteLine("Hello")
            //cw 입력 tab 키 2번
            Console.WriteLine("");

            //java :  System.out.print("Hello") => 한줄 출력하고 한줄 안 띄는것
            //C# : Console.Write("Hello")
            Console.Write("Hello");
            //java :  System.out.println() => 아무것도 안하고 한줄 띄는 것
            //C# : Console.WriteLine() 
            Console.WriteLine();

            //변수
            //java와 동일
            int example = 100;
            //단 String 변수는 String과 string 둘 다 사용가능
            //C#에서는 보통 s를 소문자로 적는다
            string ex1 = "하이";
            String ex2 = "하이";
            string 이런것도됨 = "신기하죠?";
            Console.WriteLine(이런것도됨); // 근데 하지마세요. 옛날꺼엔 안돌아갈수 있음

            //문자열과 숫자 혼합하기
            string ex3 = example + "더하기" + example + "은 " + (example + example) + "이다.";
            string ex4 = $"{example} 더하기 {example}은 {example + example}이다";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다.", example, example, example + example);
            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            //조건문
            //java와 동일

            if (example>50)
            {
                Console.WriteLine("50초과");
            }
            if (example>30)
            {
                Console.WriteLine("30초과");
            }
            else
            {
                Console.WriteLine("30 미만");
            }

            if (example==10)
            {
                Console.WriteLine("10");
            }
            else if (example==20)
            {
                Console.WriteLine("20");
            }

            //switch문도 java랑 동일
            switch (example)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10,20은 아님");
                    break;
            }

            //반복문도 java랑 동일
            //단 foreach라는 특수문법이 있는데 이건 나중에 알려줌
            //근데 몰라도 코드짜는데는 지장없음
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("같은말 10번 반복하기");
            }
            int temp = 10;
            while (temp>0)
            {
                temp--;
            }
            do
            {
                temp++;
            } while (temp<10);
            //값을 입력받는 경우
            //java
            /* 
             Scanner s = new Scanner(System.in);
            String test = s. nextLine();
            int test2 = s.nextInt();
            */

            //C#
            /*
             string test = Console.Readline();
            int test2= int.Parse(Console.ReadLine());
            Consol.ReadLine은 단축키 없음..
            */

        }
    }
}
