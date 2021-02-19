using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_class
{   // 같은공간에 있는거(패키지)
    class Student2
    {
        // prop
        // 인스턴스 변수(속성)
        private string name;
        private string tel;

        // 클래스 변수 ( - : 인스턴스와 다른 공간에 잡힘, 객체 여러개 생성해도 하나만 참조)
        //public static string CLASS = "Java, C# 응용프로그램 개발자"; // * 클래스변수, 변경가능
        
        // 클래스 상수 변수
        public const string CLASS = "Java, C# 응용프로그램 개발자"; // ** static있느거 처럼 동작

        // 매개변수 존재하는 생성자**, ** ~ *** = 오버로딩
        public Student2()
        {
            name = "박길동";
            tel = "010-1111-1111";
            //기본값 초기화
        }

        // 매개변수 존재하는 생성자*** (많이 씀)
        public Student2(string name, string tel)
        {
            this.name = name;
            this.tel = tel;
        }

      

        // propfull (getter-setter 동시에, Name = 메소드/ 파스칼형식)
        public string Name {
            get { return name; }
            set { name = value; }
        } // value 내부에서 자동으로 만들어짐

        public string Tel {
            get { return tel; }
            set { tel = value; }
        }

        public void printStudentInfo() {
            Console.WriteLine("과정 : "+CLASS);
            //Console.WriteLine("과정 : " + Student2.CLASS); //공용이므로 private X

            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화 : " + tel);
            Console.WriteLine("----------------------");
        }
    }
}
