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
using Excel = Microsoft.Office.Interop.Excel;

namespace Portpolio.UI
{
    public partial class Main : Form
    {
        ScoreView score = new ScoreView();

        public Main()
        {
            InitializeComponent();
        }

        // 프로그램 종료
        private void Exit_Program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 학생 정보 삭제(데이터가 없으면 경고창 뜨게)
        private void Delete_Score_Click(object sender, EventArgs e)
        {
            if (Model.DataManager.students.Count == 0)
            {
                MessageBox.Show("학생 데이터가 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            new DeleteStudent().ShowDialog();
            }
        }

        // 학생 정보 생성 메서드를 집어넣음
        private void Add_Score_Click(object sender, EventArgs e)
        {
            new AddStudent().ShowDialog();
        }

        // 학생 정보를 리스트뷰로 조회
        private void View_Score_Click(object sender, EventArgs e)
        {
            new ScoreView().ShowDialog();
        }

        // 학생 정보 수정(데이터가 없으면 경고창 뜨게)
        private void Modify_Score_Click(object sender, EventArgs e)
        {
            if (Model.DataManager.students.Count == 0)
            {
                MessageBox.Show("학생 데이터가 존재하지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new ModifyStudent().ShowDialog();
            }
        }

        // 만든 사람 GitHub 연결
        private void LinktoGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Saratoga93");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
   
        
    }
}
