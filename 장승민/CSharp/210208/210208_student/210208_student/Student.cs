using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_student
{
    class Student
    {
        private string name;        
        private int age;
        private char gender;
        private string address;

        public Student(string name, int age, char gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setGender(char gender)
        {
            this.gender = gender;
        }
        public char getGender()
        {
            return gender;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return address;
        }

        public void showStudentInfo()
        {
            Console.WriteLine("이름: "+ name);
            Console.WriteLine("나이: " + age);
            Console.WriteLine("성별: " + gender);
            Console.WriteLine("주소: " + address);
            Console.WriteLine("=======================");


        }
    }
}
