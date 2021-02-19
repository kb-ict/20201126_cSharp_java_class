using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] name = new string[]{ "홍길동","김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            String[] address = { "대구시 동구 신암4동", "인천시 동구 신암4동", "원주시 동구 신암4동", "부산시 동구 신암4동", "서울시 동구 신암4동" };

            Student[] st = new Student[10];

            Random rd = new Random();
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student(name[rd.Next(0, 4)], age[rd.Next(0, 4)], gender[rd.Next(0, 1)], address[rd.Next(0, 4)]);
            }
            /* for (int i = 0; i < st.Length; i++)
             {
                 st[i].showStudentInfo();
             }*/

            st[9].Name = "전우치";
            st[9].Age = 24;
            st[9].Gender= '남';
            st[9].Address= "조선 한양인근 두메산골";
            for (int i = 0; i < st.Length; i++)
            {
                st[i].showStudentInfo();
            }
        }
    }
}
