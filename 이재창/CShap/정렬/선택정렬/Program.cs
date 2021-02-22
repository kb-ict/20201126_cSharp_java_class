using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 선택정렬
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 5, 4, 7, 2, 1 };
            SelectSort(arr);
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
        }

        static void SelectSort(int[] arr)
        {          
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
