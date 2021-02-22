using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;
            int sci = 0;
            kor = 90;
            eng = 80;
            mat = 70;
            sci = 60;
            int sum;
            int ave;
            sum = kor + eng + mat + sci;
            ave = sum / 4;
            Console.WriteLine($"모든 과목의 총점은 {sum}이고 평균은 {ave}이다");
        }
    }
}
