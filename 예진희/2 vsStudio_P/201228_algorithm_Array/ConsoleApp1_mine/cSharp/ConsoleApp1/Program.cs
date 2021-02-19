using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] ab = new int[100];
            ab[0] = 10;
            ab[100] = 1;

            int ex = int.Parse(Console.ReadLine());
            // 입력 값에서 배열크기
            // c#, java가능, C =안됨
            int[] abce = new int[ex];
            Array.Sort(ab);     //배열 오름차순 정렬
            Array.Reverse(ab);  //배열 내림차순 정렬

            //--------------------- 1번 ------------------------
            //int[] num = new int[3];
            //num[] = int.Parse(Console.ReadLine());
            */



            /*
            Console.WriteLine("생성할 배열크기 입력");
            int ar = int.Parse(Console.ReadLine());
            int[] ar2 = new int[ar];
            Console.WriteLine($"크기 {ar2.Length}의 배열이 생성되었습니다.");
            int i = 0;
            int max = 0;
            for (i = 0; i < ar2.Length; i++)
            {
                Console.Write($"{i + 1}번째 값: ");
                ar2[i] = int.Parse(Console.ReadLine());

            }
            for (i = 0; i < ar2.Length; i++)
            {
                if (max < ar2[i])
                {
                    max = ar2[i];
                }

            }

            int min = ar2[0];
            for (i = 0; i < ar2.Length; i++)
            {
                if (min > ar2[i])
                {
                    min = ar2[i];
                }
            }
            Console.WriteLine($"최대값 {max}, 최솟값 {min}");

            //--------------------- 2번 ------------------------
            //각각 몇번째인지
            Console.WriteLine("2번문제. 각각 몇번째인지 ");
            for (i = 0; i < ar2.Length; i++)
            {
                if (ar2[i] == max)
                {
                    Console.WriteLine($"최대값 max는 {i + 1}번째 숫자입니다.");
                }

            }


            for (i = 0; i < ar2.Length; i++)
            {
                if (ar2[i] == min)
                {
                    Console.WriteLine($"최소값 min은 {i + 1}번째 숫자입니다.");
                }

            }
            */

            //--------------------- 3번 ------------------------
            int[] ar3 = new int[3];
            int i = 0;
            String blank = "";

            for (i = 0; i < ar3.Length; i++)
            {
                Console.Write($"{i + 1}번째 값: ");
                ar3[i] = int.Parse(Console.ReadLine());
                
            }
            int gab =  ar3[0] * ar3[1] * ar3[2] ;
            Console.WriteLine($"A x B x C = {ar3[0]} X {ar3[1]} X {ar3[2]} = {gab}");
            Console.WriteLine("");

            Console.WriteLine($"계산한 결과 {gab}에는 쓰였겠지머");

        }
    }
}

/*
//--------------------- 4번 ------------------------
Console.WriteLine("1. 답이 1번");
Console.WriteLine("1/2/3/4/5");
int dab1 = int.Parse(Console.ReadLine());
switch (dab1)
{
    case 1:
        Console.WriteLine("O");
        break;

    case 2: case 3:
    case 4: case 5:
        Console.WriteLine("X");
        break;
}
Console.WriteLine("2. 답이 2번");
Console.WriteLine("1/2/3/4/5");
int dab2 = int.Parse(Console.ReadLine());
switch (dab2)
{
    case 2:
        Console.WriteLine("O");
        break;

    case 1:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("X");
        break;
}
Console.WriteLine("3. 답이 3번");
Console.WriteLine("1/2/3/4/5");
int dab3 = int.Parse(Console.ReadLine());
switch (dab3)
{
    case 3:
        Console.WriteLine("O");
        break;

    case 1:
    case 2:
    case 4:
    case 5:
        Console.WriteLine("X");
        break;
}
Console.WriteLine("4. 답이 4번");
Console.WriteLine("1/2/3/4/5");
int dab4 = int.Parse(Console.ReadLine());
switch (dab4)
{
    case 4:
        Console.WriteLine("O");
        break;

    case 1:
    case 2:
    case 3:
    case 5:
        Console.WriteLine("X");
        break;
}
Console.WriteLine("5. 답이 5번");
Console.WriteLine("1/2/3/4/5");
int dab5 = int.Parse(Console.ReadLine());
switch (dab5)
{
    case 5:
        Console.WriteLine("O");
        break;

    case 1:
    case 2:
    case 3:
    case 4:
        Console.WriteLine("X");
        break;
}


}*/


