using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Answer_of_201217
{
    class Program
    {
        static void Main(string[] args)
        {

            //java 실행법: 컨트롤 + F11
            //C# 실행법: 컨트롤 + F5


            //java: System.out.Println("Hi");
            //C#: Console.WriteLine("Hi");
            //cw 입력 tab 키 두번
            Console.WriteLine("고길동");//한줄 띄움
            Console.Write("고길동"); //한줄 안띄움
            Console.WriteLine();

            //변수
            //java와 동일

            int a = 100;
            //단 String 변수는 String이랑 string 둘 다 동일하게 쓸 수 있다.
            String b = "sdf";
            string c = "yes";

            //문자열과 숫자 혼합하기
            string da = a + " 더하기 " + a + "는 " + (a + a) + "이다.";
            string dc = $"{a} 더하기 {a}는 {a + a}이다.";
            string dv = string.Format("{0} 더하기 {1}은 {2}이다.", a, a, a + a);

            Console.WriteLine(da);
            Console.WriteLine(dc);
            Console.WriteLine(dv);

            //조건문
            //java와 동일함

            if (a > 50)
            {
                Console.WriteLine("a는 50이상이다.");
            }
            if (a > 30)
            {
                Console.WriteLine("a는 30이상이다.");
            }
            if (a == 10)
            {
                Console.WriteLine("10");
            }
            else if (a == 100)
            {
                Console.WriteLine("100");
            }
            //끝에 else를 붙이지 않아도 된다.
            else
            {
                Console.WriteLine("10도 20도 아님");
            }

            //switch문도 java와 동일
            switch (a)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                case 30:
                    Console.WriteLine("30");
                    break;
                default:
                    Console.WriteLine("10과 20은 아님");
                    break;

            }

            //반복문도 java와 동일
            //단 foreach라는 특수 문법이 있는데 이거는 나중에
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("동어반복 10번");
            }

            int j = 10;
            while (j > 0)
            {
                j--;
            }
            do
            {
                j++;
            } while (j < 10);

            //값을 입력받는 경우
            //java
            /*import java.util.Scannner
             * Scanner sc = new Scanner(System.in);
             * String aa = sc.next();
             * int far = sc.nextInt();*/

            //C#
            //String test = Console.ReadLine();
            //int test2 = int.Parse(Console.ReadLine());


        }
    }
}
