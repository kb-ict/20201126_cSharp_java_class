using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
#if false
            #region 1,2번
            int[] arr;
            int min = 0, max = 0, minIdx = 0, maxIdx = 0;
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = arr[i];
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                    minIdx = i;
                }
                if (max < arr[i])
                {
                    max = arr[i];
                    maxIdx = i;
                }
            }
            Console.WriteLine($"최댓값 = {max} {maxIdx + 1}번째, 최솟값 = {min} {minIdx + 1}번째");  
            #endregion
            #region 3번
            int[] arr = new int[10];
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int d = a * b * c;
            int result = d;

            while (d > 0)
            {
                arr[d % 10]++;
                d /= 10;
            }

            Console.Write($"계산결과 {result} 에는 ");
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] > 0)
                    Console.Write($"{i}이 {arr[i]}번 ");
            } 
            #endregion
            #region 4번
            int[] answer = new int[] { 1, 2, 3, 3, 2 }; // 정답지
            int[] myAnswer = new int[5]; // 내가 선택한 답
            string strOX = string.Empty;
            int score = 0;

            Console.WriteLine("문제1. int의 설명으로 맞는것은?");
            Console.WriteLine("1. 정수형 자료형이다.");
            Console.WriteLine("2. 실수형 자료형이다.");
            Console.WriteLine("3. 문자형 자료형이다.");
            Console.Write("정답은? : ");
            myAnswer[0] = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("문제2. 다음 중 c#소스파일의 확장자 인것은?");
            Console.WriteLine("1. .cpp");
            Console.WriteLine("2. .cs");
            Console.WriteLine("3. .java");
            Console.Write("정답은? : ");
            myAnswer[1] = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("문제3. 프로그래밍에서 함수의 설명으로 틀린것은?");
            Console.WriteLine("1. 코드를 재활용 할 수 있다.");
            Console.WriteLine("2. 주로 동적인 기능을 가진다.");
            Console.WriteLine("3. 함수는 주소를 가지지 않는다.");
            Console.Write("정답은? : ");
            myAnswer[2] = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("문제4. 다음중 c#에서 배열의 선언 방법인것은?");
            Console.WriteLine("1. int a[] = {1, 2, 3};");
            Console.WriteLine("2. a = [1, 2, 3]");
            Console.WriteLine("3. int[] a = new int[] {1, 2, 3};");
            Console.Write("정답은? : ");
            myAnswer[3] = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("문제5. int a = 10;");
            Console.WriteLine("int b = a++;");
            Console.WriteLine("위 코드에서 변수 b의 값은?");
            Console.WriteLine("1. 9");
            Console.WriteLine("2. 10");
            Console.WriteLine("3. 11");
            Console.Write("정답은? : ");
            myAnswer[4] = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (myAnswer[i] == answer[i])
                {
                    strOX += "O";
                    if (i == 0 || i == 4)
                        score += 10;
                    else
                        score += 5;
                }
                else
                {
                    strOX += "X";
                }
            }

            Console.WriteLine(strOX);
            Console.WriteLine($"총점 = {score}점"); 
            #endregion
            #region 5번
            // 변수 선언
            string[] answer;
            string[] problem;
            string strOX = string.Empty;

            // 콘솔 세팅
            Console.Title = "문제와 정답은 내가 만든다";
            Console.SetWindowSize(60, 25);
            Console.SetBufferSize(60, 25);

            // 문제 갯수 지정
            Console.Write("문제 갯수 : ");
            int pCount = int.Parse(Console.ReadLine());
            answer = new string[pCount];
            problem = new string[pCount];

            // 문제와 답 입력
            for (int i = 0; i < pCount; i++)
            {
                Console.WriteLine($"{i + 1}번째 문제");
                Console.Write("문제 입력 : ");
                problem[i] = Console.ReadLine();
                Console.Write("정답 입력 : ");
                answer[i] = Console.ReadLine();
            }
            Console.Clear();

            while (true)
            {
                // 문제 풀기 시작
                for (int i = 0; i < pCount; i++)
                {
                    Console.WriteLine($"문제{i + 1}번");
                    Console.WriteLine(problem[i]);
                    string myAnswer = Console.ReadLine();
                    Console.Clear();
                    if (myAnswer == answer[i])
                    {
                        strOX += "○";
                    }
                    else
                    {
                        strOX += "X";
                    }
                }

                //O와X로 정답현황 표시
                Console.WriteLine(strOX);

                // 맞춘 문제와 틀린 문제 표시
                int cnt = 0;
                for (int i = 0; i < strOX.Length; i++)
                {
                    if (strOX[i] == '○') cnt++;
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"{pCount}개의 문제 중");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(cnt);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"개 맞춤");

                for (int i = 0; i < strOX.Length; i++)
                {
                    if (strOX[i] == '○')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{i + 1}번 맞춤");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{i + 1}번 틀림");
                    }
                }

                // 잠시 정지용
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("계속 하시려면 엔터를 눌러주십시오...");
                Console.ReadKey();

                // OX를 초기화
                strOX = string.Empty;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            #endregion
#endif

            #region 1번
            int[] arr;
            int min = 0, max = 0;
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = arr[i];
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"최댓값 = {max}, 최솟값 = {min}");
            #endregion
        }
    }
}
