using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_class
{
    // namespace c++ 클래스 이름충돌 막는거(package개념)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- 1-1. 클래스 설정 및 값출력 -------");
            Student st = new Student();
            // Student(타입) st(변수명)* = new Student(); 객체생성자, "인스턴스"를 만든다.. 
            // (-) * : 생성된 인스턴스 변수로 마킹
            // (-) 생성된 Instance(객체, Object) 변수와 메소드가 다 들어옴
            // (-) name, tel 인스턴스 변수, print() 인스턴스 메소드

            // (-) 범용 스타일
            st.setName("홍길동");
            st.setTel("010-1234-1234");
            st.printStudentInfo();
            Console.WriteLine("★ 이름 : " + st.getName());
            // st.name -> 캡슐화 위배, public선언 된 거에 접근.. 
            // 1. 캡슐화 : 변수 노출x, private (변수 중복사용 제한)


            Console.WriteLine("\n------- 1-2. propfull (많이 씀) -------");
            Student2 st2 = new Student2();
            //Name (변수아닌 특수한 메소드)
            st2.Name = "김길동";
            st2.Tel = "010-1234-2234";
            st2.printStudentInfo();
            Console.WriteLine("★ 이름 : "+st2.Name);


            Console.WriteLine("\n------- 1-3. 매개변수ㅇ 생성자로 초기화, 기본생성자로 초기값 설정 -------");
            Student2 st3 = new Student2("최길동","010-2222-2222");
            st3.printStudentInfo();

            new Student2("최2길동", "010-3333-3333").printStudentInfo();
            // 마킹없어서 재사용 불가능

            // 클래스타입의 빈배열 생성
            string[] nameArr = {"홍길동","김길동","박길동"};
            string[] telArr = {"010-1111-1111","010-2222-2222","010-3333-3333"};
            Random r = new Random();
            Console.WriteLine("\n------- 2. 클래스타입의 빈배열 생성 -------");
            Student2[] stArr = new Student2[10];
            for(int i = 0; i<stArr.Length; i++)
            {
                Console.WriteLine($"----- {i+1}번째 학생 -----");
                stArr[i] = new Student2(
                // Next(0,3) : 0 ~ 2까지 숫자 발생
                nameArr[r.Next(0,3)], telArr[r.Next(0, 3)]);
                stArr[i].printStudentInfo();
            }

            // 클래스 변수 사용
            Console.WriteLine("★ 과정명 : " + Student2.CLASS);

            // (-) c# .netFramework 위에서 돌아감     MS
            // (-) java = jvm
        }
    }

    class Student
    {   // 캡슐화
        private string name;
        private string tel;

        // 생성자, getter, setter
        // java 문법, 수동으로 적기
        // (-) setName 인터페이스 역할
        public void setName(string name)
        { this.name = name; }
        //this 객체 위치정보값
        public string getName()
        { return name; }

        public void setTel(string tel)
        { this.tel = tel; }
        public string getTel()
        { return tel; }

        public void printStudentInfo()
        { Console.WriteLine("이름 : " + name);
          Console.WriteLine("전화 : " + tel); }
          //모델, 데이터 클래스(getter-setter 있는 거)
          //c, c++, c#, java, phython
    }
}
