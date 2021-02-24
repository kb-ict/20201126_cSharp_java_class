using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adressTest0218
{
    /// <summary>
    /// 주소록 관리 클래스
    /// </summary>
    public class StudentManager
    {
        public List<Student> Students { get; set; } = new List<Student>();

        /// <summary>
        /// 주소록 데이터를 출력합니다.
        /// </summary>
        public void View()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Students.Count > 0)
                Console.WriteLine("-----------------------");

            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"번호: {i + 1}");
                Console.WriteLine($"아이디: {Students[i].Id}");
                Console.WriteLine($"이름: {Students[i].Name}");
                Console.WriteLine($"전화: {Students[i].Tel}");
                Console.WriteLine($"주소: {Students[i].Address}");
                Console.WriteLine($"이메일: {Students[i].Email}");
                Console.WriteLine("-----------------------");
                Thread.Sleep(50);
            }
        }

        /// <summary>
        /// 주소록을 추가합니다.
        /// </summary>
        /// <param name="student"></param>
        public void AddItem(Student student)
        {
            Students.Add(student);
        }

        /// <summary>
        /// ID에 해당하는 학생을 주소록에서 삭제합니다.
        /// </summary>
        /// <param name="id"></param>
        public void RemoveItem(string id)
        {
            for (int i = Students.Count - 1; i >= 0; i--)
            {
                if (Students[i].Id == id)
                {
                    Students.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// 주소록을 비웁니다.
        /// </summary>
        public void Clear()
        {
            Students.Clear();
        }

        /// <summary>
        /// ID로 학생을 찾습니다.
        /// </summary>
        /// <param name="id">찾으려는 Student객체의 ID속성값</param>
        /// <returns>찾으면 Student객체 반환, 못 찾으면 null 반환</returns>
        public Student FindStudentById(string id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (id == Students[i].Id)
                {
                    return Students[i];
                }
            }
            return null;
        }  
    }
}
