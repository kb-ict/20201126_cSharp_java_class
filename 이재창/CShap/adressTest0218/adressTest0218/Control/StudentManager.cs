using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adressTest0218
{
    public class StudentManager
    {
        private readonly Random rand = new Random();
        public List<Student> Students { get; set; } = new List<Student>();         

        public void AddItem()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------------");
            Console.Write("이름: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("전화: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string tel = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("주소: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string address = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("이메일: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string email = Console.ReadLine();

            Students.Add(new Student(name, tel, address, email, GetId()));
        }

        public void RemoveItem()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------");
            Console.WriteLine("주소록 정보 삭제");
            Console.WriteLine("-----------------------");
            Console.Write("아이디: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string id = Console.ReadLine();

            for (int i = Students.Count - 1; i >= 0; i--)
            {
                if (Students[i].Id == id)
                {
                    Students.RemoveAt(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("삭제 완료");
        }

        public void RemoveAllItem()
        {
            Students.Clear();
        }       

        public void RandData()
        {
            string[] name = { "홍길동", "김길동", "이길동", "박길동", "최길동" };
            string[] tel = { "010-1111-1111", "010-2222-1111",
                "010-1111-3333", "010-4444-1111", "010-1111-5555" };
            string[] address = { "대구시 동구 신암동", "광주시 동구 신암동",
                "서울시 동구 신암동", "부산시 동구 신암동", "대전시 동구 신암동" };
            string[] email = { "hong@naver.com", "kim@naver.com",
                "lee@naver.com", "park@naver.com", "choi@naver.com" };

            for (int i = 0; i < 5; i++)
            {
                Students.Add(new Student(
                    name[rand.Next(0, 5)],
                    tel[rand.Next(0, 5)],
                    address[rand.Next(0, 5)],
                    email[rand.Next(0, 5)],
                    GetId()));
            }
        }

        public void ModifyItem(StudentManager manager)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------");
            Console.WriteLine("1.이름");
            Console.WriteLine("2.전화");
            Console.WriteLine("3.주소");
            Console.WriteLine("4.이메일");
            Console.WriteLine("5.전체");
            Console.WriteLine("----------");
            Console.WriteLine("메뉴 선택: ");
            Console.ForegroundColor = ConsoleColor.White;
            var menu = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------");
            Console.WriteLine("주소록 정보 수정");
            Console.WriteLine("-----------------------");
            Console.Write("아이디: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string id = Console.ReadLine();

            Student student = null;
            for (int i = 0; i < manager.Students.Count; i++)
            {
                if (manager.Students[i].Id == id)
                {
                    student = manager.Students[i];
                    break;
                }
            }      

            switch (menu)
            {
                case (int)ModifyMenu.Name:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("이름: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Name = Console.ReadLine();
                    break;
                case (int)ModifyMenu.Tel:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("전화: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Tel = Console.ReadLine();
                    break;
                case (int)ModifyMenu.Address:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("주소: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Address = Console.ReadLine();
                    break;
                case (int)ModifyMenu.Email:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("이메일: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Email = Console.ReadLine();
                    break;
                case (int)ModifyMenu.All:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("이름: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("전화: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Tel = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("주소: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Address = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("이메일: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    student.Email = Console.ReadLine();
                    break;
            }
        }

        public string GetId()
        {
            string rdata =
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "ABCDEFGHIJKLMNPQRSTUVWXYZ" +
                "~!@#$%^&*?";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                rs.Append(rdata[rand.Next(0, rdata.Length)]);
            }
            return rs.ToString();
        }
    }
}
