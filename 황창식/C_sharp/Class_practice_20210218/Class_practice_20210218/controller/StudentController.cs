using Class_practice_20210218.util;
using Class_practice_20210218.view;
using System;
using System.Collections.Generic;

namespace Class_practice_20210218.controller
{
    class StudentController : Messages
    {
        const string FIX_NAME = "1";
        const string FIX_TEL = "2";
        const string FIX_ADD = "3";
        const string FIX_EMAIL = "4";
        const string FIX_GOBACK = "5";

        RandData rand = new RandData(new Random());

        List<MemberInfo> members = new List<MemberInfo>();

        public List<MemberInfo> getMembers()
        {
            return members;
        }

        // 정보 추가
        public void addItem()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 주소록 정보 입력");
            Console.WriteLine("---------------------------");
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("전화번호 : ");
            string tel = Console.ReadLine();
            Console.Write("주소 : ");
            string address = Console.ReadLine();
            Console.Write("이메일 : ");
            string email = Console.ReadLine();
            members.Add(new MemberInfo(rand.getId(), name, tel, address, email));
            viewItem(members[(members.Count) - 1], members.Count);
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        // 랜덤 정보 추가
        public void addRandomItem(int num)
        {
            for (int i = 0; i < num; i++)
            {
                members.Add(new MemberInfo(rand.getId(), rand.getName(), rand.getTel(), rand.getAddress(), rand.getEmail()));
            }
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine();
                viewItem(members[i], i + 1);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("추가되었습니다!");
        }

        // 정보 선택하여 보기
        public void viewOneInfo()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine("주소록 길이 : " + members.Count);
                Console.Write("보고싶은 주소록 번호를 입력해주세요 : ");
                int show = Convert.ToInt32(Console.ReadLine());
                if (show > members.Count)
                {
                    noInfo();
                    continue;
                }

                else
                {
                    // 비어있는 정보 제외
                    if (isEmpty(members[show - 1]) == false)
                    {
                        viewItem(members[show - 1], show);
                        return;
                    }

                    else
                    {
                        noInfo();
                    }
                }
            }
        }

        // 정보 모두 보기
        public void viewAll()
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name != " " && members[i].Tel != " " && members[i].Address != " " && members[i].Email != " ")
                {
                    viewItem(members[i], i + 1);
                }
            }
        }

        // 정보 보기 레이아웃
        public void viewItem(MemberInfo member, int num)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine(num + "번 학생 정보");
            Console.WriteLine("---------------------------");
            Console.WriteLine("이름 : " + member.Name);
            Console.WriteLine("전화번호 : " + member.Tel);
            Console.WriteLine("주소 : " + member.Address);
            Console.WriteLine("이메일 : " + member.Email);
            Console.WriteLine("ID : " + member.Id);
            Console.WriteLine("---------------------------");
        }

        // 정보 선택하여 삭제
        public void choiceDeleteItem(string name)
        {
            if (isContain(name))
            {
                int[] counter = sameNameCounter(name);
                // 일치하는 이름이 하나일때
                if (counter[0] == 1)
                {
                    deleteItemConfirm(counter[1]);
                    return;
                }

                // 일치하는 이름이 여러개일떄
                else
                {
                    Console.Write("삭제할 ID를 입력하세요 : ");
                    string delnum = Console.ReadLine();
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (delnum == members[i].Id)
                        {
                            viewItem(members[i], i + 1);
                            deleteItemConfirm(i);
                            return;
                        }
                    }
                }
            }
            else
            {
                noInfo();
            }
        }

        // 정보 삭제 확인
        public void deleteItemConfirm(int num)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.Write("정보를 삭제 하시겠습니까?(y/n) : ");
            string delCheck = Console.ReadLine();
            if (delCheck == "y")
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(members[num].Name + "의 정보를 삭제 했습니다.");
                members[num].Name = " ";
                members[num].Tel = " ";
                members[num].Address = " ";
                members[num].Email = " ";
            }

            else if (delCheck == "n")
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine("취소되었습니다.");
            }
        }

        // 전체 삭제
        public void deleteAll()
        {
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
                wrongInput();
            }
        }

        // 선택하여 수정
        public void choiceFixItem(string name)
        {
            // 존재할때
            if (isContain(name))
            {
                // 동명이인 파악
                int[] checker = sameNameCounter(name);
                if (checker[0] == 1)
                {
                    fixItem(members[checker[1]], checker[1] + 1);
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
                            fixItem(members[i], i + 1);
                        }
                    }
                    return;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(name + "의 정보가 없습니다.");
            }
        }

        // 빈 정보 수정
        public void emptyItemFix()
        {
            int[] checker = sameNameCounter(" ");
            if (checker[0] == 1)
            {
                fixItem(members[checker[1]], checker[1] + 1);
                return;
            }
            else if (checker[0] == 0)
            {
                noInfo();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.Write("추가하거나 수정할 학생의 번호를 입력하세요(돌아가기 : -1) : ");
                int nullFix = Convert.ToInt32(Console.ReadLine());
                fixItem(members[nullFix], nullFix + 1);
                return;
            }
        }

        // 정보 수정
        public void fixItem(MemberInfo member, int num)
        {
            Console.WriteLine();
            viewItem(member, num);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(" 주소록 정보 수정");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. 이름");
                Console.WriteLine("2. 전화번호");
                Console.WriteLine("3. 주소");
                Console.WriteLine("4. 이메일");
                Console.WriteLine("5. 돌아가기");
                Console.WriteLine("---------------------------");
                Console.Write("메뉴 선택 : ");

                switch (Console.ReadLine())
                {
                    case FIX_NAME:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 이름을 입력하세요 : ");
                        member.Name = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member, num);
                        break;
                    case FIX_TEL:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 전화번호를 입력하세요 : ");
                        member.Tel = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member, num);
                        break;
                    case FIX_ADD:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 주소를 입력하세요 : ");
                        member.Address = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member, num);
                        break;
                    case FIX_EMAIL:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 이메일을 입력하세요 : ");
                        member.Email = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member, num);
                        break;
                    case FIX_GOBACK:
                        return;
                    default:
                        wrongInput();
                        break;
                }
            }
        }

        // 비어있는지 여부 확인
        public bool isEmpty(MemberInfo member)
        {
            if (member.Name == " " && member.Tel == " " && member.Address == " " && member.Email == " ")
                return true;
            else
                return false;
        }

        // 검색한 정보 포함 여부
        public bool isContain(string name)
        {
            bool checker = false;
            for (int i = 0; i < members.Count; i++)
            {
                if (name == members[i].Name)
                {
                    checker = true;
                    break;
                }
                else
                    checker = false;
            }
            return checker;
        }

        // 동명이인 여부
        public int[] sameNameCounter(string name)
        {
            int count = 0;
            int numcopy = 0;
            int[] nums = new int[2];
            for (int i = 0; i < members.Count; i++)
            {
                if (name == members[i].Name)
                {
                    count++;
                    viewItem(members[i], i + 1);
                    numcopy = i;
                }
            }
            nums[0] = count;
            nums[1] = numcopy;
            return nums;
        }
    }
}
