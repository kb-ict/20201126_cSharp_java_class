using System;
using System.Linq;

namespace _20210215
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = Enumerable.Range(1, 10).Select((p) => p * 10).Toarray();
            Arraytest1 at1 = new Arraytest1(arr);*/

            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                StudentScore st = new StudentScore(r.Next(50, 101), r.Next(50, 101), r.Next(50, 101));
                Console.WriteLine(st);
            }
        }
    }
}
