﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_munje1_mine
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://blog.naver.com/hack4ork/221671058863
            //1.자동차에 대한 클래스 작성하기.

            //조건1)	속성(멤버 변수) - 대리점명은 상수 클래스변수(static 변수)로 선언.
            //조건2)	속성(멤버 변수) - 제조사, 색상, 가격, 모델명은 인스턴스 변수로 선언.
            //조건3)	기본 생성자를 만들고 아래의 속성값들을 초기화 바람.
            //        제조사 - "기아", 색상 - "블랙", 이름 - "K7"
            //        가격 - "사천만원", 대리점명 - "동대구 영업소"
            //조건4)	모든 속성들을 매개변수로 전달하여 객체를 생성할수있는 생성자 추가.
            //조건5)	모든 속성 정보들을 출력하는 인스턴스 메쏘드(함수) 추가.

            //2.자동차 클래스 추가 작업.

            //조건1) main()에서 기본생성자를 사용하여 객체를 생성하고 모든 속성 정보 출력하기.
            //조건2) 자동차 클래스에 모델명을 설정하는 인스턴스 메쏘드 추가.
            //조건3) 자동차 클래스에 가격을 설정하는 인스턴스 메쏘드 추가.
            //조건4) 자동차 클래스에서 모델명을 가져오는 인스턴스 메쏘드 추가.
            //조건5) 자동차 클래스에서 가격을 가져오는 인스턴스 메쏘드 추가.
            //조건6) main()에서 매개변수가 있는 생성자를 사용하여 객체 생성하기.
            //조건7) 조건1 에서 생성한 객체를 사용하여 모든 속성 정보 출력.
            //조건8) 조건6 에서 생성한 객체를 사용하여 모든 속성 정보 출력.

            Console.WriteLine("---------- 문제 1 ----------");
            Class_mun1_Car mc = new Class_mun1_Car();
            mc.showCarInfo();

            Console.WriteLine("---------- 문제 2 ----------");
            Class_mun1_Car mc2 = new Class_mun1_Car("2. 현대","검정","5천만원","붕붕붕");
            mc2.showCarInfo();

            Console.WriteLine("---------- 문제 3 ----------");
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Class_mun3 m3 = new Class_mun3(arr);


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
            Console.WriteLine("\n---------- 문제 4 ----------");
            const int ROW = 5;
            const int COL = 3;

            int[,] arr4 = new int[ROW, COL];
            Random r = new Random();

            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    arr4[i, j] = r.Next(50, 100);
                    //Console.Write(arr4[i,j]+"\t");
                }
                //Console.WriteLine();
            }

            Class_mun4 m4 = new Class_mun4(arr4, ROW, COL);


            Console.WriteLine("\n---------- 문제 5 ----------");
            //5. 랜덤하게 이름을 생성하는 NameData 클래스 작성.
            //first[]   = {"김", "박", "이", "최", "장"};
            //mid[]     = {"가", "나", "다", "라", "마"};
            //last[]    = {"바", "사", "아", "자", "차"};

            //조건1) 풀네임을 저장하는 속성 추가.
            //조건2) 랜덤하게 풀네임을 만들어 반환하는 메쏘드 추가.

            string[] first  = { "김", "박", "이", "최", "장" };
            string[] mid    = { "가", "나", "다", "라", "마" };
            string[] last   = { "바", "사", "아", "자", "차" };

            string[] fullName = new string[50];

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{i+1}. \t");
                Class_mun5 m5 = new Class_mun5(first[r.Next(0, 5)], mid[r.Next(0, 5)], last[r.Next(0, 5)]);
            }

        }
    }
}
