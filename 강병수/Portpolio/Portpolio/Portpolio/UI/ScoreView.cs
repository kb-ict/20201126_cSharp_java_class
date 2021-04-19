using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portpolio.UI
{
    public partial class ScoreView : Form
    {
        public ScoreView()
        {
            InitializeComponent();
        }

        // ListView 데이터들을 csv 확장자로 이루어진 엑셀 파일로 저장
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "csv File|*.csv";
            saveFile.Title = "Save";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFile.OpenFile();

                switch (saveFile.FilterIndex)
                {
                    case 1:

                        for (int i = 0; i < StuScore.Items.Count; i++)
                        {
                            string sTmp = "";
                            for (int j = 0; j < StuScore.Items[i].SubItems.Count; j++)
                                sTmp += StuScore.Items[i].SubItems[j].Text + ", ";
                            sTmp += "\n";
                            Byte[] Bytes = Encoding.Default.GetBytes(sTmp); //인코딩 오류 있음 고쳐야 함 --> 인코딩을 Default로 변경하여 해결
                            fs.Write(Bytes, 0, Bytes.Length);
                        }
                        break;
                }

                fs.Close();
            }
        }

        private void ScoreView_Load(object sender, EventArgs e)
        {
            initScoreView();
        }

        // ListView 초기화
        private void initScoreView()
        {
            //List<Student> list = new List<Student>();
            if (Model.DataManager.students.Count == 0)
            {
                MessageBox.Show("데이터가 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            { 
            for (int i = 0; i < Model.DataManager.students.Count; i++)
            {
                double average = (Model.DataManager.students[i].Kor + Model.DataManager.students[i].Math + Model.DataManager.students[i].Eng + Model.DataManager.students[i].History) / 4.0;
                StuScore.Items.Add(new ListViewItem(
                    new string[]
                    {
                        Model.DataManager.students[i].Stu_num.ToString(), Model.DataManager.students[i].Stu_name.ToString(), Model.DataManager.students[i].Kor.ToString(),
                        Model.DataManager.students[i].Math.ToString(), Model.DataManager.students[i].Eng.ToString(), Model.DataManager.students[i].History.ToString(), average.ToString()
                    }
                    ));
            }
            setRowColor(StuScore, Color.White, Color.WhiteSmoke);
            int index = StuScore.Items.Count - 1;
            StuScore.Items[index].Selected = true; // 초기화때 ListView의 마지막 인덱스가 자동적으로 선택되게
            StuScore.Items[index].Focused = true; // 초기화때 ListView의 마지막 인덱스쪽으로 포커스
            StuScore.EnsureVisible(index);
            }
        }
        // ListView 줄마다 색상을 넣어줌
        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        private void ListView_OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
