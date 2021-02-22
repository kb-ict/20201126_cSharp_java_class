using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번2번 문제");
            Console.Write("입력받을 정수의 갯수를 입력하세요 : ");
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            
            int countmax = 0;
            int countmin = 0;
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < N; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    countmax = i + 1;
                }
                if (min > a[i])
                {
                    min = a[i];
                    countmin = i + 1;
                }
            }
            Console.WriteLine($"최대값은 {max}이고 최소값은 {min}이다.");
            Console.WriteLine($"최대값은 {countmax}번째이고 최소값은{countmin}번째이다.");
            Console.WriteLine();
            Console.WriteLine("3번 문제");
            Console.Write("첫번째 자연수를 입력 하세요 : ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("두번째 자연수를 입력 하세요 : ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("세번째 자연수를 입력 하세요 : ");
            int C = int.Parse(Console.ReadLine());
            string D = "";
            D =D+A * B * C;
            int[] count = new int[10];
            char number = D[0];
            Console.Write($"계산한 결과 {D}에는 ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                   number = D[j];
                   if (D[j]-'0'==i)
                    {
                        count[i]++;
                        continue;
                    }
                }
                ; 
                if (count[i] != 0)
                {
                    Console.Write($"{i}이/가 {count[i]}번 ");
                }
                
            }
            Console.WriteLine("쓰였다.");
        }
    }
}
