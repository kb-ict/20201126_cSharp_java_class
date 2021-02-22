using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 참조와_값
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.GetRefA() = 100;
            Console.WriteLine(t.GetRefA());

            int a = 10;
            ref int ra = ref t.GetRefA();
            Console.WriteLine(ra);
        }
    }

    class Test
    {
        int a = 10;

        public ref int GetRefA()
        {
            return ref a;
        }
        public int GetA()
        {
            return a;
        }
    }
}
