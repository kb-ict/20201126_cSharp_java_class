﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210215
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

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        public void showStudentInfo()
        {
            Console.WriteLine("----- 학생 정보 -----");
            Console.WriteLine("학생 이름 : " + name);
            Console.WriteLine("학생 나이 : " + age);
            Console.WriteLine("학생 성별 : " + gender);
            Console.WriteLine("학생 주소 : " + address);
            Console.WriteLine();
        }
    }
}
