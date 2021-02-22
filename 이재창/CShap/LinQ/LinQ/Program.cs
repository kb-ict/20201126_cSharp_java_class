using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var test1 = from a in Enumerable.Range(1, 10)
                       where a % 2 == 0
                       select a;

            var test2 = Enumerable.Range(1, 10).Where(a => a % 2 == 0).Select(a => new { Value = a, Name = "둘리" });

            foreach (var t in test2)
            {
                Console.WriteLine(t);
            }

            var test3 = test2.Single(p => p.Value == 4);

            Console.WriteLine(test3);*/

            string str = "12*10+30";

            string[] strs = str.Split(new char[] { '*', '+' });
            foreach (var s in strs)
            {
                Console.WriteLine(s);
            }

        }
    }
}
