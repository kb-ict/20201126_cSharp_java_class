using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.setName("홍길동");
            st.setTel("010-1234-1234");
            st.printStudentinfo();
            Console.WriteLine("이름: " + st.getName());

            Student2 st2 = new Student2();
            st2.Name = "김길동";
            st2.Tel = "010-1234-3456";
            st2.printStudentInfo();
            Console.WriteLine("이름: " + st2.Name);

            Student2 st3 = new Student2("최길동", "010-3545-7782");
            st3.printStudentInfo();

            new Student2("박길동", "010-4541-9900").printStudentInfo();

            string[] nameArr = { "홍길동", "박길동", "김길동" };
            string[] telArr = { "010-1352-6234", "011-525-7433", "010-5235-1743" };


            Random ran = new Random();

            Student2[] stArr = new Student2[10];
            for (int i = 0; i<stArr.Length; i++)
            {
                // Next(0, 3) : 0~2 까지 숫자 발생
                stArr[i] = new Student2(nameArr[ran.Next(0, 3)], telArr[ran.Next(0, 3)]);
                stArr[i].printStudentInfo();
            }

            // 클래스 변수 사용
            Console.WriteLine("과정명: " + Student2.CLASS);
        }
    }

    class Student
    {
        // 캡슐화
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

        public void printStudentinfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("번호: " + tel);
        }
    }
}
