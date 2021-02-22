using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 1000;
            int[] a = new int[MAX];
            int[] b = new int[MAX];
            int cnt, i, j;
            int n = 7;

            a[0] = 1;
            Console.WriteLine(a[0]);
            for (int ii = 0; ii < n; ii++)
            {
                i = 0;
                j = 0;
                cnt = 1;
                
                while (a[i] != 0)
                {
                    if (a[i] == a[i + 1])
                        cnt++;
                    else
                    {
                        b[j] = a[i];
                        Console.Write(b[j]);
                        j++;

                        b[j] = cnt;
                        Console.Write(b[j]);
                        j++;
                        cnt = 1;
                    }
                    i++;
                }

                for (int k = 1; k < MAX; k++)
                {
                    a[k] = b[k];
                }
                Console.WriteLine();
            }            
        }
    }
}
