using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 델리게이트
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegate @delegate = (ThreadStart)Test;            
        }

        static void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
