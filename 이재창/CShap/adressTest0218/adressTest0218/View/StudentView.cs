using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adressTest0218
{
    public static class StudentView
    {
        public static void View(StudentManager manager)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (manager.Students.Count > 0)
                Console.WriteLine("-----------------------");

            for (int i = 0; i < manager.Students.Count; i++)
            {
                Console.WriteLine($"번호: {i + 1}");
                Console.WriteLine($"아이디: {manager.Students[i].Id}");
                Console.WriteLine($"이름: {manager.Students[i].Name}");
                Console.WriteLine($"전화: {manager.Students[i].Tel}");
                Console.WriteLine($"주소: {manager.Students[i].Address}");
                Console.WriteLine($"이메일: {manager.Students[i].Email}");
                Console.WriteLine("-----------------------");
                Thread.Sleep(50);
            }
        }

        public static int GetMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.주소록 추가");
            Console.WriteLine("2.주소록 보기");
            Console.WriteLine("3.주소록 랜덤 추가");
            Console.WriteLine("4.주소록 삭제");
            Console.WriteLine("5.주소록 전체 삭제");
            Console.WriteLine("6.주소록 수정");
            Console.WriteLine("7.종료");
            Console.WriteLine("-----------------------");
            Console.Write("메뉴 선택: ");
            Console.ForegroundColor = ConsoleColor.White;
            var menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }
    }
}
