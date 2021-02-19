using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_student
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            String[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "원주시 동구 신암4동" };
            Student[] students = new Student[10];
            Random rand = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i]= new Student(name[rand.Next(0, 5)], age[rand.Next(0, 5)], gender[rand.Next(0, 2)], address[rand.Next(0, 5)]);
            }
           /* for (int i = 0; i < students.Length; i++)
            {
                students[i].showStudentInfo();
            }*/
            students[9].setName("전우치");
            students[9].setAge(24);
            students[9].setGender('남');
            students[9].setAddress("조선 한양인근 두메산골");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].showStudentInfo();
            }
        }
    }
}
