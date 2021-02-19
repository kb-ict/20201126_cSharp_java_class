using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_4
{
    class Lecture
    {
        private string language;
        private string lecture1;
        private string lecture2;
        private Student[] students;

        public Lecture(string language, string lecture1, string lecture2, Student[] students)
        {
            this.Language = language;
            this.Lecture1 = lecture1;
            this.Lecture2 = lecture2;
            this.Students = students;
        }

        public string Language { get => language; set => language = value; }
        public string Lecture1 { get => lecture1; set => lecture1 = value; }
        public string Lecture2 { get => lecture2; set => lecture2 = value; }
        internal Student[] Students { get => students; set => students = value; }

        public void showLectureInfo()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("한국대학교 " + language + " 강좌");
            Console.WriteLine("------------------------------");
            Console.WriteLine("[기본 강의 내용]");
            Console.WriteLine("1. " + language + " 기본 문법 학습");
            Console.WriteLine("2. " + language + " 기본 로직 학습");
            Console.WriteLine("------------------------------");
            Console.WriteLine("[추가 강의 내용]");
            Console.WriteLine("1. " + language + " " + lecture1);
            Console.WriteLine("2. " + lecture2);
            Console.WriteLine("------------------------------");
            Console.WriteLine("번호\t이름\t성별\t나이\t직업");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].showStudentInfo(i+1);
            }
            Console.WriteLine();
        }
    }
}
