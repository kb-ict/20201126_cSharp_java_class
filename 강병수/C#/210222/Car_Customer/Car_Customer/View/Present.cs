using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Customer.View
{
    class Present
    {
        public int mainMenu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     차량 정보 v1.0");
            Console.WriteLine("=======================");
            Console.WriteLine(" 1. 차량 정보 등록");
            Console.WriteLine(" 2. 차량 정보 보기");
            Console.WriteLine(" 3. 차량 정보 수정");
            Console.WriteLine(" 4. 차량 정보 삭제");
            Console.WriteLine(" 5. 정보 전체 삭제");
            Console.WriteLine(" 6. 프로그램 종료");
            Console.WriteLine("=======================");
            Console.Write("번호 선택: ");
            return int.Parse(Console.ReadLine()); ;
        }

        public int modifyMenu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     차량 정보 수정 ");
            Console.WriteLine("=======================");
            Console.Write("수정할 정보의 번호를 입력: ");
            return int.Parse(Console.ReadLine());
        }

        public int deleteMenu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("       정보 삭제 ");
            Console.WriteLine("=======================");
            Console.WriteLine("삭제할 정보의 번호를 입력하시오: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
