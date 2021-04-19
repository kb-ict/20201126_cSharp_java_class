using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portpolio.UI
{
    public partial class AddStudent : Form
    {

        //List<Student> student = new List<Student>();

        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddScore_Click(object sender, EventArgs e)
        {
            try { 
            if (Stu_Num.Text == "" || Stu_Name.Text == "" || Stu_Kor.Text == ""
                || Stu_Math.Text == "" || Stu_Eng.Text == "" || Stu_Histo.Text == "")
            {
                MessageBox.Show("정보가 누락되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(Stu_Kor.Text) > 100 || Convert.ToInt32(Stu_Kor.Text) < 0 ||
                Convert.ToInt32(Stu_Math.Text) > 100 || Convert.ToInt32(Stu_Math.Text) < 0||
                Convert.ToInt32(Stu_Eng.Text) > 100 || Convert.ToInt32(Stu_Eng.Text) < 0 ||
                Convert.ToInt32(Stu_Histo.Text) > 100 || Convert.ToInt32(Stu_Histo.Text) < 0)
            {
                MessageBox.Show("부적절한 점수가 존재합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student student = new Student(Convert.ToInt32(Stu_Num.Text), Stu_Name.Text, Convert.ToInt32(Stu_Kor.Text),
                                            Convert.ToInt32(Stu_Math.Text), Convert.ToInt32(Stu_Eng.Text), Convert.ToInt32(Stu_Histo.Text));
            Model.DataManager.students.Add(student);
            MessageBox.Show("학생의 점수 정보가 저장되었습니다.");
            Close();
                }
            catch (Exception f)
            {
                MessageBox.Show("숫자가 아닌 문자를 입력하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                printLog(f.Message);
                printLog(f.StackTrace);
            }

        }

        private void ExitScore_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("Trace");
            if (di.Exists == false)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter("Trace" + "\\" + "Log.txt"))
            {
                writer.WriteLine
                    ($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}]{contents}{".txt"}");
            }
        }
    }
}
