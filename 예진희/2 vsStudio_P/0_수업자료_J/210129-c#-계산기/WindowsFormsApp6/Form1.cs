using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
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
            ButtonOperator(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonOperator(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonOperator(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonOperator(sender);
        }

        void ButtonsClick(object sender)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;

            String[] str = 
                textBox1.Text.Split(
                    "+".ToCharArray()
                    , StringSplitOptions.RemoveEmptyEntries
                    );
            if( str.Length == 2 )
            {
                int a1 = Convert.ToInt32(str[0]);
                int a2 = Convert.ToInt32(str[1]);
                int result = a1 + a2;
                textBox1.Text = "" + result;
                
            }
        }

        void ButtonOperator(object sender)
        {
            if (textBox1.Text.Length > 0)
            {
                Button btn = (Button)sender;
                if( btn.Text.Equals("+") )
                {
                    //textBox1.Text 값의 마지막 문자열를 가져온다.
                    String s1 = textBox1.Text.Substring(
                        textBox1.Text.Length - 1
                        , 1
                        );

                    if ( s1=="+" ) {
                    } else
                    {
                        textBox1.Text += btn.Text;
                    }
                } 
                else if (btn.Text.Equals("-"))
                {

                }
                else if (btn.Text.Equals("*"))
                {

                }
                else if (btn.Text.Equals("/"))
                {

                }
            }
        }
    }
}
