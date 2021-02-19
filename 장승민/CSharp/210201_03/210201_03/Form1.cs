using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _210201_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || (radioButtonWoman.Checked == false && radioButtonMan.Checked == false))
            {
                MessageBox.Show("필수값을 입력하시오.");
                textBox1.Text = "";
                radioButtonMan.Checked = false;
                radioButtonWoman.Checked = false;
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                listBox1.Items.Add("이름 : " + textBox1.Text + "  성별 : " + radioButtonMan.Name + "  나이 : " + textBox2.Text + "  소속 : " + textBox3.Text);
                textBox1.Text = "";
                radioButtonMan.Checked = false;
                radioButtonWoman.Checked = false;
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonMan.Name = "남성";
        }

        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonMan.Name = "여성";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("목록에서 선택된 것이 없습니다.");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
