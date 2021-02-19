using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_class
{
    class student2
    {
        // 인스턴스 변수
        private string name;
        private string tel;

        // 클래스 변수
        public const string CLASS = "Java, C# 응용프로그램 개발자";


        //prop tap
        /*public string Name { get; set; }*/

        // propfull tap
        public student2()
        {
            name = "박길동";
            tel = "010-2222-2222";
        }
        public student2(string name, string tel)
        {
            this.name = name;
            this.tel = tel;
        }
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
            Console.WriteLine("과정 : "+CLASS);
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화번호 : " + tel);
            Console.WriteLine("-----------------");
        }


    }
}
