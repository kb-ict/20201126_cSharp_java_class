﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210218.controller
{
    class StudentController
    {
        const string FIX_NAME = "1";
        const string FIX_TEL = "2";
        const string FIX_ADD = "3";
        const string FIX_EMAIL = "4";
        const string FIX_GOBACK = "5";
        static Random r = new Random();

        // 정보 추가
        public void addItem(List<MemberInfo> members)
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
            members.Add(new MemberInfo(getId(), name, tel, address, email));
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        // 랜덤 정보 추가
        public void addRandomItem(List<MemberInfo> members)
        {
            string[] lastName = { "김", "이", "박", "최", "강" };
            string[] firstName1 = { "춘", "덕", "광", "미", "용" };
            string[] firstName2 = { "삼", "배", "자", "국", "봉", "심", "숙" };
            string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
            string[] emailId = { "hong", "kim", "park", "choi", "kang", "lee" };
            string[] emailadd = { "@naver.com", "@gmail.com", "@hanmail.net" };
            string fullname;
            string tel;
            string email;

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.Write("추가할 주소록 수량을 입력하세요 : ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                fullname = lastName[r.Next(0, lastName.Length)] + firstName1[r.Next(0, firstName1.Length)] + firstName2[r.Next(0, firstName2.Length)];
                tel = "010 - " + Convert.ToString(r.Next(1000, 10000)) + " - " + Convert.ToString(r.Next(1000, 10000));
                email = emailId[r.Next(0, emailId.Length)] + emailadd[r.Next(0, emailadd.Length)];
                members.Add(new MemberInfo(getId(), fullname, tel, address[r.Next(0, address.Length)], email));
                Console.WriteLine();
                viewItem(members[i], i+1);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("추가되었습니다!");
        }

        // 정보 보기
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

        // 정보 삭제
        public void deleteItem(List<MemberInfo> members)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.Write("삭제할 학생의 이름을 입력하세요(돌아가기 : -1) : ");
                string input = Console.ReadLine();
                // 돌아가기
                if (input == "-1")
                    return;
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
                        // 일치하는 이름이 하나일때
                        if (count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.Write("정보를 삭제 하시겠습니까?(y/n) : ");
                            string delCheck = Console.ReadLine();
                            if (delCheck == "y")
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine(members[numcopy].Name + "의 정보를 삭제 했습니다.");
                                members[numcopy].Name = " ";
                                members[numcopy].Tel = " ";
                                members[numcopy].Address = " ";
                                members[numcopy].Email = " ";
                            }
                            else if (delCheck == "n")
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("취소되었습니다.");
                            }
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
                                    viewItem(members[i], i+1);
                                    Console.WriteLine();
                                    Console.WriteLine("---------------------------");
                                    Console.Write("정보를 삭제 하시겠습니까?(y/n) : ");
                                    string delCheck = Console.ReadLine();
                                    if (delCheck == "y")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("---------------------------");
                                        Console.WriteLine(members[i + 1].Name + "의 정보를 삭제 했습니다.");
                                        members[i].Name = " ";
                                        members[i].Tel = " ";
                                        members[i].Address = " ";
                                        members[i].Email = " ";
                                    }
                                    else if (delCheck == "n")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("---------------------------");
                                        Console.WriteLine("취소되었습니다.");
                                    }
                                    return;
                                }
                            }
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
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            }
        }

        // 랜덤 ID 생성
        static string getId()
        {
            string rdata = "abcdefghijklmnopqrstuvwxyz" + "ABCDEFGHIJKLMNPQRSTUVWXYZ" + "0123456789" + "~!@#$%^&*?";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            return sb.ToString();
        }
    }
}
