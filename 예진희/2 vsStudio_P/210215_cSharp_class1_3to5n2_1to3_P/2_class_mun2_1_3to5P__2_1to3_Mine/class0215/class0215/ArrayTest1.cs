using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0215
{
    class ArrayTest1
    {
        // 문제3. 쌤풀이
        private int sum;
        private int avg;
        private int[] arr;

        // 1st
        public ArrayTest1(int[] arr)
        {
            sumAvg(arr);
        }

        // 2nd-3rd
        public ArrayTest1()
        {

        }

        // 2nd : 한번에 출력
        public void sumAvg(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine($"합\t: {sum}");
            Console.WriteLine($"평균\t: {avg}");

            //foreach (int i in arr)
            //{
            //    sum += i;
            //    avg /= i;
            //}
        }

        // 3rd
        // this = 배열 이름 역할과 동일
        public void setArray(int[] arr)
        {
            this.arr = arr;
        }
        public void sumAvg()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine($"합\t: {sum}");
            Console.WriteLine($"평균\t: {avg}");
        }

        public int Sum { get => sum; set => sum = value; }
        public int Avg { get => avg; set => avg = value; }

    }
}
