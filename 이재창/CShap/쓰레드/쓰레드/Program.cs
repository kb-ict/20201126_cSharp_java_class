using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 쓰레드
{
    class Program
    {
        static void Main(string[] args)
        {          
            Thread th1 = new Thread(ThreadFunc);
            th1.Start();
            //th1.IsBackground = true;
        }

        static void ThreadFunc()
        {
            string path = @"D:\javatest";
            Console.WriteLine(path);
            SubDirList(path);
        }

        static void SubDirList(string path)
        {
            DirectoryInfo start = new DirectoryInfo(path);
            FileInfo[] files = start.GetFiles();
            DirectoryInfo[] directories = start.GetDirectories();

            foreach (var file in files)
            {
                Console.WriteLine($"\t파일:{file.FullName}");
                Thread.Sleep(1);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine($"폴더:{directory.FullName}");
                Thread.Sleep(1);
                SubDirList(directory.FullName);
            }                      
        }

    }
}
