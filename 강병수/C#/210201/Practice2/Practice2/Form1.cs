using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("지정된 인덱스가 존재하지 않습니다.");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            textBox2.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
            textBox2.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
            textBox2.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
            textBox2.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
            textBox2.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
            textBox2.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
            textBox2.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
            textBox2.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
            textBox2.Text += "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            textBox2.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            textBox2.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "#";
            textBox2.Text += "#";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
