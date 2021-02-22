using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IComparer에대해
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> iList = new List<int> { 5, 2, 3, 7, 1 };
            iList.Sort(IntCompare);
            foreach (var item in iList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();*/

            int[] a = new int[] { 5, 2, 3, 7, 1 };
            IntComparer iCpr = new IntComparer();

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (iCpr.Compare(a[j], a[j + 1]) > 0)
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
        }

        static int IntCompare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }

    class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}
