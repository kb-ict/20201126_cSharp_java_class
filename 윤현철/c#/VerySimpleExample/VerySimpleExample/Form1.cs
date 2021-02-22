using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerySimpleExample
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
            MessageBox.Show("반갑습니다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;
            MessageBox.Show($"내가 빈 칸에 적은 말은 {message}이다");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lable_nowTime.Text = $"{DateTime.Now.Year}년 {DateTime.Now.Month}월 {DateTime.Now.Day}일 {DateTime.Now.Hour}시 {DateTime.Now.Minute}분 {DateTime.Now.Second}초";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //내가 지정한 Interval에 한번씩 동작!
            label_second.Text = countTime.ToString();
            countTime++;
        }
              
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.naver.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://kb.or.kr");

        }
    }
}
