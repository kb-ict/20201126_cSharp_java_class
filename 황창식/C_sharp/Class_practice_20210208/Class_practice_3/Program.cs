using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = getScoreTable();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((i+1) + "번 학생 점수 : ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------");

            ScoreTable[] result = new ScoreTable[5];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new ScoreTable(arr[i]);
                result[i].showResult(i + 1);
            }
        }

        public static int[][] getScoreTable()
        {
            Random r = new Random();
            int[][] arr = new int[5][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[3];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = r.Next(50, 101);
                }
            }
            return arr;
        }
    }
}
