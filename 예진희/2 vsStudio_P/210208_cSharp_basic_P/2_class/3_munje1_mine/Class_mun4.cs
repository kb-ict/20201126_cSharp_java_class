using System;

namespace _3_munje1_mine
{
    class Class_mun4
    {
        // 조건1) 5명의 국, 영, 수 점수는 Random 클래스를 사용하여 랜덤하게 생성.
        // 조건2) 2차원배열을 생성하여 1번째 학생의 국,영,수 점수를 1행1열, 1행2열, 1행3열에 저장.
        // 조건3) 2번째 학생의 점수는 2행 ~ 5번째 학생의 점수는 5행에 각각 저장.
        // 조건4) 5명학생의 점수들을 저장한 배열을 리턴하기.
        // 조건5) main()에서 배열값을 받아 학생1명씩 대한 총점, 평균, 학점을 출력하기.
        //    --> 출력 형식은 자유롭게 생각해서 하되 깔끔하게 처리.
        // 조건6) 학점 기준 점수
        // 100 ~ 90	-> A학점 출력		89 ~ 80	-> B학점 출력
        // 79 ~ 70	-> C학점 출력		69 ~ 60	-> D학점 출력
        // 59 ~ 50	-> E학점 출력		49 ~  0	-> F학점

        private int[,] arr4;
        private int hap;
        private double avg;
        private char hakjum;
        private int ROW;
        private int COL;

        public Class_mun4(int[,] arr4, int ROW, int COL)
        {
            this.arr4 = arr4;
            this.ROW = ROW;
            this.COL = COL;

            for (int i = 0; i < ROW; i++)
            { 
                for (int j = 0; j < COL; j++)
                {
                    Console.Write($"{arr4[i,j]}\t");
                    hap += arr4[i,j];
                    avg = hap / COL;
                }
                Console.Write($"합 : {hap}\t평균 : {avg}");
                if      (avg<=100 && avg>=90) { hakjum = 'A'; }
                else if (avg <= 89 && avg >= 80) { hakjum = 'B'; }
                else if (avg <= 79 && avg >= 70) { hakjum = 'C'; }
                else if (avg <= 69 && avg >= 60) { hakjum = 'D'; }
                else { hakjum = 'F'; }
                Console.Write($"학점 : {hakjum}");
                hap = 0;
                avg = 0;
                Console.WriteLine();
            }
        }

    }
}
