using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210218_adressTest
{
    class Student
    {
        private String id;
        private String name;
        private String tel;
        private String address;
        private String email;
        private static Student inst;

        public static Student getInst()
        {
            if(inst == null)
            {
                inst = new Student();
            }
            return inst;
        }

        public Student(string name, string tel, string address, string email)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }
        public Student()
        {

        }

        public Student(string id, string name, string tel, string address, string email) : this(name, tel, address, email)
        {
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }

        /* public void printShowInfo()
         {
             Console.WriteLine("------------------");
             Console.WriteLine("주소록 정보");
             Console.WriteLine("------------------");
             Console.WriteLine("이름: "+ name);
             Console.WriteLine("전화번호: " + tel);
             Console.WriteLine("주소: " + address);
             Console.WriteLine("이메일: " + email);
         }*/
    }
}
