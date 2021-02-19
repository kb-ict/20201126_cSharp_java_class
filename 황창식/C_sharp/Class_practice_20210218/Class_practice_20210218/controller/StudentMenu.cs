using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210218.controller
{
    class StudentMenu : StudentController
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
        
        private List<MemberInfo> members = new List<MemberInfo>();
        //static Random r = new Random();

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
                        addItem(members);
                        break;
                    case ADD_RND:
                        addRandomItem(members);
                        break;
                    case ADD_GOBACK:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하였습니다.");
                        break;

                }
            }
        }

        // 정보 탐색 메뉴
        public void viewMenu()
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
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 길이 : " + members.Count);
                            Console.Write("보고싶은 주소록 번호를 입력해주세요 : ");
                            int show = Convert.ToInt32(Console.ReadLine());
                            if (show > members.Count)
                            {
                                // 주소록 범위를 벗어난 값 입력
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("없는 정보입니다. 다시 입력해 주세요");
                                continue;
                            }

                            else
                            {
                                // 비어있는 정보 제외
                                if (members[show - 1].Name != " " && members[show - 1].Tel != " " && members[show - 1].Address != " " && members[show - 1].Email != " ")
                                {
                                    viewItem(members[show - 1], show);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("없는 정보입니다. 다시 입력해 주세요");
                                }
                            }
                        }
                        break;
                    case VIEW_ALL:
                        for (int i = 0; i < members.Count; i++)
                        {
                            // 비어있는 정보 제외
                            if (members[i].Name != " " && members[i].Tel != " " && members[i].Address != " " && members[i].Email != " ")
                            {
                                viewItem(members[i], i+1);
                            }
                        }
                        break;
                    case VIEW_GOBACK:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하였습니다.");
                        break;

                }
            }
        }

        // 정보 삭제 메뉴
        public void deleteItemMenu()
        {
            for (int i = 0; i < members.Count; i++)
            {
                // 비어있는 정보 제외
                if (members[i].Name != " " && members[i].Tel != " " && members[i].Address != " " && members[i].Email != " ")
                {
                    viewItem(members[i], i+1);
                }
            }
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
                        deleteItem(members);
                        break;
                    case DEL_ALL:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("모든 정보를 삭제하시겠습니까?(y/n) : ");
                        string delCheck = Console.ReadLine();
                        if (delCheck == "y")
                        {
                            members.Clear();
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("삭제되었습니다.");
                            return;
                        }
                        else if (delCheck == "n")
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("취소되었습니다.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("잘못 입력하셨습니다.");
                        }
                        break;
                    case DEL_GOBACK:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하였습니다.");
                        break;
                }
            }
        }

        // 정보 수정 메뉴
        public void fixItemMenu()
        {
            for (int i = 0; i < members.Count; i++)
            {
                viewItem(members[i], i+1);
            }
            while (true)
            {

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
                    int count = 0;
                    int numcopy = 0;
                    for (int i = 0; i < members.Count; i++)
                    {
                        // 빈 학생 정보 출력
                        if (members[i].Name == " " && members[i].Tel == " " && members[i].Address == " " && members[i].Email == " ")
                        {
                            count++;
                            viewItem(members[i], i+1);
                            numcopy = i;
                        }
                    }
                    if (count == 1)
                    {
                        fixItem(members[numcopy], numcopy+1);
                        return;
                    }
                    else if (count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("빈 학생 정보가 없습니다.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("추가하거나 수정할 학생의 번호를 입력하세요(돌아가기 : -1) : ");
                        int nullFix = Convert.ToInt32(Console.ReadLine());
                        fixItem(members[nullFix], nullFix+1);
                        return;
                    }
                }

                // 수정할 학생 이름 입력
                else
                {
                    // 입력받은 이름이 존재하는지 여부 파악
                    bool checkContains = false;
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (input == members[i].Name)
                        {
                            checkContains = true;
                            break;
                        }
                        else
                            checkContains = false;
                    }

                    // 존재할때
                    if (checkContains == true)
                    {
                        // 동명이인 파악
                        int count = 0;
                        int numcopy = 0;
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (input == members[i].Name)
                            {
                                count++;
                                viewItem(members[i], i+1);
                                numcopy = i;
                            }
                        }
                        if (count == 1)
                        {
                            fixItem(members[numcopy], numcopy+1);
                            return;
                        }
                        else
                        {
                            Console.Write("수정할 학생의 ID를 입력하세요 : ");
                            string fixnum = Console.ReadLine();
                            for (int i = 0; i < members.Count; i++)
                            {
                                if (fixnum == members[i].Id)
                                {
                                    fixItem(members[i], i+1);
                                }
                            }
                            return;
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine(input + "의 정보가 없습니다.");
                    }
                }
            }
        }
        
        public void noInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("주소록 정보가 없습니다.");
        }
        // 처리된 정보 리턴
        public List<MemberInfo> returnMembers()
        {
            return members;
        }
    }
}
