using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210215_Class
{
    class Array
    {
        private int sum;
        private int avg;

        public Array(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("총점: "+sum);
            Console.WriteLine("평균: " + avg);
        }
        public int Sum { get => sum; set => sum = value; }
        public int Avg { get => avg; set => avg = value; }
    }
}
