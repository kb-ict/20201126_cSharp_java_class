using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adress200218
{
    class Program
    {
        //static Student st = null;
        static List<Student> addrList = new List<Student>();
        static void Main(string[] args)
        {
            
            while (true)
            {
                switch (getMenu())
                {
                   
                    case 1:
                        Console.WriteLine("정보 추가");
                        addItem();
                        break;
                    case 2:
                        Console.WriteLine("정보 보기");
                        viewItem();
                        break;
                    case 3:
                        Console.WriteLine("랜덤 데이터 추가");
                        randomData();
                        break;
                    case 4:
                        Console.WriteLine("주소록 삭제");
                        dataDel();
                        break;
                    case 5:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                }                
            }
        }
        public static void dataDel()
        {
            Console.WriteLine("삭제할 이름 입력: ");
            string delName = Console.ReadLine();

            for(int i = 0; i < addrList.Count; i ++)
            {
                if (addrList[i].Name == delName)
                {
                    addrList.RemoveAt(i);
                    i--;
                }
            }


        }
        public static void randomData()
        {
            Random r = new Random();
            string[] namer = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
            string[] telr = { "010-1234-5678", "010-4567-8524", "010-7894-5465", "010-7896-3214", "010-4566-1231" };
            string[] addressr = { "서울", "대전", "대구", "부산", "제주도" };
            string[] emailr = { "dts@naver.com", "tsts@gmail.com", "tds@naver.com", "astgas@naver.com", "asdr@gmail.com" };
            addrList.Add(new Student(namer[r.Next(0, 5)], telr[r.Next(0, 5)], addressr[r.Next(0, 5)], emailr[r.Next(0, 5)]));
        }
        public static void addItem()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-------------------------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();
            addrList.Add(new Student(name, tel, address, email));
        }
        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine($"이름: {addrList[i].Name}");
                Console.WriteLine($"전화: {addrList[i].Tel}");
                Console.WriteLine($"주소: {addrList[i].Address}");
                Console.WriteLine($"이메일: {addrList[i].Email}");
                Console.WriteLine("-------------------------------");
            }
        }
        public static int getMenu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 주소록 정보 추가");
            Console.WriteLine("4.주소록 삭제");
            Console.WriteLine("5.주소록 수정");
            Console.WriteLine("6.주소록 전체 삭제");
            Console.WriteLine("7.종료");
            Console.WriteLine("-------------------------------");
            Console.Write("메뉴 선택: ");
            int menu = int.Parse(Console.ReadLine());
            return menu;
        }

    }
}
