using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0215
{
    //11. 학점을 출력하는 프로그램.
    //조건1) 5명의 국, 영, 수 점수는 Random 클래스를 사용하여 랜덤하게 생성.
    //조건2) 2차원배열을 생성하여 1번째 학생의 국,영,수 점수를 1행1열, 1행2열, 1행3열에 저장.
    //조건3) 2번째 학생의 점수는 2행 ~ 5번째 학생의 점수는 5행에 각각 저장.
    //조건4) 5명학생의 점수들을 저장한 배열을 리턴하기.
    //조건5) main()에서 배열값을 받아 학생1명씩 대한 총점, 평균, 학점을 출력하기.
    //      --> 출력 형식은 자유롭게 생각해서 하되 깔끔하게 처리.
    //조건6) 학점 기준 점수
    //  100 ~ 90 -> A학점 출력      89 ~ 80 -> B학점 출력
    //   79 ~ 70 -> C학점 출력      69 ~ 60 -> D학점 출력
    //   59 ~ 50 -> E학점 출력      49 ~  0 -> F학점
    class StudentScore
    {
        // 문제4. 쌤풀이
        private int kor;
        private int eng;
        private int math;

        private int sum;
        private int avg;
        private char hakjum;

        public StudentScore()
        {
        }

        // 외부값 세팅만
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
        public int Avg { get => avg; set => avg = value; }

        public void calculator()
        {
            sum = kor + eng + math;
            avg = sum / 3;
            if (avg >= 90 && avg <= 100)
            {
                hakjum = 'A';
            }
            else if (avg >= 80 && avg <= 89)
            {
                hakjum = 'B';
            }
            else if (avg >= 70 && avg <= 79)
            {
                hakjum = 'C';
            }
            else if (avg >= 60 && avg <= 69)
            {
                hakjum = 'D';
            }
            else
            {
                hakjum = 'F';
            }
            Console.WriteLine($"총점: {sum}");
            Console.WriteLine($"평균: {avg}");
            Console.WriteLine($"학점: {hakjum}");
            Console.WriteLine("--------------------\n");
        }

        public void calculator(int kor, int eng, int math)
        {
            sum = kor + eng + math;
            avg = sum / 3;
            if (avg >= 90 && avg <= 100)
            {
                hakjum = 'A';
            }
            else if (avg >= 80 && avg <= 89)
            {
                hakjum = 'B';
            }
            else if (avg >= 70 && avg <= 79)
            {
                hakjum = 'C';
            }
            else if (avg >= 60 && avg <= 69)
            {
                hakjum = 'D';
            }
            else
            {
                hakjum = 'F';
            }
            Console.WriteLine($"총점: {sum}");
            Console.WriteLine($"평균: {avg}");
            Console.WriteLine($"학점: {hakjum}");
            Console.WriteLine("--------------------\n");
        }

        public void setAllProperty(int kor, int eng, int math)
        {
            this.kor = kor;
            this.eng = eng;
            this.math = math;
        }
    }
}
