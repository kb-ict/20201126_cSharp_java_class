using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ab = new int[100];
            ab[0] = 10;
            //ab[100] = 1;
            int ex = int.Parse(Console.ReadLine());
            int[] abcd = new int[ex];
            Array.Sort(ab);
            Array.Reverse(ab);


        }
    }
}
