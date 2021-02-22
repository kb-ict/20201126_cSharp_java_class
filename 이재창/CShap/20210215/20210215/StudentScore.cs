using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210215
{
    class StudentScore
    {
        public int Kor { get; set; }
        public int Eng { get; set; }
        public int Math { get; set; }
        public int Sum { get; set; }
        public double Avg { get; set; }
        public char Score { get; set; }

        public StudentScore(int kor, int eng, int math)
        {
            Kor = kor;
            Eng = eng;
            Math = math;
            Calculator();
        }

        public void Calculator()
        {
            Sum = Kor + Eng + Math;
            Avg = Sum / 3.0;
            if (Avg >= 90) Score = 'A';
            else if (Avg < 90 && Avg >= 80) Score = 'B';
            else if (Avg < 80 && Avg >= 70) Score = 'C';
            else if (Avg < 70 && Avg >= 60) Score = 'D';
            else Score = 'F';
        }

        public override string ToString()
        {
            return $"국어: {Kor}\n영어: {Eng}\n수학: {Math}\n" +
                $"총점: {Sum}\n평균: {Avg:f1}\n학점: {Score}\n";
        }
    }
}
