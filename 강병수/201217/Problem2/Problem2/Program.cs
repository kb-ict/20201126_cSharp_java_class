using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("초 입력: ");
            int second = int.Parse(Console.ReadLine());

            int minute = second / 60;
            int sec = second % 60;

            Console.Write($"{minute}분 {sec}초\n");
        }
    }
}
