using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_arrayClass
{
    class Array
    {
        private int sum;
        private int avg;
        public Array()
        {
            sum = 0;
            avg = 0;
        }
        
        public int Sum(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public int Avg(int[] arr)
        {
            avg = (sum / arr.Length);
            return avg;
        }
        public void print()
        {
            Console.WriteLine("합계: "+sum);
            Console.WriteLine("평균: " + avg);

        }
    }
}
