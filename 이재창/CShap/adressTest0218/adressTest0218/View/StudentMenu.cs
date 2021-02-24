using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adressTest0218
{
    enum Menu { Add = 1, View, Rand, Remove, Update, Clear, Exit }
    enum UpdateMenu { Name = 1, Tel, Address, Email, Back }

    /// <summary>
    /// 주소록 메뉴 클래스
    /// </summary>
    public static class StudentMenu
    {
        /// <summary>
        /// 메인 메뉴를 보여줍니다.
        /// </summary>
        /// <returns>사용자에게 입력받은 정수값</returns>
        public static int ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------");
            Console.WriteLine("### 메인 메뉴 ###");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.주소록 추가");
            Console.WriteLine("2.주소록 보기");
            Console.WriteLine("3.주소록 랜덤 추가");
            Console.WriteLine("4.주소록 삭제");
            Console.WriteLine("5.주소록 수정");
            Console.WriteLine("6.주소록 전체 삭제");           
            Console.WriteLine("7.종료");
            Console.WriteLine("-----------------------");
            Console.Write("메뉴 선택: ");
            Console.ForegroundColor = ConsoleColor.White;
            var menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }

        /// <summary>
        /// 주소록 추가 메뉴를 보여줍니다.
        /// </summary>
        /// <returns>사용자에게 입력받은 정보의 Student객체</returns>
        public static Student ShowAddMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------");
            Console.WriteLine("### 입력 메뉴 ###");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("전화: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string tel = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("주소: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string address = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("이메일: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string email = Console.ReadLine();
            return new Student(RandData.GetId(), name, tel, address, email);
        }

        /// <summary>
        /// 주소록 삭제 메뉴를 보여줍니다.
        /// </summary>
        /// <returns>사용자에게 입력받은 ID</returns>
        public static string ShowRemoveMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------");
            Console.WriteLine("### 삭제 메뉴 ###");
            Console.WriteLine("------------------");
            Console.Write("아이디: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string id = Console.ReadLine();
            return id;
        }

        /// <summary>
        /// 주소록 수정 메뉴를 보여줍니다.
        /// </summary>
        /// <returns>사용자에게 입력받은 정수값</returns>
        public static int ShowUpdateMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------");
            Console.WriteLine("### 수정 메뉴 ###");
            Console.WriteLine("-----------------");
            Console.WriteLine("1.이름 수정");
            Console.WriteLine("2.전화번호 수정");
            Console.WriteLine("3.주소 수정");
            Console.WriteLine("4.이메일 수정");
            Console.WriteLine("5.뒤로가기");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            Console.ForegroundColor = ConsoleColor.White;
            var menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }
    }
}
