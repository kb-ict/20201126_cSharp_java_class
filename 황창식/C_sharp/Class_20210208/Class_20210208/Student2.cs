using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_20210208
{
    class Student2
    {
        // 인스턴스 변수(속성)
        private string name;
        private string tel;

        // class 변수
        public static string CLASS = "Java, C# 응용 프로그램 개발자 과정";

        // 오버로딩 (중복 정의)
        public Student2()
        {
            name = "박길동";
            tel = "010-0000-1111";
        }

        public Student2(string name, string tel)
        {
            this.name = name;
            this.tel = tel;
        }

        // propfull

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public void printStudentInfo()
        {
            Console.WriteLine("과정 : " + CLASS);
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화 : " + tel);
            Console.WriteLine("------------------------");
        }

    }
}
