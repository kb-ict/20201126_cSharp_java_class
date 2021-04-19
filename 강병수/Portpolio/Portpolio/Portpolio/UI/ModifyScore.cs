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
    public partial class ModifyScore : Form
    {
        public ModifyScore()
        {
            InitializeComponent();
        }

        private void ExitModify_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyData_Click(object sender, EventArgs e)
        {
            try
            {
                // 텍스트박스에 빈 칸이 존재할 경우
                if (Stu_Name.Text == "" || Stu_Kor.Text == ""
                    || Stu_Math.Text == "" || Stu_Eng.Text == "" || Stu_Histo.Text == "")
                {
                    MessageBox.Show("정보가 누락되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 텍스트박스에 들어있는 숫자가 100 초과, 0 미만일 경우
                if (Convert.ToInt32(Stu_Kor.Text) > 100 || Convert.ToInt32(Stu_Kor.Text) < 0 ||
                    Convert.ToInt32(Stu_Math.Text) > 100 || Convert.ToInt32(Stu_Math.Text) < 0 ||
                    Convert.ToInt32(Stu_Eng.Text) > 100 || Convert.ToInt32(Stu_Eng.Text) < 0 ||
                    Convert.ToInt32(Stu_Histo.Text) > 100 || Convert.ToInt32(Stu_Histo.Text) < 0)
                {
                    MessageBox.Show("부적절한 점수가 존재합니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // 리스트에 학생들의 점수 정보를 덧씌우는 형태로 수정
                for (int i = 0; i<Model.DataManager.students.Count; i++)
                {
                    if (Stu_Name.Text == Model.DataManager.students[i].Stu_name)
                    {
                        Model.DataManager.students[i].Kor = Convert.ToInt32(Stu_Kor.Text);
                        Model.DataManager.students[i].Math = Convert.ToInt32(Stu_Math.Text);
                        Model.DataManager.students[i].Eng = Convert.ToInt32(Stu_Eng.Text);
                        Model.DataManager.students[i].History = Convert.ToInt32(Stu_Histo.Text);
                        MessageBox.Show("학생의 점수 정보가 수정되었습니다.");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("수정할 해당 학생의 이름을 잘못 입력하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Close();
            }
            // 텍스트 박스에 문자열이 들어갈 때 오류가 뜨도록 예외 처리
            catch (Exception f)
            {
                MessageBox.Show("숫자가 아닌 문자를 입력하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                printLog(f.Message);
                printLog(f.StackTrace);
            }
        }

        private void ModifyScore_Load(object sender, EventArgs e)
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
