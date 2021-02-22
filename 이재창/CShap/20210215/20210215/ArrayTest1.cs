using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210215
{
    class ArrayTest1
    {
        public int Sum { get; set; }
        public int Avg { get; set; }

        public ArrayTest1(int[] arr)
        {
            SumAvg(arr);
        }

        public void SumAvg(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            Avg = Sum / arr.Length;
            Console.WriteLine("총점: " + Sum);
            Console.WriteLine("평균: " + Avg);
        }
    }
}
