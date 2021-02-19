using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makeCalc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("button1_Click value : 1");
            //textBox1.Text += "1";
            //textBox1.Text = textBox1.Text + button1.Text;
            //Button btn = (Button)sender;
            //textBox1.Text = textBox1.Text + btn.Text;
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

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        void ButtonsClick(object sender)
        {
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text; //각 버튼의 매개변수를 받아옴 > 텍스트박스에 버튼텍스트 합한 값을보여준다.

            String[] str = textBox1.Text.Split("+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); // +기호로 문자열 자름 > 유니코드문자 배열로 복사 + (자르는옵션: 공백 삭제)
            if (str.Length == 2)
            {
                int a1 = Convert.ToInt32(str[0]);   //부호 기준으로 나눈 값을 정수형으로 변환
                int a2 = Convert.ToInt32(str[1]);
                int result = a1 + a2;       //정수값 계산
                textBox1.Text = ""+result;  //정수값을 공백문자를 붙여 스트링 전환 후 텍스트 박스에 띄운다.
                //textBox1.Text = String.Format("%d",result);
            }
        }

        void ButtonOperator(object sender)
        {
            if (textBox1.Text.Length > 0)    //텍스트 박스에 입력된 값이(String 문자의 길이) 있을 때
            {
                Button btn = (Button)sender; //버튼의 입력값을 btn변수로 받음*
                if (btn.Text.Equals("+"))    //*의 텍스트가 +와 같을 때

                {   // textBox1.Text 값의 마지막 문장열을 가져온다.
                    String s1 = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);   // 123이면 인덱스 012, 이므로 -1, 마지막 인덱스 2에서 한글자를 변수로 저장
                    if (s1 == "+")                                                      // 마지막 입력값이 부호이면 +연산자를 텍스트 박스에 추가하지 않음
                    { }
                    else
                    {
                        textBox1.Text += btn.Text;  // 입력값이 부호가 아니면 [Button btn = (Button)sender;]의 변수로 정의했던 내부 텍스트 값을 텍스트박스 기존내용에 더하여 보여줌
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
