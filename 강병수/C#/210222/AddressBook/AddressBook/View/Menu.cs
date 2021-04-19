using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.View
{
    class Menu
    {
        public const int MAIN_MENU_ADD_ADDRESS = 1;
        public const int MAIN_MENU_READ_ADDRESS = 2;
        public const int MAIN_MENU_MODIFY_ADDRESS = 3;
        public const int MAIN_MENU_RANDOM = 4;
        public const int MAIN_MENU_REMOVE = 5;
        public const int MAIN_MENU_CLEAR = 6;
        public const int MAIN_MENU_EXIT = 7;

        public int mainMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("  주소록 관리 v1.0");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3. 주소록 정보 수정");
            Console.WriteLine("4. 주소록 랜덤 생성");
            Console.WriteLine("5. 주소록 정보 삭제");
            Console.WriteLine("6. 주소록 정보 모두 삭제");
            Console.WriteLine("7. 종료");
            Console.WriteLine("--------------------");
            Console.Write("메뉴 선택: ");
            int menu = 0;
            try
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러: " + e.Message);
                Console.WriteLine("잘못된 숫자 입력, 다시 입력하시오");
            }
            return menu;
        }

        public string delMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(" 주소록 정보를 삭제");
            Console.WriteLine("--------------------");
            Console.Write("삭제할 정보의 ID를 입력하세요: ");
            return Console.ReadLine();
        }

        public string modifyMenu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("수정할 정보의 ID 입력");
            Console.WriteLine("--------------------");
            Console.Write("ID 입력: ");
            return Console.ReadLine();
        }
    }
    

}
