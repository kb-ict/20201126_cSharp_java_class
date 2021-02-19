using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_4
{
    class MyFileRead
    {
        public void fileRead()
        {
            string names = File.ReadAllText($"C:/Users/KB/Desktop/SW_Lesson/C_sharp/Class_practice_20210208/names.txt");
            Console.WriteLine("{0}", names);
        }
    }
}
