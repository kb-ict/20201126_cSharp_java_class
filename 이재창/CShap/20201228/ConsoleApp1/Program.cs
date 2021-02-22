using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.CursorVisible = false;
            Console.SetWindowSize(44, 21);
            Console.SetBufferSize(44, 21);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.SetCursorPosition(r.Next(1, 20) * 2, r.Next(1, 20));
                    Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                    Console.Write("★");
                }
                Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
