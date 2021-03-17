using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adressTest0218.control;

namespace adressTest0218.util
{
    class StudentMenu
    {
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDOM_ADD = 3;
        const int MENU_DEL = 4;
        const int MENU_EXIT = 5;
        const int MENU_CLEAN = 6;
        const int MENU_MODIFY = 7;
        StudentHandler studentHandler = new StudentHandler();

        public StudentMenu(){
            /*Boolean i = true;
            while (i)
            {
                switch (getMenu())
                {
                    case MENU_ADD:
                        studentHandler.addItem();
                        break;
                    case MENU_VIEW:
                        studentHandler.viewItem();
                        break;
                    case MENU_RANDOM_ADD:
                        studentHandler.randItem();
                        break;
                    case MENU_DEL:
                        studentHandler.delItem();
                        break;

                    case MENU_EXIT:
                        Console.WriteLine("프로그램 종료");
                        //Environment.Exit(0);
                        i = false;
                        break;

                    case MENU_CLEAN:
                        studentHandler.cleanItem();
                        break;

                    case MENU_MODIFY:
                        modifyMenu();
                        break;

                }
            }*/
        }


        public int getMenu()
        {
            int menu;
            Console.WriteLine("----------------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 정보 추가");
            Console.WriteLine("4.주소록 삭제");
            Console.WriteLine("5.종료");
            Console.WriteLine("6.주소록 전체 삭제");
            Console.WriteLine("7.주소록 수정");
            Console.WriteLine("----------------------");
            Console.WriteLine("메뉴 선택");
            do
            {
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("다시 입력하세요(번호1~7)");
                }

            } while (true);

            return menu;
        }

        public void modifyMenu()
        {
            

            Console.WriteLine("----------------------");
            Console.WriteLine("주소록 수정");
            Console.WriteLine("----------------------");
            Console.WriteLine("1.이름 수정");
            Console.WriteLine("2.전화번호 수정");
            Console.WriteLine("3.주소 수정");
            Console.WriteLine("4.이메일 수정");
            Console.WriteLine("----------------------");
            Console.Write("항목 입력: ");
            int i;
            do
            {
                try
                {
                    
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i>0 || i<5)
                        break;
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("다시 입력하세요(번호1~4)");
                }

            } while (true);
     
            studentHandler.modifyItem(i);
           

        }

        
    }

    
}
