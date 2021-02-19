using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210215
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };

            Student[] st = new Student[10];
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student(name[r.Next(0, 5)], age[r.Next(0, 5)], gender[r.Next(0, 2)], address[r.Next(0, 5)]);
                st[i].showStudentInfo();
            }

            st[9] = new Student("전우치", 24, '남', "조선 한양인근 두메산골");
            Console.WriteLine("----- 수정 완료 -----\n");
            st[9].showStudentInfo();
        }
    }
}
