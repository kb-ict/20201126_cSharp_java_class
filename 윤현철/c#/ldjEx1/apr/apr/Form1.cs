using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apr
{
    public partial class Form1 : Form
    {
        List<string> b = new List<string>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            b.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            b.Add("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            b.Add("-");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
            b.Add("*");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
            b.Add("/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double sum = 0;
            string[] a = textBox1.Text.Split(new char[] { '+', '-', '*', '/' });
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Convert.ToInt32(a[i]);
            }
            if (b[0] == "+")
            {
                sum = c[0]+c[1];
            }
            else if (b[0] == "-")
            {
                sum = c[0] - c[1];
            }
            else if (b[0] == "*")
            {
                sum = c[0] * c[1];
            }
            else 
            {
                sum = c[0] / c[1];
            }
            if (a.Length > 2)
            {
                for (int i = 0; i < a.Length-2; i++)
                {
                    if (b[i+1] == "+")
                    {
                        sum = sum + c[i+2];
                    }
                    else if (b[i + 1] == "-")
                    {
                        sum = sum - c[i + 2];
                    }
                    else if (b[i + 1] == "*")
                    {
                        sum = sum * c[i + 2];
                    }
                    else
                    {
                        sum = sum / c[i + 2];
                    }
                }
            }
            textBox1.Text = textBox1.Text + "=" + sum;
        }
    }
}
