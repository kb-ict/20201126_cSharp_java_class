using System;

namespace Array_20210208
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배열 초기화
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                // System.out.println()
                Console.WriteLine(arrInt[i] + " ");
                string str = string.Format("배열[{0}]:{1}", i, arrInt[i]);
                Console.WriteLine(str);
            }


            // 1차원 배열 초기화2
            char[] arrCh = new char[4] { '이', '김', '박', '홍' };
            for (int i = 0; i < arrCh.Length; i++)
            {
                // System.out.print()
                Console.Write(arrCh[i] + " ");
            }
            Console.WriteLine();


            // 2차원 배열 초기화
            int[,] arrInt2 = {
                { 1, 2, 3 }, { 4, 5, 6 }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }


            // 2차원 배열 초기화2
            // 상수 변수 (=final)
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] arrInt2_1 = new int[SIZE_ROW, SIZE_COL]{
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_COL; j++)
                {
                    Console.Write(arrInt2_1[i, j] + " ");
                }
                Console.WriteLine();
            }


            // 2차원 배열 초기화3
            string[][] arrStr1 = new String[2][];
            arrStr1[0] = new string[] { "김길동", "홍길동", "박길동" };
            arrStr1[1] = new string[] { "이길동" };
            for (int i = 0; i < arrStr1.Length; i++)
            {
                for (int j = 0; j < arrStr1[i].Length; j++)
                {
                    Console.Write(arrStr1[i][j] + " ");
                }
                Console.WriteLine();
            }


            // 2차원 배열 초기화4
            int[][] arrInt3 = new int[3][];
            for (int i = 0; i < arrInt3.Length; i++)
            {
                arrInt3[i] = new int[i + 1];
                for (int j = 0; j < arrInt3[i].Length; j++)
                {
                    arrInt3[i][j] = 10 + j;
                    Console.Write(arrInt3[i][j] + " ");
                }
                Console.WriteLine();
            }


            // foreach (향상된 for문) 1차원
            int[] arrEach1 = { 1, 2, 3, 4, 5 };
            // for(int i : arrEach1)
            foreach (int i in arrEach1)
            {
                Console.WriteLine(i);
            }


            // foreach 2차원
            string[,] arrEach2 =
            {
                { "홍길동", "김길동" },
                { "hong", "kim" }
            };
            foreach (string str in arrEach2)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

        }
    }
}
