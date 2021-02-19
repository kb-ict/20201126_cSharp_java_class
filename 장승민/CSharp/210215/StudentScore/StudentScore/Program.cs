using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 3]{
                {100,90,80 },
                {90,90,80 },
                {80,70,90 },
                {90,80,80 },
                {80,90,80 }
            };
            /*StudentScore st = new StudentScore(arr[0,0], arr[0,1], arr[0,2]);
            st.calculator();
            */
            StudentScore[] arrSt = new StudentScore[5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    new StudentScore(arr[i, j], arr[i, j], arr[i, j]).calculator();
                }
            }
        }
    }
}
