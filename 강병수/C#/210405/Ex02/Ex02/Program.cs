using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1/2);

            Console.WriteLine(5+3);
            Console.WriteLine(5-3);
            Console.WriteLine(5*3);
            Console.WriteLine(5/3);
            Console.WriteLine(5%3);
            //괄호를 넣어줘 우선순위 변경 가능

            //문자 선택자
            Console.WriteLine("안녕하세요"[0]); //안
            Console.WriteLine("안녕하세요"[4]); //요
            //Console.WriteLine("안녕하세요"[5]); 에러메시지

            Console.WriteLine((int)"안녕하세요"[0]); //안
            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0],16)); //안

            Console.WriteLine(1==1);
            Console.WriteLine(1!=1);
            bool result = true;
            bool result2 = false;

            Console.WriteLine(!result);
            Console.WriteLine(!result2);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(int.MinValue);

            long a = long.MaxValue;
            Console.WriteLine(a+1);

            int conclusion = 100;
            // ++을 무조건 뒤에 붙이고 두 줄로 나눠서 쓰기
            conclusion++; // 1 증가 시킨 뒤
            Console.WriteLine(conclusion); //그 값을 출력
            conclusion++;
            Console.WriteLine(conclusion);

            Console.ReadLine();
            
        }
    }
}
