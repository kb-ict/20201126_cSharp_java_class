using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_2
{
    class SumAve
    {
        private int sum;
        private int ave;
        private int[] arr;

        public int Sum { get => sum; set => sum = value; }
        public int Ave { get => ave; set => ave = value; }
        public int[] Arr { get => arr; set => arr = value; }

        public SumAve(){ }
        public SumAve(int[] arr)
        {
            getSumAve(arr);
        }

        public void getSumAve(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            ave = sum / arr.Length;

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + ave);
        }

        public void getSumAve()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            ave = sum / arr.Length;

            Console.WriteLine("총점 : " + sum);
            Console.WriteLine("평균 : " + ave);
        }



        /*public int getSum(int[] arr)
        {
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public int getAve(int[] arr, int sum)
        {
            ave = sum / arr.Length;
            return ave;
        }*/

    }
}
