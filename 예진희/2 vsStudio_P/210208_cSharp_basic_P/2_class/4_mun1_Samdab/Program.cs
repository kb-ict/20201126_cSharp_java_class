using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_mun1_Samdab
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.showCarInfo();

            Car c2 = new Car("현대", "흰색", "G80", "6천만원");
            c2.showCarInfo();

            // 입력 처리
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            Console.WriteLine($"이름 : {name}");

            Console.Write("나이 입력: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"나이 : {age}");
        }
    }
}
