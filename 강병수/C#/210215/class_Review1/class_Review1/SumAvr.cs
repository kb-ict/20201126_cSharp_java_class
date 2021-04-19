using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Review1
{
    class SumAvr
    {
        private int sum;
        private double avr;
        private int[] array;

        public int Sum1 { get => sum; set => sum = value; }
        public double Avr1 { get => avr; set => avr = value; }
        public int[] Array { get => array; set => array = value; }

        public void Sum()
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("합: " + sum);
        }

        public void Avr()
        {
            avr = (double)sum / 10;
            Console.WriteLine("평균: " + avr);
        }

        public SumAvr(int[] array)
        {
            this.array = array;
            Sum();
            Avr();
        }
    }
}
