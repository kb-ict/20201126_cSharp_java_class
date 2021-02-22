using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }

        public Student(string name, int age, char gender, string address)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"나이: {Age}");
            Console.WriteLine($"성별: {Gender}");
            Console.WriteLine($"주소: {Address}");
            Console.WriteLine();
        }
    }
}
