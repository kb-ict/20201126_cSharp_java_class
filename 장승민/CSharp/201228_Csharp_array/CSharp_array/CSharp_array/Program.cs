using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array= new int[100];
            //int ex = int.Parse(Console.ReadLine());
            //int[] abcd = new int[ex];
            //Array.Sort(array);
            //Array.Reverse(array);

           /* Console.WriteLine("1번문제");
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("최대값 :" + array[num - 1]);
            Console.WriteLine("최소값 :" + array[0]);

            Console.WriteLine("2번문제");
            int num2 = int.Parse(Console.ReadLine());
            int[] array2= new int[num2];
            for (int i = 0; i < num2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            int max = 0;
            for (int i = 0; i < num2; i++)
            {
                if (array2[i] > temp)
                {
                    temp = array2[i];

                    max = (i + 1);
                }
            }

            int min = 0;
            for (int j = 0; j < num2; j++)
            {
                if (array2[j] < temp)
                {
                    temp = array2[j];

                    min = (j + 1);
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);



            Console.WriteLine("3번 문제");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int mul = a * b * c;
            string mulstring = Convert.ToString(mul);   //자리수갯수를 구하기위해 string변수로 치환
            int[] arr = new int[mulstring.Length];
            int zero = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;
            int seven = 0;
            int eight = 0;
            int nine = 0;

            for (int i = 0; i < mulstring.Length; i++)
            {
                arr[i] = mul % 10;
                mul = mul / 10;

            }

            for (int i = 0; i < mulstring.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zero++;
                }
                else if (arr[i] == 1)
                {
                    one++;
                }
                else if (arr[i] == 2)
                {
                    two++;
                }
                else if (arr[i] == 3)
                {
                    three++;
                }
                else if (arr[i] == 4)
                {
                    four++;
                }
                else if (arr[i] == 5)
                {
                    five++;
                }
                else if (arr[i] == 6)
                {
                    six++;
                }
                else if (arr[i] == 7)
                {
                    seven++;
                }
                else if (arr[i] == 8)
                {
                    eight++;
                }
                else if (arr[i] == 9)
                {
                    nine++;
                }
            }
            Console.WriteLine(zero);
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);
            Console.WriteLine(six);
            Console.WriteLine(seven);
            Console.WriteLine(eight);
            Console.WriteLine(nine);

          *//*  //3번문제
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int cnt = 0;

            int mul = a * b * c;
            char[] num = mul.ToString().ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j].ToString() == i.ToString())
                    {
                        cnt++;
                    }
                }
                Console.WriteLine(cnt);
                cnt = 0;
            }*//*

            Console.WriteLine("4번문제");
            int[] problem = { 2, 4, 5, 1, 3 };
            
            int[] solution = new int[5];
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i+1)+"번 문제 정답을 입력하시오. ");
                solution[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (problem[i] == solution[i]&&i==0|| problem[i] == solution[i] && i == 4)
                {
                    score = score + 10;
                }
                else if (problem[i] == solution[i] && i == 1)
                {
                    score = score + 30;
                }
                else if (problem[i] == solution[i] && i == 2|| problem[i] == solution[i] && i == 3)
                {
                    score = score + 25;
                }
               

                if (problem[i]==solution[i])
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write("X");
                }
            }
            Console.WriteLine();
            Console.WriteLine("총점은 " +score+"점 입니다");*/

            Console.WriteLine("5번문제 ver1");
            Console.WriteLine("문제의 갯수를 입력하시오.");
            int problemNum = int.Parse(Console.ReadLine());
            int[] ver1Problem = new int[problemNum];
            int[] ver1Solution = new int[problemNum];
            for (int i = 0; i < problemNum; i++)
            {
                ver1Problem[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < problemNum; i++)
            {
                ver1Solution[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
