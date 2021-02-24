using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace adressTest0218
{
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 환경 세팅
            SetConsole();

            StudentMySql mysql = new StudentMySql("localhost", "test20210224", "root", "1126", "student");
            StudentManager manager = new StudentManager();
            StudentJson json = new StudentJson(manager, "주소록.json");
            //json.Load();
            mysql.Select(manager);

            while (true)
            {
                try
                {
                    switch (StudentMenu.ShowMainMenu())
                    {
                        case (int)Menu.Add:
                            Console.WriteLine("정보 추가");
                            var newStudent = StudentMenu.ShowAddMenu();
                            manager.AddItem(newStudent);
                            mysql.Insert(newStudent);
                            json.Save();
                            break;
                        case (int)Menu.View:
                            Console.WriteLine("정보 보기");
                            manager.View();
                            break;
                        case (int)Menu.Rand:
                            Console.WriteLine("랜덤 데이터 추가");
                            Random r = new Random();
                            for (int i = 0; i < 5; i++)
                            {
                                var randStudent = new Student(
                                    RandData.GetId(),
                                    RandData.GetName(),
                                    RandData.GetTel(),
                                    RandData.GetAddress(),
                                    RandData.GetEmail());
                                manager.AddItem(randStudent);
                                mysql.Insert(randStudent);
                            }                          
                            json.Save();
                            break;
                        case (int)Menu.Remove:
                            Console.WriteLine("정보 삭제");
                            var delId = StudentMenu.ShowRemoveMenu();
                            manager.RemoveItem(delId);
                            mysql.Delete(delId);
                            json.Save();
                            break;
                        case (int)Menu.Update:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("아이디: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            string id = Console.ReadLine();
                            Student updateStudent = manager.FindStudentById(id);                         

                            if (updateStudent == null)
                            {
                                Console.WriteLine("입력한 아이디가 없습니다.");
                                break;
                            }

                            bool isUpdateEnd = false; // 수정이 끝났는지를 나타내는 변수
                            while (!isUpdateEnd)
                            {
                                try
                                {                                    
                                    switch (StudentMenu.ShowUpdateMenu())
                                    {
                                        case (int)UpdateMenu.Name:
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("수정할 이름: ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            updateStudent.Name = Console.ReadLine();
                                            break;
                                        case (int)UpdateMenu.Tel:
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("수정할 전화번호: ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            updateStudent.Tel = Console.ReadLine();
                                            break;
                                        case (int)UpdateMenu.Address:
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("수정할 주소: ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            updateStudent.Address = Console.ReadLine();
                                            break;
                                        case (int)UpdateMenu.Email:
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("수정할 이메일: ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            updateStudent.Email = Console.ReadLine();
                                            break;
                                        case (int)UpdateMenu.Back:
                                            isUpdateEnd = true;
                                            break;
                                        default:
                                            Console.WriteLine("잘못된 값을 입력했습니다.");
                                            break;
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if (!isUpdateEnd) Console.WriteLine("수정완료");
                                    json.Save();
                                    mysql.Update(updateStudent);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("잘못된 값을 입력했습니다.");
                                }
                            }
                            break;
                        case (int)Menu.Clear:
                            Console.WriteLine("정보 전체 삭제");
                            manager.Clear();
                            mysql.Clear();
                            json.Save();
                            break;
                        case (int)Menu.Exit:
                            Console.WriteLine("프로그램 종료");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("잘못된 값을 입력했습니다.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 값을 입력했습니다.");
                }
            }
        }

        public static void SetConsole()
        {
            Console.Title = "주소록 관리 프로그램 v1.0";
            Console.SetWindowSize(64, 30);
            Console.SetBufferSize(64, 2000);
        }       
    }
}
