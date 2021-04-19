using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class TestArray
    {

        int sum;
        double avr;
        int[] arr;

        public TestArray(int[] arr)
        {
            this.arr = arr;
            Sum();
            Avr();
        }

        public void Sum()
        {
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            Console.WriteLine("합계: " + sum);
        }

        public void Avr()
        {
            avr = sum / 10;
            Console.WriteLine("평균: " + avr);
        }
    }
}
