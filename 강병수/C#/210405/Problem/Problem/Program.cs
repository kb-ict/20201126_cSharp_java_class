using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1번 문제
            double inch = 2.54;
            Console.Write("인치 입력");
            int cm = int.Parse(Console.ReadLine());
            Console.WriteLine(cm + "인치는 " + inch*cm + "cm이다.");

            // 2번 문제
            double pound = 2.20462262;
            Console.Write("킬로그램 입력");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine(kg + "킬로그램은 " + kg*pound +"파운드 이다.");

            // 3번 문제
            int radius = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double A = pi * radius * radius;
            double D = pi * radius * 2;
            Console.WriteLine("둘레: " + D);
            Console.WriteLine("넓이: " + A);


        }
    }
}
