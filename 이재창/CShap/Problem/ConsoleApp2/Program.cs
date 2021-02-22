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
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                int count = 0; // 각 자리 숫자의 개수
                string end = string.Empty; // 문자열 누적시키는 변수
                Console.WriteLine($"{i + 1}번째 : {start}");
                char number = start[0]; // 내가 가리키는 숫자

                for (int j = 0; j < start.Length; j++) // 읽어들이기
                {
                    if (number != start[j])
                    {
                        end = end + number + count; // end = ""+'1'+1
                        number = start[j]; // 가리키는 숫자를 다른 걸로 바꿈
                        count = 1;  // count는 1로 초기화. 왜냐면다른 숫자가
                                    // 있어서 이 조건문으로 들어왔으니까
                    }
                    else
                    {
                        count++;
                    }
                }
                end = end + number + count;
                start = end;
            }
        }
    }
}
