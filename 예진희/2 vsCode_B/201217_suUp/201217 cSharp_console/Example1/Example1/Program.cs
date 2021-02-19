using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //java : System.out.prinln("Hello World");
            //C# : Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            //cw 하고 탭탭

            int a = 100;
            if(a>50)
            {
                Console.WriteLine("a는 50을 넘어요");
            }
            else
            {
                Console.WriteLine("a는 50을 넘지 않아요.");
            }
            //java
            /*
                 Scanner s = new Scanner(System.in);
                 string ss = s.nextLine();
                 int aa = s.nextInt();
             */

            //실행하는 건 ctrl + f5
            string ss = Console.ReadLine();
            String sa = Console.ReadLine();
            int aa = int.Parse(Console.ReadLine());

            switch (aa)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            switch (aa)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 10; i++)
            {

            }

            int temp = 10;
            while (temp > 0)
            {
                temp--;
            }

            do
            {
                temp++;
            } while (temp<0);


            int abc = 100;
            if (abc == 100)
            {

            }
            else if(abc == 50)
            {

            }
            else
            {

            }


            Console.WriteLine("사람의 이름을 입력받아라");
            string name = Console.ReadLine();
            Console.WriteLine("나이를 입력받아라");
            int age = int.Parse(Console.ReadLine());
            Console.Write(""); //print
            Console.WriteLine(""); //println
            
            Console.WriteLine($"이름은 {name}이고, 나이는 {age}이야.");

            string message = $"문장쓰다가 변수는 중괄호 {name} 숫자도 됨 {age}";
            Console.WriteLine(message);


            string msg = string.Format("첫번째 : {0}, 두번째 {1}", name, age);

            string ex = age + "이건 내 나이야";
        }
    }
}
