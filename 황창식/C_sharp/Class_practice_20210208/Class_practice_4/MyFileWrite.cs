using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_4
{
    class MyFileWrite
    {
        public void fileWrite(NameData[] arr)
        {
            using (StreamWriter outputFile = new StreamWriter($"C:/Users/KB/Desktop/SW_Lesson/C_sharp/Class_practice_20210208/names.txt"))
            {
                foreach (NameData name in arr)
                {
                    outputFile.WriteLine(name.FullName);
                    //outputFile.Write("/");
                }
            }
        }
    }
}
