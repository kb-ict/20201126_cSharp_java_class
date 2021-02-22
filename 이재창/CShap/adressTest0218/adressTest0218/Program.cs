using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adressTest0218
{
    enum Menu { Add = 1, View, Rand, Remove, RemoveAll, Modify, Exit }
    enum ModifyMenu { Name = 1, Tel, Address, Email, All, Back }
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 환경 세팅
            SetConsole();
            
            StudentManager manager = new StudentManager();
            StudentJson.Load(manager);

            while (true)
            {
                switch (StudentView.GetMenu())
                {
                    case (int)Menu.Add:
                        Console.WriteLine("정보 추가");
                        manager.AddItem();
                        StudentJson.Save(manager);
                        break;
                    case (int)Menu.View:
                        Console.WriteLine("정보 보기");
                        StudentView.View(manager);
                        break;
                    case (int)Menu.Rand:
                        Console.WriteLine("랜덤 데이터 추가");
                        manager.RandData();
                        StudentJson.Save(manager);
                        break;
                    case (int)Menu.Remove:
                        Console.WriteLine("정보 삭제");
                        manager.RemoveItem();
                        StudentJson.Save(manager);
                        break;
                    case (int)Menu.RemoveAll:
                        Console.WriteLine("정보 전체 삭제");
                        manager.RemoveAllItem();
                        StudentJson.Save(manager);
                        break;
                    case (int)Menu.Modify:
                        Console.WriteLine("정보 수정");
                        manager.ModifyItem(manager);
                        StudentJson.Save(manager);
                        break;
                    case (int)Menu.Exit:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void SetConsole()
        {
            Console.Title = "주소록 관리 프로그램 v1.0";
            Console.SetWindowSize(60, 25);
            Console.SetBufferSize(60, 2000);
        }       
    }
}
