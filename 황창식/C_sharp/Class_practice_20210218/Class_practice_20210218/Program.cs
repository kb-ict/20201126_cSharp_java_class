using Class_practice_20210218.view;
using System;


namespace Class_practice_20210218
{
    class Program : Messages
    {
        const string MENU_ADD_ITEM = "1";
        const string MENU_VIEW_ITEM = "2";
        const string MENU_FIX_ITEM = "3";
        const string MENU_DEL_ITEM = "4";
        const string MENU_EXIT = "5";

        public static void Main(string[] args)
        {
            StudentMenu sm = new StudentMenu();
            while (true)
            {
                switch (sm.getMenu())
                {
                    case MENU_ADD_ITEM:
                        sm.addItemMenu();
                        break;
                    case MENU_VIEW_ITEM:
                        sm.viewMenu();
                        break;
                    case MENU_FIX_ITEM:
                        sm.fixItemMenu();
                        break;
                    case MENU_DEL_ITEM:
                        sm.deleteItemMenu();
                        break;
                    case MENU_EXIT:
                        exitMessage();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            }
        }
    }
}