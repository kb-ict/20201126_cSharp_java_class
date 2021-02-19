using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munMine2
{
    class Student2_1mine
    {
        private string name;
        private int age;
        private char gender;
        private string address;

        public void set2_1mine(string name, int age, char gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public void showStudentInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"나이 : {age}");
            Console.WriteLine($"성별 : {gender}");
            Console.WriteLine($"주소 : {address}");
            Console.WriteLine("---------------------\n");
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
    }
}
