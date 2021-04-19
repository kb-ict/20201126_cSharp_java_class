using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "1";
            for (int i =  0; i< 20; i++)
            {
                Console.WriteLine((i+1) + "번째 수열: " + start);
                char number = start[0];
                int count = 0;
                string end = "";
                for (int j = 0; j < start.Length; j++)
                {
                    if (number == start[j])
                    {
                        count++;
                    }
                    else
                    {
                        //1121 1에서 2로 넘어가는 시점 등
                        end = end + number + count; //1이 2개
                        number = start[j];
                        count = 1;
                    }
                }
                end = end + number + count;
                start = end;
            }
            
        }
    }
}
