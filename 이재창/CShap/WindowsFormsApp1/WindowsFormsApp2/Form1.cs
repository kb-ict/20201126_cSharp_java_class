using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int time = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1_Tick(timer1, EventArgs.Empty);
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_message.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_nowTime.Text = $"{DateTime.Now.Year}년" +
                $" {DateTime.Now.Month}월 {DateTime.Now.Day}일" +
                $" {DateTime.Now.Hour}시 {DateTime.Now.Minute}분" +
                $" {DateTime.Now.Second}초";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            int h = time / 3600;
            int tempTime = time % 3600;
            int m = time / 60;
            int s = tempTime % 60;
            label2.Text = $"프로그램 시작 후 {h}시간 {m}분 {s}초 경과"; 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.naver.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://kb.or.kr");
        }
    }
}
