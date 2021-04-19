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
            // 1차원 배열 초기화
            int[] Array = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
                string str = string.Format("배열[{0}]:{1}", i, Array[i]);
                // {0}, {1}이 각각 i, Array[i]로 치환, java의 %d, %s 생각하면 됨
                Console.WriteLine(str);
            }

            // 1차원 배열 초기화
            char[] ArrCh = new char[4] { '이', '김', '박', '최' };
            for (int j = 0; j < ArrCh.Length; j++)
            {
                Console.Write(ArrCh[j] + "\t");
            }
            Console.WriteLine();
            // 2차원 배열 초기화
            int[,] Array2 =
            {
                {1, 2, 3}, {4, 5, 6}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Array2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화 2
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] Array3 = new int[SIZE_ROW, SIZE_COL]
            {
                {1,2,3,} , { 4,5,6,}
            };
            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_COL; j++)
                {
                    Console.Write(Array3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화 3
            string[][] Array4 = new string[2][];
            Array4[0] = new string[] { "김길동", "박길동", "홍길동" };
            Array4[1] = new string[] { "이길동" };
            for (int i = 0; i < Array4.Length; i++)
            {
                for (int j = 0; j < Array4[i].Length; j++)
                {
                    Console.Write(Array4[i][j] + " ");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화 4
            int[][] Array5 = new int[3][];
            for (int i = 0; i < Array5.Length; i++)
            {
                Array5[i] = new int[i + 1];
                for (int j = 0; j < Array5[i].Length; j++)
                {
                    Array5[i][j] = 10 + j;
                    Console.Write(Array5[i][j] + " ");
                }
                Console.WriteLine();
            }

            // foreach (향상된 for문) 1차원
            int[] Array6 = { 1, 2, 3, 4, 5 };
            // for (int i : Array6) java 문법
            foreach (int i in Array6)
            {
                Console.WriteLine(i);
            }

            // foreach 2차원
            string[,] Array7 =
            {
                {"홍길동", "김길동" },
                {"hong", "kim" }
            };
            foreach (string str in Array7)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}
