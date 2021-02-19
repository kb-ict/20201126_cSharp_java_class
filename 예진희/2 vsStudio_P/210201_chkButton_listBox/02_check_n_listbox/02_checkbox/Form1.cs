using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] str = new string[] { };
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = textBox1.Text;
                listBox1.Items.Add(textBox1.Text);
            }
            // DB 연동 연결해봤는지(도서관리...), 포폴로 해봤다 or 다룰 수 있다.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("목록에 선택된 내용이 없습니다.");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }//기획이나 문서작성(스토리보드) 먼저 -> 만듦
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //시작하면서 바로 초기값 설정
            listBox1.Items.Add("첫번째");
        }
    }
}
