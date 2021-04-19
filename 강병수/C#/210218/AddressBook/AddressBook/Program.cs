using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        const int MENU_ADD_ADDRESS = 1;
        const int MENU_READ_ADDRESS = 2;
        const int MENU_MODIFY_ADDRESS = 3;
        const int MENU_RANDOM = 4;
        const int MENU_REMOVE = 5;
        const int MENU_CLEAR = 6;
        const int MENU_EXIT = 7;

        public static List<Student> addressList = new List<Student>();
        public static Random r = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                switch (menu())
                {
                    case MENU_ADD_ADDRESS:
                        addStudentInfo();
                        break;
                    case MENU_READ_ADDRESS:
                        readStudentInfo();
                        break;
                    case MENU_MODIFY_ADDRESS:
                        modifyStudentInfo();
                        break;
                    case MENU_RANDOM:
                        randData();
                        break;
                    case MENU_REMOVE:
                        removeStudentInfo();
                        break;
                    case MENU_CLEAR:
                        removeAllInfo();
                        break;
                    case MENU_EXIT:
                        Console.WriteLine("시스템 종료");
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static int menu()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("  주소록 관리 v1.0");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3. 주소록 정보 수정");
            Console.WriteLine("4. 주소록 랜덤 생성");
            Console.WriteLine("5. 주소록 정보 삭제");
            Console.WriteLine("6. 주소록 정보 모두 삭제");
            Console.WriteLine("7. 종료");
            Console.WriteLine("--------------------");
            Console.Write("메뉴 선택: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        public static void randData()
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            string[] tel = { "010-1234-5678", "010-4321-5678", "010-3478-1278",
                             "010-4523-1978", "010-7890-2134"};
            string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동",
                                "인천시 동구 신암4동", "광주시 동구 신암4동"};
            string[] email = { "hong@gmail.com", "kim@gmail.com", "park@gmail.com", "lee@gmail.com", "choi@naver.com" };


            for (int i = 0; i < 100; i++)
            {
                addressList.Add(new Student(getRandomID(), name[r.Next(0, 5)], tel[r.Next(0, 5)], address[r.Next(0, 5)], email[r.Next(0, 5)]));
                //Thread.Sleep(10);
            }
            
        }

        public static void addStudentInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(" 주소록 정보를 입력");
            Console.WriteLine("--------------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화번호: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();
            string id = getRandomID();
            addressList.Add(new Student(id, name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 저장됨");

        }

        public static void readStudentInfo()
        {
            for (int i = 0; i < addressList.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine("--------------------------");
                Console.WriteLine("이름: " + addressList[i].Name);
                Console.WriteLine("ID: " + addressList[i].Id);
                Console.WriteLine("전화번호: " + addressList[i].Tel);
                Console.WriteLine("주소: " + addressList[i].Address);
                Console.WriteLine("이메일: " + addressList[i].Email);
                Console.WriteLine("--------------------------");
            }
        }

        public static void removeStudentInfo()
        {

            Console.Write("삭제할 정보의 ID를 입력하세요: ");
            string removeId = Console.ReadLine();
            for (int i = 0; i < addressList.Count; i++)
            {
                if (removeId.Equals(addressList[i].Id))
                {
                    addressList.RemoveAt(i);
                }
            }
            Console.WriteLine(removeId + " 정보가 삭제되었습니다.");
        }

        public static void removeAllInfo()
        {
            addressList.Clear();
            Console.WriteLine("모든 정보가 삭제되었습니다.");
        }

        public static string getRandomID()
        {
            //Random r = new Random();
            string rdata = "abcdefghijklmnopqrstuvwxyyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            return rs.ToString();
        }

        public static void modifyStudentInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("수정할 정보의 ID 입력");
            Console.WriteLine("--------------------");
            Console.Write("ID 입력: ");
            string modifyId = Console.ReadLine();
            for (int i = 0; i<addressList.Count; i++)
            {
                if(modifyId.Equals(addressList[i].Id))
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("    주소록 수정 ");
                    Console.WriteLine("--------------------");
                    Console.Write("이름: ");
                    string name = Console.ReadLine();
                    addressList[i].Name = name;
                    Console.Write("전화번호: ");
                    string tel = Console.ReadLine();
                    addressList[i].Tel = tel;
                    Console.Write("주소: ");
                    string address = Console.ReadLine();
                    addressList[i].Address = address;
                    Console.Write("이메일: ");
                    string email = Console.ReadLine();
                    addressList[i].Email = email;
                    Console.WriteLine("--------------------");
                    Console.WriteLine("   주소록 수정 완료 ");
                    Console.WriteLine("--------------------");
                    break;
                }
            }
        }
    }
}
