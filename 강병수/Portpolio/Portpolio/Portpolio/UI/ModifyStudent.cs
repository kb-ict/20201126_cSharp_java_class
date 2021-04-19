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
    public partial class ModifyStudent : Form
    {
        public ModifyStudent()
        {
            InitializeComponent();
        }

        private void ModifyCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyOK_Click(object sender, EventArgs e)
        {
            try 
            { 
                // 텍스트 박스가 빈칸일 경우
                if (StudentNumber.Text == "")
                {
                MessageBox.Show("정보가 누락되었습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // 텍스트 박스에 입력한 학번과 저장된 학번과 일치하는 것이 있는지 확인
                for(int i = 0; i< Model.DataManager.students.Count; i++)
                {
                    if (Model.DataManager.students[i].Stu_num == Convert.ToInt32(StudentNumber.Text))
                    {
                        new ModifyScore().ShowDialog();
                        Close();
                    }
                    else
                    {
                    MessageBox.Show("입력한 번호와 일치하는 학생이 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show("숫자가 아닌 문자를 입력하였습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                printLog(f.Message);
                printLog(f.StackTrace);
            }
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
