using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동",
                "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };

            Student[] students = new Student[10];
            Random r = new Random();

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(name[r.Next(0, 5)], age[r.Next(0, 5)],
                    gender[r.Next(0, 2)], address[r.Next(0, 5)]);
                students[i].ShowStudentInfo();
            }

            students[9].Name = "전우치";
            students[9].Age = 24;
            students[9].Gender = '남';
            students[9].Address = "조선 한양인근 두메산골";
            students[9].ShowStudentInfo();
        }
    }
}
