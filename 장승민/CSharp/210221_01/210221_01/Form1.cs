using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _210221_01
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(label1.Text.Length<5) label1.Text += "1";

            if (textBox1.Text.Length < 5) textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "2";

            if (textBox1.Text.Length < 5) textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "3";

            if (textBox1.Text.Length < 5) textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "4";

            if (textBox1.Text.Length < 5) textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "5";

            if (textBox1.Text.Length < 5) textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "6";

            if (textBox1.Text.Length < 5) textBox1.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "7";

            if (textBox1.Text.Length < 5) textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "8";

            if (textBox1.Text.Length < 5) textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "9";

            if (textBox1.Text.Length < 5) textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 5) label1.Text += "0";

            if (textBox1.Text.Length < 5) textBox1.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }
    }
}
