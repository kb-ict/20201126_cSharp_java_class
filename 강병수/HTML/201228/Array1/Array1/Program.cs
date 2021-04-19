using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("1번 문제");
            Console.Write("숫자 입력: ");
            int N = int.Parse(Console.ReadLine());
            int[] ab = new int[N];
            for (int i = 0; i < ab.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ab[i] = x;
            }
            int[] xy = new int[N];
            for (int i = 0; i < xy.Length; i++)
            {
                xy[i] = ab[i];
            }
            Array.Sort(ab);
            Console.WriteLine(ab[0]); //최소값
            Console.WriteLine(ab[N-1]); //최대값
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("2번 문제");
            for (int i = 0; i < xy.Length; i++)
            {
                if (ab[0] == xy[i]) {
                    Console.WriteLine("최소값의 위치: " + (i+1) + "번째");
                }
                if (ab[N-1] == xy[i]) {
                    Console.WriteLine("최대값의 위치: " + (i+1) + "번째");
                }
            }
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("3번 문제");
            int A, B, C;
            int [] k = new int[10];
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            int sum = A * B * C;
            while (sum > 0)
            {
                k[sum % 10]++;
                sum = sum / 10;
            }
            for (int i = 0; i < k.Length; i++)
            {
                Console.WriteLine(i + "의 개수: " + k[i]);
            }
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("4번 문제");
            int [] Q = new int[5];
            int [] Ans = new int[5];
            for (int i = 0; i < Q.Length; i++)
            {
                int y = int.Parse(Console.ReadLine());
                Q[i] = y;
            }
            Ans[0] = 1;
            Ans[1] = 66;
            Ans[2] = 22;
            Ans[3] = 14;
            Ans[4] = 28;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                if (Q[i] == Ans[i])
                {
                    Console.Write("O");
                    if(Q[i] == Q[0] || Q[i] == Q[4])
                    {
                        score = score + 10;
                    }
                    else
                    {
                        score += 20;
                    }
                }
                else
                {
                    Console.Write("X");
                    continue;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("총점: " + score);
            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            Console.WriteLine("5번 문제");
            Console.Write("문제의 개수 입력: ");
            int M = int.Parse(Console.ReadLine());
            int score2 = 0;
            int[] K = new int[M]; //문제 입력
            int[] D = new int[M]; //정답 입력
            int[] E = new int[M]; //풀이 입력
            for (int i = 0; i < K.Length; i++)
            {
                int z = int.Parse(Console.ReadLine());
                K[i] = z;
            }
            for (int i = 0; i < D.Length; i++)
            {
                int j = int.Parse(Console.ReadLine());
                D[i] = j;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < K.Length; i++)
            {
                int F = int.Parse(Console.ReadLine());
                E[i] = F;
            }
            for (int i = 0; i < K.Length; i++)
                {
                    if (E[i] == D[i])
                    {
                        Console.Write("O");
                            score2 += 1;
                    }
                    else
                    {
                        Console.Write("X");
                        continue;
                    }
                }

            Console.WriteLine("총점: " + score2);
        }
    }
}
