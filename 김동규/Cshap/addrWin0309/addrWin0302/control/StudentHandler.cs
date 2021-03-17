using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.control
{
    class StudentHandler
    {

        static StudentHandler inst;

        List<Student> addrList = new List<Student>();
        Random r = new Random();

        public static StudentHandler getInst()
        {
            if(inst == null)
            {
                inst = new StudentHandler();
            }
            return inst;
        }
      
        public StudentHandler()
        {
            
        }

        public List<Student> getList()
        {
            return addrList;
        }

        public void addItem()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("---------------");
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();

            /* Student st = new Student(name, tel, address, email);
             return st;*/
            addrList.Add(new Student(id, name, tel, address, email));
        }

        public void viewItem()
        {
            if (addrList.Count > 0)
            {
                for (int i = 0; i < addrList.Count; i++)
                {

                    Console.WriteLine("번호: " + (i + 1));
                    Console.WriteLine("ID : " + addrList[i].Id);
                    Console.WriteLine("이름 : " + addrList[i].Name);
                    Console.WriteLine("전화 : " + addrList[i].Tel);
                    Console.WriteLine("주소 : " + addrList[i].Adress);
                    Console.WriteLine("이메일 : " + addrList[i].Email);
                    Console.WriteLine("---------------------------");
                }
            }
            else
            {
                Console.WriteLine("데이터가 없습니다.");
            }
        }

        public void randItem(int count)
        {
            //Random rand = new Random();


            string[] name = { "홍길동", "박길동", "이길동", "최길동", "김길동" };
            string[] tel = { "010-1234-5678", "010-0000-5678", "010-1000-5678", "010-1234-5000", "010-1200-5008" };
            string[] address = { "대구시 동구 신암4동", "서울시 동구", "서울시 서구", "서울시 강남", "서울시 강북" };
            string[] email = { "a@naver.com", "b@naver.com", "c@naver.com", "d@naver.com", "e@naver.com" };




            for (int i = 0; i < count; i++)
            {
                addrList.Add(new Student(getID(), name[r.Next(5)], tel[r.Next(5)], address[r.Next(5)], email[r.Next(5)]));
                //Thread.Sleep(30);
            }


        }

        public void delItem()
        {
            Console.Write("삭제할 ID : ");
            string id = Console.ReadLine();
            Console.WriteLine("--------------");

            for (int i = 0; i < addrList.Count; i++)
            {

                if (addrList[i].Id.Equals(id))
                {
                    addrList.RemoveAt(i--);

                }
            }


        }

        public void cleanItem()
        {
            addrList.Clear();
            Console.WriteLine("주소록 전체 삭제 완료");
        }

        public string getID()
        {

            string rdata = "abcdefghijklmnopqrstuvwxyz0123456789" +
                "ABCDEFGHIJKLMNPQRSTUVWXYZ" + "~!@#$%^&*?";
            StringBuilder rs = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            return rs.ToString();
        }



        public void modifyItem(int a)
        {


            if (a == 1)
            {
                Console.WriteLine("----------------------");
                Console.Write("수정할 이름: ");
                string name = Console.ReadLine();
                Console.Write("변경할 이름: ");
                string nameM = Console.ReadLine();
                Console.WriteLine("----------------------");
                for (int i = 0; i < addrList.Count; i++)
                {

                    if (addrList[i].Name.Equals(name))
                    {
                        addrList[i].Name = nameM;

                    }
                }
            }

            else if (a == 2)
            {
                Console.WriteLine("----------------------");
                Console.Write("수정할 전화번호: ");
                string tel = Console.ReadLine();
                Console.Write("변경할 전화번호: ");
                string telM = Console.ReadLine();
                Console.WriteLine("----------------------");
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Tel.Equals(tel))
                    {
                        addrList[i].Tel = tel;
                    }
                }
            }

            else if (a == 3)
            {
                Console.WriteLine("----------------------");
                Console.Write("수정할 주소: ");
                string adress = Console.ReadLine();
                Console.Write("변경할 주소: ");
                string adressM = Console.ReadLine();
                Console.WriteLine("----------------------");
                for (int i = 0; i < addrList.Count; i++)
                {

                    if (addrList[i].Adress.Equals(adress))
                    {
                        addrList[i].Adress = adressM;

                    }
                }
            }
        }
    }
}
