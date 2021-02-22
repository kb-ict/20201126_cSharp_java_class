using adressTest0218.control;
using adressTest0218.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    class Program
    {
        

        static void Main(string[] args) {
            Menu m = new Menu();
            StudentCtrl sc = new StudentCtrl();

            while (true) {
                switch (m.mainMenu()) {
                    case Menu.MENU_MAIN_ADD:
                        sc.addItem();
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        sc.viewItem();
                        break;
                    case Menu.MENU_MAIN_RANDOM_ADD:
                        sc.randData(10);
                        break;
                    case Menu.MENU_MAIN_DELETE:
                        sc.delItem(m.delMenu());
                        break;
                    case Menu.MENU_MAIN_DELETE_ALL:
                        sc.delItemAll();
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        sc.updateItem(m.updateMenu());
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    case Menu.MENU_MAIN_FORMAT_ERROR:
                        Console.WriteLine("잘못된 숫자를 입력하셨습니다.");
                        Console.WriteLine("메뉴를 다시 입력하여 주십시오.");
                        break;
                    default:
                        Console.WriteLine("잘못된숫자를 입력했습니다. 재입력 요망");
                        break;
                }
            }
        }

        
    }
}
