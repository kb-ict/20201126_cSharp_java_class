using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answer
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1,2번 문제");
            Console.WriteLine("총 몇 개의 숫자를 입력받을까요?");
            int countNum = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자 입력 시작~!");
            int[] numberList = new int[countNum];
            for (int i = 0; i < countNum; i++)
            {
                Console.WriteLine($"{i + 1}번째 숫자 입력하기");
                numberList[i] = int.Parse(Console.ReadLine());
            }
            int max = numberList[0];
            int min = numberList[0];
            int maxTh = 1;
            int minTh = 1;
            for (int i = 0; i < countNum; i++)
            {
                if (numberList[i] > max)
                {
                    max = numberList[i];
                    maxTh = i + 1;
                }

                if (numberList[i] < min)
                {
                    min = numberList[i];
                    minTh = i + 1;
                }
            }
            Console.WriteLine($"max : {max}, min : {min}");
            Console.WriteLine($"최댓값은 {maxTh}번째, 최솟값은 {minTh}번째 입니다.");


            Console.WriteLine("3번 문제");
            Console.WriteLine("A 값 입력");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("B 값 입력");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("C 값 입력");
            int C = int.Parse(Console.ReadLine());

            int result = A * B * C;
            string sResult = result.ToString();
            int[] numCount = new int[10];

            for (int i = 0; i < sResult.Length; i++)
            {
                numCount[int.Parse(sResult[i].ToString())]++;
            }
            Console.WriteLine($"AxBxC ={result}");
            for (int i = 0; i < numCount.Length; i++)
            {
                if (numCount[i] > 0)
                    Console.WriteLine($"{i}은 {numCount[i]}번 나옴");
            }


            int[] answer = new int[] { 5, 4, 1, 2, 3 };
            string[] que = new string[5] { "다음 중 사람인 것은?", "1+1은?", "2+2는?", "3+3은?", "4+4는?" };
            string[] bogi = new string[5] { "1. 강아지 2.원숭이 3. 고양이 4. 햄스터 5. 이동준",
                                            "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                            "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                            "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                            "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]"};
            string queResult = "";
            int totalPoint = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(que[i]);
                Console.WriteLine(bogi[i]);
                Console.WriteLine("정답은?");
                int ans = int.Parse(Console.ReadLine());

                if (answer[i] == ans)
                {
                    queResult += "O";
                    if (i == 0 || i == 4)
                        totalPoint += 10;
                    else if (i == 1)
                        totalPoint += 20;
                    else
                        totalPoint += 30;
                }
                else
                {
                    queResult += "X";
                }
            }

            Console.WriteLine($"결과는 {queResult}이고, 총 점은 {totalPoint}입니다.");

            Console.WriteLine("5번 문제");
            queResult = "";
            Console.WriteLine("문제 개수는?");
            int countQue = int.Parse(Console.ReadLine());

            string[] queList = new string[countQue];
            string[] answerList = new string[countQue];

            for (int i = 0; i < countQue; i++)
            {
                Console.WriteLine($"{i + 1}번째 문제를 적어주세요.");
                queList[i] = Console.ReadLine();
                Console.WriteLine("객관식 문제입니까?(Y 혹은 Yes로 입력시에만 객관식)");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.ToUpper().Contains("Y"))
                {
                    Console.WriteLine("보기도 같이 적어주세요. 보기는 3개입니다.");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"{j + 1}번");
                        string selector = Console.ReadLine();
                        queList[i] += "\n" + (j + 1) + "번 " + selector;
                    }
                    Console.WriteLine($"{i + 1}번째 문제의 정답을 적어주세요.");
                    answerList[i] = Console.ReadLine();
                    while (int.Parse(answerList[i]) < 1 || int.Parse(answerList[i]) > 3)
                    {
                        Console.WriteLine($"보기는 1번부터 3번까지입니다. 다시 적어주세요.");
                        answerList[i] = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine($"{i + 1}번째 문제의 정답을 적어주세요.");
                    answerList[i] = Console.ReadLine();
                }
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine();
            }

            do
            {
                Console.WriteLine("이제부터 문제 풀겁니다. 그만하고 싶으면 ctrl+c 누르세요.");
                for (int i = 0; i < countQue; i++)
                {
                    Console.WriteLine(queList[i]);
                    Console.WriteLine("정답은?");
                    string ans = Console.ReadLine();

                    if (answerList[i] == ans)
                    {
                        queResult += "O";
                    }
                    else
                    {
                        queResult += "X";
                    }
                }
                Console.WriteLine(queResult);

                string resultO = "맞은 문제는\n";
                string resultX = "틀린 문제는\n";
                int correctCount = 0;
                for (int i = 0; i < queResult.Length; i++)
                {
                    if (queResult[i] == 'O')
                    {
                        resultO += $"{i + 1}번 문제\n";
                        correctCount++;
                    }
                    else
                    {
                        resultX += $"{i + 1}번 문제\n";
                    }

                }
                if (correctCount == 0)
                    resultO = "맞은 문제는 없습니다.";
                else if (correctCount == countQue)
                    resultX = "틀린 문제는 없습니다.";

                Console.WriteLine("총 " + correctCount + "개 맞췃습니다.");
                Console.WriteLine(resultO);
                Console.WriteLine(resultX);
                queResult = "";
            } while (true);

        }
    }
}
