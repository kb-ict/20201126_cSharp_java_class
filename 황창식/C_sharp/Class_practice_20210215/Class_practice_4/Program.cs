using System;

namespace Class_practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] language = { "C/C++", "Python", "Java" };
            string[] lecture1 = { "윈도우 프로그래밍 학습", "GUI 프로그래밍 학습", "윈도우 프로그래밍 학습" };
            string[] lecture2 = { 
                "중, 고급 알고리즘을 위한 자료 구조 학습", 
                "네트웍 프로그래밍을 위한 TCP/IP 학습",
                "DB연동을 위한 JDBC 프로그래밍 학습" 
            };
            string[] name = { "김길동", "홍길동", "박길동", "최길동", "이길동", "강길동" };
            char[] gender = { '남', '여' };
            string[] job = { "회사원", "취업 준비생", "가수", "학생", "교사", "환경 미화원" };

            Lecture[] lectures = new Lecture[3];
            for (int i = 0; i < lectures.Length; i++)
            {
                lectures[i] = new Lecture(
                    language[i], 
                    lecture1[i], 
                    lecture2[i], 
                    students[i]
                );
                lectures[i].showLectureInfo();
            }
        }

        public static Student[][] createStudents()
        {
            Random r = new Random();
            string[] name = { "김길동", "홍길동", "박길동", "최길동", "이길동", "강길동" };
            char[] gender = { '남', '여' };
            string[] job = { "회사원", "취업 준비생", "가수", "학생", "교사", "환경 미화원" };
            Student[][] students = new Student[3][];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student[6];
                for (int j = 0; j < students[i].Length; j++)
                {
                    students[i][j] = new Student(
                        name[r.Next(0, 5)],
                        gender[r.Next(0, 2)],
                        r.Next(20, 31),
                        job[r.Next(0, job.Length - 1)]
                    );
                }
            }
            return students;
        }
    }
}
