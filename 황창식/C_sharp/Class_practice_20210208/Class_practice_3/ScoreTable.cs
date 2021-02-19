using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_3
{
    class ScoreTable
    {
        private int[] arr;
        private int sum;
        private int ave;
        private string result;

        public ScoreTable(int[] arr)
        {
            this.arr = arr;
        }

        public int getSum()
        {
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public int getAve(int sum)
        {
            ave = sum / arr.Length;
            return ave;
        }

        public string getResult(int ave)
        {
            if (100 >= ave && ave >= 90)
                result = "A학점";
            else if (89 >= ave && ave >= 80)
                result = "B학점";
            else if (79 >= ave && ave >= 70)
                result = "c학점";
            else if (69 >= ave && ave >= 60)
                result = "D학점";
            else
                result = "B학점";
            return result;
        }

        public void showResult(int num)
        {
            Console.WriteLine(num + "번 학생 결과");
            Console.WriteLine("총점 : " + getSum());
            Console.WriteLine("평균 : " + getAve(getSum()));
            Console.WriteLine("학점 : " + getResult(getAve(getSum())));
            Console.WriteLine("---------------------------------");
        }
    }
}
