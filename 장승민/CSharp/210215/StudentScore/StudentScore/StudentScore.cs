using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScore
{
    class StudentScore
    {
        private int kor;
        private int eng;
        private int math;
        private int sum;
        private int avg;
        private int hakjum;

        public StudentScore() { }  //중복 정의 = 오버로딩
        public StudentScore(int kor, int eng, int math)
        {
            this.kor = kor;
            this.eng = eng;
            this.math = math;

        }
        public void calculator()
        {
            sum = kor + eng + math;
            avg = sum / 3;
            Console.WriteLine("총점: "+ sum);
            Console.WriteLine("평균: "+ avg);
        }

        public int Kor { get => kor; set => kor = value; }
        public int Eng { get => eng; set => eng = value; }
        public int Math { get => math; set => math = value; }
        public int Sum { get => sum; set => sum = value; }
        public int Avg { get => avg; set => avg = value; }
        public int Hakjum { get => hakjum; set => hakjum = value; }


    }
}
