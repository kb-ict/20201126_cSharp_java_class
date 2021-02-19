using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_arrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Array array = new Array();
            array.Sum(arr);
            array.Avg(arr);
            array.print();

        }
    }
}
