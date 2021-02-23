using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.view
{
    class Menu
    {   //스태틱 개념 ㅇ
        public const int MENU_MAIN_FORMAT_ERROR = 0;
        public const int MENU_MAIN_ADD = 1;
        public const int MENU_MAIN_VIEW = 2;
        public const int MENU_MAIN_RANDOM_ADD = 3;
        public const int MENU_MAIN_DELETE = 4;
        public const int MENU_MAIN_DELETE_ALL = 5;
        public const int MENU_MAIN_UPDATE = 6;
        public const int MENU_MAIN_EXIT = 7;

        public const int MENU_UPDATE_NAME = 1;
        public const int MENU_UPDATE_TEL = 2;
        public const int MENU_UPDATE_ADDR = 3;
        public const int MENU_UPDATE_EMAIL = 4;
        public const int MENU_UPDATE_EXIT = 5;

        
        public int mainMenu() /* public static int getMenu() // 객체생성 x 접근가능, 클래스메소드로 하거나 싱글톤 */
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("### 메인 메뉴 ###");
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5.전체 데이터 삭제");
            Console.WriteLine("6.주소록 정보 수정");
            Console.WriteLine("7.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu = 0;
            try
            {
                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                //Console.WriteLine(e.StackTrace);
                Console.WriteLine($"에러 메시지 : "+e.Message);
            }
            return menu;
        }

        public string delMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("### 삭제 메뉴 ###");
            Console.WriteLine("-----------------");
            Console.Write("삭제할 이름: ");
            /*string name = Console.ReadLine(); return name;*/
            return Console.ReadLine();
        }
        public int updateMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("### 수정 메뉴 ###");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. 이름 수정");
            Console.WriteLine("2. 전화번호 수정");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 이메일 수정");
            Console.WriteLine("5.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu =
                Convert.ToInt32(Console.ReadLine());
            return menu;
        }
    }
}
