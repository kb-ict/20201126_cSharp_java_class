using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[500];
            int[] arr2 = new int[500];
            int cnt = 1, a = 0, b = 0;

            arr1[0] = 1;
            Console.Write("개미수열 숫자 입력: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1번째 수열: " + arr1[0]);
            for (int i = 0; i < n; ++i)
            {
                while (arr1[a] != 0)
                {
                    if (arr1[a] == arr1[a + 1])
                    {
                        cnt++;
                    }
                    else
                    {
                        arr2[b] = arr1[a];
                        arr2[b + 1] = cnt;
                        b += 2;
                        cnt = 1;
                    }
                    a++;
                }
                Array.Copy(arr2, arr1, arr2.Length);
                a = 0;
                b = 0;
                Console.Write(i + 2 + "번째 수열: ");
                foreach (var item in arr1)
                {
                    if (item == 0)
                        break;
                    Console.Write(item);
                }
                Console.WriteLine();
            }

        }
    }
}
