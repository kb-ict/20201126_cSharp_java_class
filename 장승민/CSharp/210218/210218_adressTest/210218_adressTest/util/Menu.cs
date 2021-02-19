using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _210218_adressTest.control;

namespace _210218_adressTest.util
{
    class Menu
    {
        StudentHandler sh = new StudentHandler();
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDOM = 3;
        const int MENU_DEL = 4;
        const int MENU_REVISE = 5;
        const int MENU_ALL_DEL = 6;
        const int MENU_EXIT = 7;
        public  void menuSelector()
        {

            while (true)
            {
                switch (sh.getMenu())
                {
                    case MENU_ADD:
                        sh.addInfo();

                        break;
                    case MENU_VIEW:
                        sh.viewInfo();

                        break;
                    case MENU_RANDOM:
                        sh.randomMaker();

                        break;
                    case MENU_DEL:
                        sh.infoDel();

                        break;
                    case MENU_REVISE:
                        sh.reviseInfo();

                        break;
                    case MENU_ALL_DEL:
                        sh.allInfoDel();

                        break;
                    case MENU_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
