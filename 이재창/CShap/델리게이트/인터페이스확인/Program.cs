using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스확인
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Test : ITest
    {
        public int Value { get; set; }

        public event EventHandler EventTest;
    }

    interface ITest
    {
        event EventHandler EventTest;
        int Value { get; set; }
    }
}
