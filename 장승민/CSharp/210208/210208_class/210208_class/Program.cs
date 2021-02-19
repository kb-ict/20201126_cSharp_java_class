using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.setName("장승민");
            student.setTel("01025354220");
            student.printStudentInfo();
            Console.WriteLine("이름: " + student.getName());

            student2 st = new student2();
            st.Name = "장승민";
            st.Tel = "01023534220";
            st.printStudentInfo();
            Console.WriteLine("이름: " + st.Name);

            student2 st3 = new student2("홍길동", "01023534220");
            st3.printStudentInfo();

            new student2("박길동", "010-3333-3333").printStudentInfo();

            string[] nameArr = { "1길동", "2길동", "3길동" };
            string[] telArr = { "010-1111-1111", "010-2222-2222", "010-3333-3333" };
            Random r = new Random();
            student2[] stArr = new student2[10];
            for (int i = 0; i < stArr.Length; i++)
            {
                stArr[i] = new student2(
                    // Next(0,3) : 0~2 까지 숫자 발생
                    nameArr[r.Next(0, 3)],
                    telArr[r.Next(0, 3)]);
                stArr[i].printStudentInfo();
            }
            Console.WriteLine("과정명: "+student2.CLASS);
        }
    }

    class Student
    {
        private string name;
        private string tel;

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setTel(string tel)
        {
            this.tel = tel;
        }
        public string getTel()
        {
            return tel;
        }
        public void printStudentInfo()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화번호: " + tel);
        }
    }
}
