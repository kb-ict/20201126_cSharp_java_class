using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Socket
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteAsync();
            //Console.ReadKey();
        }

        static async void WriteAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {

                }
                Console.WriteLine("1");
            });
            await Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                {

                }
                Console.WriteLine("2");
            });
        }
    }
}
