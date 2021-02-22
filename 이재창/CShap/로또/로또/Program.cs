using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 로또
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[6];

            Console.WriteLine("-------------------------");
            Console.WriteLine("간단한 로또 프로그램 v1.1");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < 6; i++)
            {
                arr[i] = rand.Next(1, 45);

                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        i--;
                        break;
                    }
                }
            }

            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}
