using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string[] first = { "김", "박", "이", "최", "장" };
            string[] mid = { "가", "나", "다", "라", "마" };
            string[] last = { "바", "사", "아", "자", "차" };

            NameData[] names = new NameData[50];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = new NameData(first[r.Next(0, 5)], mid[r.Next(0, 5)], last[r.Next(0, 5)]);
                // Console.WriteLine(names[i].FullName);
            }

            MyFileWrite file1 = new MyFileWrite();
            file1.fileWrite(names);

            MyFileRead readFile1 = new MyFileRead();
            readFile1.fileRead();
        }
    }
}
