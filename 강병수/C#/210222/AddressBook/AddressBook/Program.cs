using AddressBook.Control;
using AddressBook.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            StudentControl c = new StudentControl();

            while (true)
            {
                switch (m.mainMenu())
                {
                    case Menu.MAIN_MENU_ADD_ADDRESS:
                        c.addStudentInfo();
                        break;
                    case Menu.MAIN_MENU_READ_ADDRESS:
                        c.readStudentInfo();
                        break;
                    case Menu.MAIN_MENU_MODIFY_ADDRESS:
                        c.modifyStudentInfo(m.modifyMenu());
                        break;
                    case Menu.MAIN_MENU_RANDOM:
                        c.randData(100);
                        break;
                    case Menu.MAIN_MENU_REMOVE:
                        c.removeStudentInfo(m.delMenu());
                        break;
                    case Menu.MAIN_MENU_CLEAR:
                        c.removeAllInfo();
                        break;
                    case 0:
                        break;
                    case Menu.MAIN_MENU_EXIT:
                        Console.WriteLine("시스템 종료");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("잘못된 입력");
                        break;
                }
            }
        }
    }
}
