using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    class Program
    {
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDOM_ADD = 3;
        const int MENU_DELETE = 4;
        const int MENU_DELETE_ALL = 5;
        const int MENU_EXIT = 6;

        static List<Student> addrList = 
            new List<Student>();

        static void Main(string[] args) {
            while (true) {
                switch (getMenu()) {
                    case MENU_ADD:
                        addItem();
                        break;
                    case MENU_VIEW:
                        viewItem();
                        break;
                    case MENU_RANDOM_ADD:
                        randData();
                        break;
                    case MENU_DELETE:
                        delItem();
                        break;
                    case MENU_DELETE_ALL:
                        delItemAll();
                        break;
                    case MENU_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();

            addrList.Add(
                new Student(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public static void viewItem()
        {
            for (int i=0; i<addrList.Count; i++)
            {
                Console.WriteLine("번호: " + (i+1));
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }

        public static int getMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 보기");
            Console.WriteLine("3.랜덤 데이터 추가");
            Console.WriteLine("4.주소록 정보 삭제");
            Console.WriteLine("5.전체 데이터 삭제");
            Console.WriteLine("6.종료");
            Console.WriteLine("-----------------");
            Console.Write("메뉴 선택: ");
            int menu = 
                Convert.ToInt32(Console.ReadLine());
            return menu;
        }

        public static void randData()
        {
            string[] name =
                {"홍길동", "김길동",
                "이길동", "박길동", "최길동"};
            string[] tel = {"010-1111-1111",
                "010-2222-2222", "010-2222-3333",
                "010-2222-4444", "010-2222-5555"};
            string[] address = {"대구시 동구 신암동",
                "광주시 동구 신암동", "서울시 동구 신암동",
                "대전시 동구 신암동", "부산시 동구 신암동"};
            string[] email = {"hong@naver.com",
                "kim@naver.com", "lee@naver.com",
                "park@naver.com", "choi@naver.com"};

            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                addrList.Add(new Student(
                    name[r.Next(0, 5)],
                    tel[r.Next(0, 5)],
                    address[r.Next(0, 5)],
                    email[r.Next(0, 5)]));
            }
        }

        static void delItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 삭제");
            Console.WriteLine("-----------------");
            Console.Write("삭제할 이름: ");
            string name = Console.ReadLine();

            for (int i=0; i<addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }

            /*
            int cnt = 0;
            while (cnt < addrList.Count)
            {
                if (name.Equals(addrList[cnt].Name))
                {
                    addrList.RemoveAt(cnt);
                }
                else
                {
                    cnt++;
                }
            }
            */
        }

        static void delItemAll()
        {
            addrList.Clear();
        }

        static string getId()
        {
            Random r = new Random();
            string rdata = 
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789"+
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ"+
                "~!@#$%^&*?";
            StringBuilder rs = new StringBuilder();
            for (int i=0; i<10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble()*rdata.Length)]);
            }
            //Console.WriteLine("id: " + rs.ToString());
            return rs.ToString();
        }
    }
}
