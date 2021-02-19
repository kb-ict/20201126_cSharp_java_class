using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.control
{
    class StudentHandler
    {
        List<Student> addrList = new List<Student>();
        Random rd = new Random();
        public int getMenu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 관리 v1.0");
            Console.WriteLine("------------------");
            Console.WriteLine("1.주소록 추가");
            Console.WriteLine("2.주소록 보기");
            Console.WriteLine("3.랜덤 정보 추가");
            Console.WriteLine("4.주소록 삭제");
            Console.WriteLine("5.주소록 수정");
            Console.WriteLine("6.모든 정보 삭제");
            Console.WriteLine("7.종료");
            Console.WriteLine("------------------");
            Console.Write("메뉴선택: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;

        }

        public void addInfo()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("------------------");
            Console.Write("이름: ");
            String name = Console.ReadLine();
            Console.Write("전화번호: ");
            String tel = Console.ReadLine();
            Console.Write("주소: ");
            String address = Console.ReadLine();
            Console.Write("이메일: ");
            String email = Console.ReadLine();
            String id = getId();
            addrList.Add(new Student(id, name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");

        }
        public void viewInfo()
        {
            foreach (Student student in addrList)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("주소록 정보");
                Console.WriteLine("------------------");
                Console.WriteLine("항목: " + (addrList.IndexOf(student) + 1));
                Console.WriteLine("이름: " + student.Name);
                Console.WriteLine("전화번호: " + student.Tel);
                Console.WriteLine("주소: " + student.Address);
                Console.WriteLine("이메일: " + student.Email);
                //Console.WriteLine("아이디: "+student.Id);
            }
        }

        public void randomMaker()
        {
            String[] name = { "홍길동", "김길동", "장길동", "왕건", "김희성" };
            String[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-44444", "010-5555-5555" };
            String[] address = { "경북 경산 하양읍", "대구 달성군 현풍읍", "부산 수성구 광안리", "서울 잠실타워", "인천 공항" };
            String[] email = { "jang6066@gmail.com", "OMG@gmail.com", "ldjgoodjjang@gmail.com", "hong123123@gmail.com", "kim1233@gmail.com" };

            //Random rd = new Random();
            for (int i = 0; i < 100; i++)
            {
                addrList.Add(new Student(getId(), name[rd.Next(0, 4)], tel[rd.Next(0, 4)], address[rd.Next(0, 4)], email[rd.Next(0, 4)]));

            }
        }

        public void infoDel()
        {
            Console.Write("삭제할 이름을 입력하세요: ");
            String name = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name == addrList[i].Name)
                {
                    /*addrList.Remove(addrList[i]);*/
                    addrList.RemoveAt(i--); ;
                }
            }
            Console.WriteLine(name + " 정보가 삭제되었습니다.");
        }

        public void allInfoDel()
        {
            addrList.Clear();
            Console.WriteLine("모든 정보가 삭제되었습니다.");

        }

        public String getId()
        {

            String rddata = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNPQRSTUVWXYZ!@#$%^&*()/;";
            StringBuilder rds = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                rds.Append(rddata[(int)(rd.NextDouble() * rddata.Length)]);
            }
            //Console.WriteLine("id: "+rds.ToString() );
            return rds.ToString();
        }

        public void reviseInfo()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 수정");
            Console.WriteLine("------------------");
            foreach (Student student in addrList)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("항목: " + (addrList.IndexOf(student) + 1));
                Console.WriteLine("이름: " + student.Name);
                Console.WriteLine("전화번호: " + student.Tel);
                Console.WriteLine("주소: " + student.Address);
                Console.WriteLine("이메일: " + student.Email);
                Console.WriteLine("------------------");
            }
            Console.Write("수정할 항목: ");
            int num = (Convert.ToInt32(Console.ReadLine()) - 1);
            if (num < 1 || (num + 1) > addrList.Count)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Error: 수정할 항목이 없습니다.");
                Console.WriteLine("------------------");

            }
            else
            {
                Console.WriteLine("수정할 이름: " + addrList[num].Name);
                Console.Write("변경할 이름: ");
                String reviseName = Console.ReadLine();
                addrList[num].Name = reviseName;

                Console.WriteLine("------------------");
                Console.WriteLine("변경된 주소록");
                Console.WriteLine("------------------");
                Console.WriteLine("항목: " + (num + 1));
                Console.WriteLine("이름: " + addrList[num].Name);
                Console.WriteLine("전화번호: " + addrList[num].Tel);
                Console.WriteLine("주소: " + addrList[num].Address);
                Console.WriteLine("이메일: " + addrList[num].Email);
                Console.WriteLine("------------------");

            }



        }
    }
}

