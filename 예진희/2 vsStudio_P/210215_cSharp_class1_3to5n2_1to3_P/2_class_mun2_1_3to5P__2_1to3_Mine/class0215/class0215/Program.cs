using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0215
{
    class Program
    {
        //public static int i = 1;

        static void Main(string[] args)
        {
            //3.아래의 배열의 값의 합과 평균을 구하는 클래스 작성.

            //조건1) int arr[] = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //조건2) 배열의 합과 평균을 속성으로 설정.
            //조건3) 배열의 합을 반환하는 인스턴스 메쏘드 추가.
            //조건4) 배열의 평균을 반환하는 인스턴스 메쏘드 추가.
            //조건5) main()에서 생성자의 매개변수로 배열 array 전달하여 객체 생성 및 합과 평균 출력.
            string line = "----------------";
            //Console.WriteLine($"\n{line} 문제 3 {line}");
            //int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; //_ 변하는 값은 외부에서 던진다.

            //오버로딩(중복정의)
            //ArrayTest1 at1 = new ArrayTest1(arr); // 1st
            //ArrayTest1 at2 = new ArrayTest1();    // 2nd
            //at2.sumAvg(arr);

            // 3rd : setter + 연산메소드 호출
            //ArrayTest1 at3 = new ArrayTest1();
            //at3.setArray(arr);
            //at3.sumAvg();

            Console.WriteLine($"\n{line} 문제 4 {line}");
            int[,] arr = new int[5, 3]
            {   {100,   90, 80 },
                {90,    90, 80 },
                {70,    80, 90 },
                {80,    70, 90 },
                {80,    80, 80 },
            };
            // 1명에 대한 정보
            //StudentScore st = new StudentScore(arr[0,0], arr[0,1], arr[0,2]);
            //st.calculator();

            //for (int i = 0; i < 5; i++)
            //{
            //        Console.WriteLine($"{i+1}번째 -------------");
            //        new StudentScore(arr[i,0], arr[i,1], arr[i,2]).calculator();
            //}
            StudentScore[] arrSt = new StudentScore[5];
            for (int i = 0; i < 5; i++)
            {   arrSt[i] = new StudentScore();
                for (int j = 0; j < 3; j++)
                {   if (j == 0)
                    {
                        arrSt[i].Kor = arr[i, j];
                    }
                    else if (j == 1)
                    {
                        arrSt[i].Eng = arr[i, j];
                    }
                    else if (j == 2)
                    {
                        arrSt[i].Math = arr[i, j];
                    }
                } arrSt[i].calculator();
            }

            // 1. 객체(인스턴스) 생성 > 2. 정보 넘겨줌 (인스턴스 변수에)
            // ★ 별도 점수 필요할 때
            for (int i = 0; i < 5; i++)
            {   arrSt[i] = new StudentScore();
                //for (int j = 0; j < 3; j++)
                //{ arrSt[i].setAllProperty(arr[i, 0], arr[i, 1], arr[i, 2]); }

                arrSt[i].setAllProperty(arr[i, 0], arr[i, 1], arr[i, 2]);
                arrSt[i].calculator();
            }

            //5.랜덤하게 이름을 생성하는 NameData 클래스 작성.

            //first[] = { "김", "박", "이", "최", "장" };
            //mid[] = { "가", "나", "다", "라", "마" };
            //last[] = { "바", "사", "아", "자", "차" };

            //조건1) 풀네임을 저장하는 속성 추가.
            //조건2) 랜덤하게 풀네임을 만들어 반환하는 메쏘드 추가.

            Console.WriteLine($"\n{line} 문제 5 / 내풀이.. {line}");

            string[] first = { "김", "박", "이", "최", "장" };
            string[] mid = { "가", "나", "다", "라", "마" };
            string[] last = { "바", "사", "아", "자", "차" };
            Random r = new Random();
            NameDataMun5_Mine[] irum = new NameDataMun5_Mine[15];
            for (int i = 0; i < irum.Length; i++)
            {
                irum[i] = new NameDataMun5_Mine();
                irum[i].setName(first[r.Next(0, 5)], mid[r.Next(0, 5)], last[r.Next(0, 5)]);
                Console.Write($"{i+1}번째 학생\t: {irum[i].makeName()}\n");
            }
        }

        //static public void makeSort()
        //{
        //    Console.WriteLine($"{i}번째");
        //    i++;
        //}
    }
}
