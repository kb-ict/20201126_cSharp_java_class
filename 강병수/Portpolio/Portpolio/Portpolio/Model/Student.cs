using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portpolio
{
    class Student
    {
        private int stu_num;
        private string stu_name;
        private int kor;
        private int math;
        private int eng;
        private int history;

        public Student(int stu_num, string stu_name, int kor, int math, int eng, int history)
        {
            this.stu_num = stu_num;
            this.stu_name = stu_name;
            this.kor = kor;
            this.math = math;
            this.eng = eng;
            this.history = history;
        }
        public int Stu_num { get => stu_num; set => stu_num = value; }
        public string Stu_name { get => stu_name; set => stu_name = value; }
        public int Kor { get => kor; set => kor = value; }
        public int Math { get => math; set => math = value; }
        public int Eng { get => eng; set => eng = value; }
        public int History { get => history; set => history = value; }
    }
}
