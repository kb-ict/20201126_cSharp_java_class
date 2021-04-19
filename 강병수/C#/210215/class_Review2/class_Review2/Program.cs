using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Review2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 3]
            {
                {100, 90, 80},
                {50, 60, 75},
                {39, 46, 100},
                {85, 70, 80 },
                {90, 83, 76 }
            };

            /* StudentScore student = new StudentScore(arr[0,0], arr[0,1], arr[0,2]);
            student.calculator(); */


            for (int i = 0; i < 5; i++)
            {
                {
                    StudentScore st = new StudentScore(arr[i, 0], arr[i, 1], arr[i, 2]);
                        st.calculator();
                }
            }
            Console.WriteLine("---------------------------------");

            StudentScore[] arrSt = new StudentScore[5];
            for (int i = 0; i < 5; i++)
            {
                arrSt[i] = new StudentScore();
                arrSt[i].setProperty(arr[i, 0], arr[i, 1], arr[i, 2]);
                arrSt[i].calculator();
            }
        }
    }
}

