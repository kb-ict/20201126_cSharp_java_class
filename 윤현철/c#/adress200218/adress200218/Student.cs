using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adress200218
{
    class Student
    {
        private string name;
        private string tel;
        private string address;
        private string email;
        private static Student inst;

        /*public static Student getInst()
        {
            if(inst==null)
            { 
                inst = new Student();
            }
            else
            {

            }
        }*/
       /* public Student() { }*/
        public Student(string name, string tel, string address, string email)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

       /* public void showAddress()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"전화: {tel}");
            Console.WriteLine($"주소: {address}");
            Console.WriteLine($"이메일: {email}");

        }*/
    }
}
