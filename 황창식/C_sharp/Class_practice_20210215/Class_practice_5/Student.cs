using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_5
{
    class Student : Lecture
    {
        private string name;
        private char gender;
        private int age;
        private string job;

        public Student(string language, string lecture1, string lecture2, string name, char gender, int age, string job)
        {
            this.Language = language;
            this.Lecture1 = lecture1;
            this.Lecture2 = lecture2;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.job = job;
        }
    }
}
