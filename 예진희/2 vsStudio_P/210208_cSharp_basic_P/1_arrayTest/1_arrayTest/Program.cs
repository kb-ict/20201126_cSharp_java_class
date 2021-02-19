using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_arrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배열 초기화
            Console.WriteLine("--------------1차원 배열 초기화1--------------");
            // (-) cs가 클래스개념 .java와 동일하게 cs가 계속추가됨, 배열이름 = 배열시작 주소값
            //int arrInt[] = { 10, 20, 30, 40 }; 지원 안됨
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i] + "  ");
                string str = string.Format("배열[{0}]:{1}", i, arrInt[i]);
                //printf(c언어)와 비슷 [{0}] = i, {1} = arrInt[i]
                Console.WriteLine(str);
                //디버깅 f5, ctrl f5(디버깅 없이 시작)
            }

            // 1차원 배열 초기화2
            Console.WriteLine("--------------1차원 배열 초기화2--------------");
            // (-) new = 객체생성 메모리공간에 잡힘
            char[] arrCh = new char[4] { '이', '김', '박', '홍' };
            for (int i = 0; i < arrCh.Length; i++)
            {   // System.out.println()
                // System.out.print()
                Console.Write(arrCh[i] + "  ");
            }
            Console.WriteLine("\n");
            // 2차원 배열 초기화1
            Console.WriteLine("--------------2차원 배열 초기화1--------------");
            int[,] arrInt2 = {
                {1, 2, 3}, {4, 5, 6} //2행 3열, 바깥쪽기준, 안쪽(계속 변하는거) 영소문자 대조
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrInt2[i, j] + "  ");
                }
                Console.WriteLine(); //줄바꿈
            }

            // 2차원 배열 초기화2
            Console.WriteLine("--------------2차원 배열 초기화2--------------");
            // 상수변수, 자바의 final
            const int SIZE_ROW = 2;
            const int SIZE_COL = 3;

            int[,] arrInt2_1 = new int[SIZE_ROW, SIZE_COL]
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_COL; j++)
                {
                    Console.Write(arrInt2_1[i, j] + "  ");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화3
            Console.WriteLine("--------------2차원 배열 초기화3--------------");
            string[][] arrStr1 = new string[2][];
            arrStr1[0] = new string[] { "김길동", "홍길동", "박길동" };
            arrStr1[1] = new string[] { "이길동" };
            // 모양
            // |<- arrStr 위치정보
            // ㅁㅁㅁ
            // ㅁ

            for (int i = 0; i < arrStr1.Length; i++)
            {
                for (int j = 0; j < arrStr1[i].Length; j++)
                {
                    Console.Write(arrStr1[i][j] + "  ");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화4
            Console.WriteLine("--------------2차원 배열 초기화4--------------");
            int[][] arrInt2_4 = new int[3][];
            for (int i = 0; i < arrInt2_4.Length; i++)
            {
                //arrStr1[0] = new string[] { "김길동", "홍길동", "박길동" };
                arrInt2_4[i] = new int[i + 1];
                for (int j = 0; j < arrInt2_4[i].Length; j++)
                {
                    arrInt2_4[i][j] = 10 + j;
                    Console.Write(arrInt2_4[i][j] + "  ");
                }
                Console.WriteLine("\n");
            }

            // foreach (향상된 for문) 1차원 1
            Console.WriteLine("--------------foreach (향상된 for문) 1차원 1--------------");
            int[] arrEach1 = { 1, 2, 3, 4, 5 };
            // c# ↓ / javafor (int i : arrEach1)
            foreach (int i in arrEach1)
            {
                Console.WriteLine(i);
            }

            // foreach (향상된 for문) 2차원 1
            Console.WriteLine("--------------foreach (향상된 for문) 2차원 1--------------");
            string[,] arrEach2 = {
            {"홍길동", "김길동"},
            {"hong", "kim"}};

            foreach (string str in arrEach2)
            {
                Console.Write(str+ "  ");
            }
            Console.WriteLine();

            //int[][] arrInt2_4 = new int[3][]; 이거 많이씀
        }
    }
}
