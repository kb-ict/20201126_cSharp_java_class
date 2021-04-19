using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Review2
{
    class StudentScore
    {
        private int kor;
        private int eng;
        private int math;
        private int sum;
        private double avr;
        private char grade;

        public StudentScore() { }

        public StudentScore(int kor, int eng, int math)
        {
            this.kor = kor;
            this.eng = eng;
            this.math = math;
        }

        public int Kor { get => kor; set => kor = value; }
        public int Eng { get => eng; set => eng = value; }
        public int Math { get => math; set => math = value; }
        public int Sum { get => sum; set => sum = value; }
        public double Avr { get => avr; set => avr = value; }
        public char Grade { get => grade; set => grade = value; }

        public void calculator()
        {
            sum = kor + eng + math;
            avr = (double)sum / 3;
            if (avr >=90 && avr <=100)
            {
                grade = 'A';
            }
            else if (avr >= 80 && avr < 90)
            {
                grade = 'B';
            }
            else if (avr >= 70 && avr < 80)
            {
                grade = 'C';
            }
            else if (avr >= 60 && avr < 70)
            {
                grade = 'D';
            }
            else if (avr < 60)
            {
                grade = 'F';
            }

            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + avr);
            Console.WriteLine("학점: " + grade);
            Console.WriteLine("======================");
        }

        public void calculator(int kor, int eng, int math)
        {
            sum = kor + eng + math;
            avr = (double)sum / 3;
            if (avr >= 90 && avr <= 100)
            {
                grade = 'A';
            }
            else if (avr >= 80 && avr < 90)
            {
                grade = 'B';
            }
            else if (avr >= 70 && avr < 80)
            {
                grade = 'C';
            }
            else if (avr >= 60 && avr < 70)
            {
                grade = 'D';
            }
            else if (avr < 60)
            {
                grade = 'F';
            }

            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + avr);
            Console.WriteLine("학점: " + grade);
            Console.WriteLine("======================");
        }

        public void setProperty(int kor, int eng, int math)
        {
            this.kor = kor;
            this.eng = eng;
            this.math = math;
        }
    }
}
