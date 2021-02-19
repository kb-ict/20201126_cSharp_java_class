using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_munje1_mine
{
    class Class_mun3
    {
        //3. 아래의 배열의 값의 합과 평균을 구하는 클래스 작성.

        //조건1) int arr[] = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        //조건2) 배열의 합과 평균을 속성으로 설정.
        //조건3) 배열의 합을 반환하는 인스턴스 메쏘드 추가.
        //조건4) 배열의 평균을 반환하는 인스턴스 메쏘드 추가.
        //조건5) main()에서 생성자의 매개변수로 배열 array 전달하여 객체 생성 및 합과 평균 출력.

        private int hap;
        private double avg;
        private int[] arr;

        public Class_mun3(int[] arr)
        {
            this.arr = arr;

            foreach (int i in arr)
            {
                hap += i;
                avg = hap / arr.Length;
            }
            Console.WriteLine("합\t: " + hap);
            Console.WriteLine("평균\t: " + avg);
        }

        public int Hap
        {
            get { return hap; }
        }

        public double Avg
        {
            get { return avg; }
        }

    }
}
