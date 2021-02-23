using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_boxupInHouse
{
    /* -------------------
     *     주소록 관리
     * -------------------
     * 1. 주소록 정보 추가
     * 2. 주소록 정보보기
     * 3. 랜덤데이터 추가 (100이하)
     * 4. 주소록 정보 삭제
     * 5. 종료
     * 
     * 
     * 1-1. 주소록   : 이름 / 전화번호 / 주소 / 메일*
     * 1-2. 정보입력 : * > 객체생성 > 배열, 리스트 > DB or file
     * 4-1. 주소록 정보 삭제 : 삭제할 이름을 입력하세요 : ㅇㅇㅇ > ㅇㅇㅇ 정보가 삭제되었습니다.
     * -------------------
     */
    class Program
    {
        const string LINE = "-----------------";
        const int MENU_ADD = 1;
        const int MENU_VIEW = 2;
        const int MENU_RANDOM_ADD = 3;
        const int MENU_DELETE = 4;
        const int MENU_DELETE_ALL = 5;
        const int MENU_EXIT = 6;

        static List<Student> addrList = new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD:
                        Console.WriteLine("1. 정보 추가");      // 완료
                        addItem();
                        break;
                    case MENU_VIEW:
                        Console.WriteLine("2. 정보보기");       // 완료
                        viewItem();
                        break;
                    case MENU_RANDOM_ADD:
                        Console.WriteLine("3. 랜덤정보 추가");  // 완료, 신규생성 갯수 count부터 ★
                        randData();
                        break;

                    case MENU_DELETE:
                        Console.WriteLine("4. 이름 검색 후삭제"); // 완료
                        delItem();
                        break;
                    case MENU_DELETE_ALL:
                        Console.WriteLine("5. 전체삭제");         // 완료
                        delItemAll();
                        break;
                    case MENU_EXIT:
                        Console.WriteLine("6. 종료");             // 완료
                        Console.WriteLine($"{LINE}\n시스템을 종료합니다\n{LINE}.");
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }
        public static void delItemAll()
        {
            Console.WriteLine("전체 삭제됨");
            addrList.Clear();
        }
        public static void delItem()
        {   
            Console.Write("삭제할 이름 : ");
            string delName = Console.ReadLine();
            int beforeCount = addrList.Count;
            for(int i = 0; i<addrList.Count; i++)
            {
                if (addrList[i].Name == delName)
                {
                    addrList.RemoveAt(i--);
                }
            }
            int afterCount = addrList.Count;
            Console.WriteLine($" \n \"{delName}\"가 삭제되었습니다.");
            Console.WriteLine($"삭제된 갯수 : {beforeCount-afterCount} 개");
        }
        public static void randData()
        {
            string[] name = { "1111", "2222", "3333", "4444" };
            string[] tel = { "1111-0000-0000", "2222-0000-0000", "3333-0000-0000", "4444-0000-0000" };
            string[] address = { "1서울", "2대전", "3대구", "4부산", "5찍고 아하~" };
            string[] email = { "일메일.com", "이메일.NAVER", "삼메일점 컴", "오오오메일" };
            int[] countName = new int[name.Length];
            int[] countNameAll = new int[name.Length];
            Console.Write("\n생성할 랜덤정보 수 입력 : ");
            int make = Convert.ToInt32(Console.ReadLine());
            int before = addrList.Count; // 생성전 개수
            int after = addrList.Count + make; // 생성 후 개수

            int newIndex = after - before;

            Random r = new Random();
            for (int i = 0; i < make; i++)
            {
                addrList.Add(new Student(name[r.Next(0, 4)],
                    tel[r.Next(0, 4)], address[r.Next(0, 4)], email[r.Next(0, 4)]));
            }


            /*  확인- 여기부터 ★*/
            // 생성전 갯수에서부터 (5) ~~ 생성후 숫자 (7) = 2개, 
            // 변수 < 2 =>> 0,1 2번돈다.
            for (int i = (before+1); i < newIndex; i++) // 생성 인덱스(6)부터, 마지막 인덱스(7)까지
             {
                 for (int j = 0; j < name.Length; j++)
                 {
                     if (addrList[i].Name.Equals(name[j])) // 각 이름이 이름 4개를 다 대조함
                     {
                         ++countName[j]; // 해당값이 있는 인덱스 수를 센다.
                     }
                 }
             }

             Console.WriteLine($"\n{LINE}\n신규생성\n{LINE}");
             for (int i = 0; i < name.Length; i++)
             {
                 if (countName[i] != 0)
                 {
                     Console.WriteLine($"---- {name[i]} : {countName[i]}개 생성됨");
                 }

             }



            Console.WriteLine($"\n\n{LINE}\n전체 갯수\n{LINE}");
            for (int i = 0; i < addrList.Count; i++)
            {
                for (int j = 0; j < countNameAll.Length; j++)
                {
                    if (addrList[i].Name.Equals(name[j])) // 각 이름이 이름 4개를 다 대조함
                    {
                        ++countNameAll[j]; // 해당값이 있는 인덱스를 전체 계수
                    }
                }
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (countNameAll[i] != 0)
                {
                    Console.WriteLine($"---- {name[i]} : {countNameAll[i]}개");
                }
            }
        }
        public static void viewItem()
        {
            if (addrList.Count != 0)
            {
                for (int i = 0; i < addrList.Count; i++)
                {
                    Console.WriteLine($"\n--- {i + 1}번째 ---");
                    Console.WriteLine($"이름 : {addrList[i].Name}");
                    Console.WriteLine($"전화 : {addrList[i].Tel}");
                    Console.WriteLine($"주소 : {addrList[i].Address}");
                    Console.WriteLine($"메일 : {addrList[i].Email}");
                }
            }
            else
            {
                Console.WriteLine("정보를 입력하세요.");
                return;
            }
        }
        public static void addItem()
        {
            Console.WriteLine(LINE);
            Console.WriteLine("1-2 / 주소록 정보입력");
            Console.WriteLine(LINE);
            Console.Write("ㅌ이름 : ");
            string name = Console.ReadLine();
            Console.Write("ㅌ전화 : ");
            string tel = Console.ReadLine();
            Console.Write("ㅌ주소 : ");
            string address = Console.ReadLine();
            Console.Write("ㅌ메일 : ");
            string email = Console.ReadLine();
            addrList.Add(new Student(name, tel, address, email));

            Console.WriteLine(LINE);
            Console.WriteLine("입력완료\n");
        }
        public static int getMenu()
        {
            Console.WriteLine(LINE);
            Console.WriteLine(" [복습] 주소록관리");
            Console.WriteLine(LINE);
            Console.WriteLine("1. 정보추가");
            Console.WriteLine("2. 정보보기");
            Console.WriteLine("3. 랜덤정보 추가");
            Console.WriteLine("4. 이름 검색 후삭제");
            Console.WriteLine("5. 전체삭제");
            Console.WriteLine("6. 종료");
            Console.WriteLine(LINE);
            Console.Write("메뉴 입력 : ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }

    }
}
