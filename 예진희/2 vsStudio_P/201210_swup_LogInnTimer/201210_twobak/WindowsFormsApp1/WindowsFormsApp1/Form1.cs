using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int countTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox_massage.Text;
            MessageBox.Show($"내가 빈칸에 적은 말은 {message}이다.");
        }

        private void label_nowTime_Click(object sender, EventArgs e)
        {
            //snake 표기 = 단어사이 밑줄 들어감
            // ind a_abc_ddd = 0;

            //카멜리안 : 소문자시작 단어사이에 대문자
            //  int abcdEfgH;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_nowTime.Text = $"{DateTime.Now.Year}년 " +
                $"{DateTime.Now.Month}월 {DateTime.Now.Day}일 " +
                $"{DateTime.Now.Hour}시 {DateTime.Now.Minute}분 {DateTime.Now.Second}초";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //내가 지정한 interval에 한 번씩 동작
            //여기선 1000ms에 한 번 동작 = "0" 변수값에 넣어줌
            //전역변수 = 바깥쪽 선언
            label_second.Text = countTime.ToString();
            countTime++;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.naver.com/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/?gl=KR");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
