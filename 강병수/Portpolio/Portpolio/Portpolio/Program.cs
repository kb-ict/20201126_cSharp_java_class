using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portpolio
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.Main());
            

            if(false)
            {
                List<Student> list = new List<Student>();
                double average = 0;

                Console.Write("학생의 수를 입력하시오: ");
                int stu_number = int.Parse(Console.ReadLine());


                try
                {
                    for (int i = 0; i < stu_number; i++)
                    {
                        Console.Write("{0}번 학생의 이름: ", (i + 1));
                        string name = Console.ReadLine();
                        Console.Write("{0}번 학생의 국어 점수: ", (i + 1));
                        int kor = int.Parse(Console.ReadLine());
                        if (kor > 100 || kor < 0)
                        {
                            Console.WriteLine("숫자를 잘못 입력하였습니다. 다시 입력하세요");
                            return;
                        }
                        Console.Write("{0}번 학생의 수학 점수: ", (i + 1));
                        int math = int.Parse(Console.ReadLine());
                        Console.Write("{0}번 학생의 영어 점수: ", (i + 1));
                        int eng = int.Parse(Console.ReadLine());
                        Console.Write("{0}번 학생의 한국사 점수: ", (i + 1));
                        int history = int.Parse(Console.ReadLine());
                        average = (kor + math + eng + history) / 4.0;
                        Student scorelist = new Student(stu_number, name, kor, math, eng, history);
                        list.Add(scorelist);
                    }
                }

                catch (IOException e)
                {
                    Console.WriteLine("에러메시지: " + e);
                    Console.WriteLine("잘못된 입력");
                }

                Console.WriteLine("===========학년 성적표===========");
                Console.WriteLine("\t" + "국 어\t" + "수 학\t" + "영 어\t" + "한국사\t");
                for (int j = 0; j < stu_number; j++)
                {
                    Console.WriteLine(list[j].Stu_name + "\t" + list[j].Kor + "\t" + list[j].Math + "\t" + list[j].Eng + "\t" + list[j].History);
                }

                Console.WriteLine("================================");

                Console.WriteLine("SKY 반에 들어갈 학생의 이름들");
                Console.WriteLine("================================");
                for (int i = 0; i < stu_number; i++)
                {

                }
                Console.WriteLine("");
                Console.WriteLine("================================");



            }







        }
    }
}
