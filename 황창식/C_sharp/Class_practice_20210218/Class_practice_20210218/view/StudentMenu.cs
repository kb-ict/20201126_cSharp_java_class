using Class_practice_20210218.controller;
using System;

namespace Class_practice_20210218.view
{
    class StudentMenu : Messages
    {
        const string VIEW_ONE = "1";
        const string VIEW_ALL = "2";
        const string VIEW_GOBACK = "3";

        const string ADD_SELF = "1";
        const string ADD_RND = "2";
        const string ADD_GOBACK = "3";

        const string DEL_SCH = "1";
        const string DEL_ALL = "2";
        const string DEL_GOBACK = "3";

        StudentController sc = new StudentController();

        // 메인 메뉴
        public string getMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 주소록 관리 프로그램 v1.0");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3. 주소록 정보 수정");
            Console.WriteLine("4. 주소록 정보 삭제");
            Console.WriteLine("5. 종료");
            Console.WriteLine("---------------------------");
            Console.Write("메뉴 선택 : ");
            return Console.ReadLine();
        }

        // 정보 추가 메뉴
        public void addItemMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(" 주소록 정보 추가");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. 직접 입력하기");
                Console.WriteLine("2. 랜덤 정보 추가");
                Console.WriteLine("3. 뒤로가기");
                Console.WriteLine("---------------------------");
                Console.Write("메뉴 선택 : ");

                switch (Console.ReadLine())
                {
                    case ADD_SELF:
                        sc.addItem();
                        break;
                    case ADD_RND:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("추가할 주소록 수량을 입력하세요 : ");
                        int count = Convert.ToInt32(Console.ReadLine());
                        sc.addRandomItem(count);
                        break;
                    case ADD_GOBACK:
                        return;
                    default:
                        sc.wrongInput();
                        break;
                }
            }
        }

        // 정보 탐색 메뉴
        public void viewMenu()
        {
            if(sc.getMembers().Count < 1)
            {
                noInfo();
            }
            else
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(" 주소록 정보 탐색");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("1. 주소록 선택하기");
                    Console.WriteLine("2. 전체 보기");
                    Console.WriteLine("3. 뒤로가기");
                    Console.WriteLine("---------------------------");
                    Console.Write("메뉴 선택 : ");

                    switch (Console.ReadLine())
                    {
                        case VIEW_ONE:
                            sc.viewOneInfo();
                            break;
                        case VIEW_ALL:
                            sc.viewAll();
                            break;
                        case VIEW_GOBACK:
                            return;
                        default:
                            sc.wrongInput();
                            break;
                    }
                }
            }
        }

        // 정보 삭제 메뉴
        public void deleteItemMenu()
        {
            if(sc.getMembers().Count < 1)
            {
                noInfo();
            }

            else
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(" 주소록 정보 삭제");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("1. 검색하여 삭제");
                    Console.WriteLine("2. 전체 삭제");
                    Console.WriteLine("3. 뒤로가기");
                    Console.WriteLine("---------------------------");
                    Console.Write("메뉴 선택 : ");

                    switch (Console.ReadLine())
                    {
                        case DEL_SCH:
                            inputDeleteItem();
                            break;
                        case DEL_ALL:
                            sc.deleteAll();
                            return;
                        case DEL_GOBACK:
                            return;
                        default:
                            wrongInput();
                            break;
                    }
                }
            }
        }

        // 삭제 정보 선택
        public void inputDeleteItem()
        {
            sc.viewAll();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.Write("삭제할 학생의 이름을 입력하세요(돌아가기 : -1) : ");
                string input = Console.ReadLine();
                if(input == "-1")
                {
                    return;
                }
                else
                {
                    sc.choiceDeleteItem(input);
                }
            }
        }

        // 정보 수정 메뉴
        public void fixItemMenu()
        {
            if(sc.getMembers().Count < 1)
            {
                noInfo();
            }
            else
            {
                while (true)
                {
                    sc.viewAll();
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                    Console.Write("수정할 학생의 이름을 입력하세요(돌아가기 : -1, 빈 학생 정보 : 0) : ");
                    string input = Console.ReadLine();
                    // 돌아가기
                    if (input == "-1")
                        return;
                    // 빈 학생 정보 수정(또는 추가)
                    else if (input == "0")
                    {
                        sc.emptyItemFix();
                    }
                    else
                    {
                        sc.choiceFixItem(input);
                    }
                }
            }
        }
    }
}
