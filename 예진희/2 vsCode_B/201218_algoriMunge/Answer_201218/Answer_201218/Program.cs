using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_201218
{
    class Program
    {
        static void Main(string[] args)
        {
            //복습

            //프로그램 실행
            //java: ctrl + F11
            //c#: ctrl + F5

            //java : Syste.out.println("Hello"); //한줄 출력하고 한줄 띄우는거
            //c# : Console.WriteLine("Hello");
            //cw 입력 tab키 2번 자동완성

            Console.WriteLine("Hello한줄 출력하고 한줄 띄우는거");

            //java : Syste.out.print("Hello"); //출력하고 한줄 안 띄우는거
            //c# : Console.Write("Hello");
            Console.Write("Hello출력하고 한줄 안 띄우는거");

            //java : Syste.out.println(); // 아무것도 안하고 한줄 띄움
            //c# : Console.WriteLine();

            Console.WriteLine();    // 여기서 한줄 띄운다

            //---------------------------------------------------------------------------------
            /*
            변수
            자바와 동일
            */

            int example = 100;

            /*단 String 변수는 String이랑 string 둘 다 동일하게 쓸 수 있음
             * c#에서는 보통 s를 소문자로 적는다.
             */

                string ex = "하이";
            String ex2 = "헬로";
            string 이런것도됨 = "신기하죠?";
            Console.WriteLine(이런것도됨); //원래 ""이거 빼도됨, 이건 하지말기, 옛날버전에서는 안돌아감

            //문자열과 숫자 혼합하기
            string ex3 = example + "더하기" + example + "은" + (example + example) + "이다.";
            string ex4 = $"{example}더하기 {example}은 {example + example}이다.";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다.", example, example, example + example);

            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            //조건문
            //java와 동일함
            if (example > 50)
            {
                Console.WriteLine("example은 50이상");
            }
            //---------------------------------------------------------------------------------

            if (example > 30)
            {
                Console.WriteLine("example은 30이상");
            }

            else
            {
                Console.WriteLine("30 미만");
            }
            //---------------------------------------------------------------------------------

            if (example ==10) 
            {
                Console.WriteLine("10");
            }

            else if (example ==20)
            {
                Console.WriteLine("20");
            }
            //끝에 꼬고 else 안 붙여도 됨

            //---------------------------------------------------------------------------------

            if (example == 10)
            {
                Console.WriteLine("10");
            }

            else if (example == 20)
            {
                Console.WriteLine("20");
            }

            else
            {
                Console.WriteLine("10이랑 20은 아니다");
            }
            //---------------------------------------------------------------------------------

            //switch문도 java와 동일
            //sw 탭탭 자동완성
            switch (example)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("10이랑 20은 아니다.");
                    break;
            }
            Console.WriteLine();
            //---------------------------------------------------------------------------------

            //반복문도 java와 동일
            //단 foreach라는 특수 문법이 있는데 이건 나중에
            //몰라도 코드짜는데 지장x

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("같은말 10번 반복");
            }
            /*주석*/
            //---------------------------------------------------------------------------------

            int temp = 10;
            while (temp>0)
            {
                temp--;
            }

            //---------------------------------------------------------------------------------

            do
            {
                temp++;
            } while (temp<10);

            //---------------------------------------------------------------------------------
            //
            /*  java 
             *  ------------------------------------
             *  Scanner s = new Scanner(System.in);
             *  String test = s.nextLine();
             *  int test2 = s.nextInt();
             *  
             *  c#
             *  ------------------------------------
             *  String text = Console.ReadLine();
             *  int test2 = int.Parse(Console.ReadLine());
             *  Console.ReadLine은 단축키 없음
             */

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());



        }
    }
}
