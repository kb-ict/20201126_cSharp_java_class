using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox1
{
    public partial class Form1 : Form
    {
        int countTime = 0;
        int cTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("캐르릉");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            MessageBox.Show($"내가 빈 칸에 적은 말은 {message}이다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_Time.Text = $"{DateTime.Now.Year}년 {DateTime.Now.Month}월 {DateTime.Now.Day}일 {DateTime.Now.Hour}시" +
                $" {DateTime.Now.Minute}분 {DateTime.Now.Second}초";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //내가 지정한 Interval에 한번씩 동작(1000ms에 한 번 동작)
            label_second.Text = countTime.ToString();
            countTime++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeS.Text = cTime.ToString();
            cTime++;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://duckduckgo.com");

        }
    }
}
