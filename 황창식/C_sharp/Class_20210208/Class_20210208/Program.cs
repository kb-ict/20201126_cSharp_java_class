using System;

namespace Class_20210208
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("클래스 1번째");
            st.setName("홍길동");
            st.setTel("010-1234-1234");
            st.printStudentInfo();
            Console.WriteLine("이름 : " + st.getName());
            Console.WriteLine("전화 : " + st.getTel());

            Console.WriteLine();

            Student2 st2 = new Student2();
            Console.WriteLine("클래스 2번쨰");
            st2.Name = "김길동";
            st2.Tel = "010-1234-5678";
            st2.printStudentInfo();
            Console.WriteLine("이름 : " + st2.Name);
            Console.WriteLine("전화 : " + st2.Tel);

            Console.WriteLine();

            Console.WriteLine("클래스 3번째");
            Student2 st3 = new Student2("최길동", "010-2222-2222");
            st3.printStudentInfo();

            Console.WriteLine();

            // 1회용 객체 생성 (다시 접근 불가능)
            Console.WriteLine("클래스 4번째");
            new Student2("박길동", "010-3333-3333").printStudentInfo();

            Console.WriteLine();

            Console.WriteLine("클래스 5번째");
            string[] nameArr = { "홍길동", "김길동", "박길동" };
            string[] telArr = { "010-1111-2222", "010-2222-3333", "010-3333-4444" };
            Random r = new Random();
            Student2[] stArr = new Student2[10];
            for (int i = 0; i < stArr.Length; i++)
            {
                stArr[i] = new Student2(nameArr[r.Next(0, 3)], telArr[r.Next(0, 3)]);
                stArr[i].printStudentInfo();
            }

            // 클래스 변수 접근
            Console.WriteLine("과정명 : " + Student2.CLASS);

            // 입력처리
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("나이 입력 : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);



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

        public void printStudentInfo()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화 : " + tel);
        }
    }
}
