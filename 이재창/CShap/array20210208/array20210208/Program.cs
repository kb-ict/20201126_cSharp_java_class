using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array20210208
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i] + " ");
                string str = $"배열[{i}]:{arrInt[i]}";
                Console.WriteLine(str);
            }

            char[] arrCh = new char[4] { '이', '김', '박', '홍' };
            for (int i = 0; i < arrCh.Length; i++)
            {
                Console.Write(arrCh[i] + " ");
            }
            Console.WriteLine();

            int[,] arrInt2 =
            {
                {1, 2, 3 }, {4, 5, 6}
            };

            for (int i = 0; i < arrInt2.GetLength(0); i++)
            {
                for (int j = 0; j < arrInt2.GetLength(1); j++)
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                Console.WriteLine();
            }

            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;
            int[,] arrInt2_1 = new int[SIZE_ROW, SIZE_COL]
            {
                {1, 2, 3 },
                {4, 5, 6 }
            };

            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_COL; j++)
                {
                    Console.Write(arrInt2_1[i, j] + " ");
                }
                Console.WriteLine();
            }

            string[][] arrStr1 = new string[2][];
            arrStr1[0] = new string[] { "김길동", "홍길동", "박길동" };
            arrStr1[1] = new string[] { "이길동" };
            for (int i = 0; 9 < arrStr1.Length; i++)
            {
                for (int j = 0; j < arrStr1.Length; j++)
                {
                    Console.Write(arrStr1[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[][] arrInt2_4 = new int[3][];
            for (int i = 0; i < arrInt2_4.Length; i++)
            {
                arrInt2_4[i] = new int[i + 1];
                for (int j = 0; j < arrInt2_4[i].Length; j++)
                {
                    arrInt2_4[i][j] = 10 + j;
                    Console.Write(arrInt2_4[i][j] + " ");
                }
                Console.WriteLine();
            }

            string[,] arrEach2 =
            {
                {"홍길동", "김길동" },
                {"Hong", "Long" }
            };

            foreach (var a in arrEach2)
            {
                Console.Write(a + " ");               
            }
            Console.WriteLine();
        }
    }
}
