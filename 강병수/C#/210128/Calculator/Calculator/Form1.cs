using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonOper(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonOper(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonOper(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonOper(sender);
        }

        void ButtonsClick(object sender)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;

            String[] str1 = textBox1.Text.Split("+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if( str1.Length ==2)
            {
                int a1 = Convert.ToInt32(str1[0]);
                int a2 = Convert.ToInt32(str1[1]);
                int result = a1 + a2;
                textBox1.Text = "" + result;
                //textBox1.Text = String.Format("%d", result);
            }

            String[] str2 = textBox1.Text.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (str2.Length == 2)
            {
                int b1 = Convert.ToInt32(str2[0]);
                int b2 = Convert.ToInt32(str2[1]);
                int result = b1 - b2;
                textBox1.Text = "" + result;
            }

            String[] str3 = textBox1.Text.Split("*".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (str3.Length == 2)
            {
                int c1 = Convert.ToInt32(str3[0]);
                int c2 = Convert.ToInt32(str3[1]);
                int result = c1 * c2;
                textBox1.Text = "" + result;
            }

            String[] str4 = textBox1.Text.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (str4.Length == 2)
            {
                int d1 = Convert.ToInt32(str4[0]);
                int d2 = Convert.ToInt32(str4[1]);
                double result =(double) d1 / (double) d2;
                textBox1.Text = "" + result;
                //textBox1.Text = String.Format("%d", result);
            }
        }

        void ButtonOper(object sender)
        {
            if (textBox1.Text.Length > 0)
            {
                Button btn = (Button)sender;
                if (btn.Text.Equals("+"))
                {
                    if (textBox1.Text.Substring(textBox1.Text.Length - 1, 1) == "+")      // textBox1.Text 값의 마지막 문자열을 가져온다.
                    {
                    }
                    else { 
                        textBox1.Text += btn.Text;
                    }
                }   
                else if (btn.Text.Equals("-"))
                {
                    if (textBox1.Text.Substring(textBox1.Text.Length - 1, 1) == "-")      // textBox1.Text 값의 마지막 문자열을 가져온다.
                    {
                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }

                }
                else if (btn.Text.Equals("*"))
                {
                    if (textBox1.Text.Substring(textBox1.Text.Length - 1, 1) == "*")      // textBox1.Text 값의 마지막 문자열을 가져온다.
                    {
                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }
                }
                else if (btn.Text.Equals("/"))
                {
                    if (textBox1.Text.Substring(textBox1.Text.Length - 1, 1) == "/")      // textBox1.Text 값의 마지막 문자열을 가져온다.
                    {
                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }
                }
            }
        }
    }
}
