using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210302_addrWin
{
    public class Student
    {
        private static RandomData rd = new RandomData();

        private string id;
        private string name;
        private string tel;
        private string address;
        private string email;

        public Student(string name, string tel, string address, string email)
        {
            this.id = rd.getRandomId();
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }

        public string getStringStudentInfo()
        {
            return "ID: " + id + "\n" + "이름: " + name + "\n" + "전화: " + tel + "\n" + "주소: " + address + "\n" + "이메일 : " + email + "\n";
        }
    }

    class RandomData : Random
    {
        private readonly string[] name = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
        private readonly string[] tel = { "010-1234-5678", "010-4567-8524", "010-7896-3214", "010-4566-1231" };
        private readonly string[] addr = { "서울", "대전", "대구", "부산", "제주도" };
        private readonly string[] email = { "aaaaa.com", "bbbbb,com", "ccccc.com", "ddddd.com", "eeeee.com" };

        public Student getRandomStudentInfo()
        {
            return new Student(name[this.Next(0, name.Length)],
                    tel[this.Next(0, tel.Length)],
                    addr[this.Next(0, addr.Length)],
                    email[this.Next(0, email.Length)]);
        }

        public string getRandomId()
        {
            string dummyStr = "abcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+|-=0123456789";

            StringBuilder id = new StringBuilder();
            for (int i = 0; i < 10; i++)
                id.Append(dummyStr[(int)(this.NextDouble() * dummyStr.Length)]);

            return id.ToString();
        }
    }
}
