using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_4
{
    class Student
    {
        private string name;
        private char gender;
        private int age;
        private string job;

        public Student(string name, char gender, int age, string job)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.job = job;
        }

        public string Name { get => name; set => name = value; }
        public char Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Job { get => job; set => job = value; }

        public void showStudentInfo(int num)
        {
            // Console.WriteLine("번호\t이름\t성별\t나이\t직업");
            Console.WriteLine("0" + num + "\t" + name + "\t" + gender + "\t" + age + "\t" + job);
        }
    }
}
