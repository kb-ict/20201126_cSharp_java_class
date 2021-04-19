using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyStruct
{
    public partial class Form1 : Form
    {
        Account a1;
        Account a2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1 = new Account(100, textBox1.Text);
            MessageBox.Show(a1.name+a1.myMoney);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a2 = a1;
            a2.name = textBox2.Text;
            a2.myMoney = 1234;
            MessageBox.Show(a1.name + a1.myMoney);
            MessageBox.Show(a2.name + a2.myMoney);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int a);
            int.TryParse(textBox4.Text, out int b);
            swapFunction(a, b);
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("변경?");

            swapFunction(ref a, ref b);
            MessageBox.Show("변경 완료");
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("변경 완료!");


        }
        private void swapFunction(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void swapFunction(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //out 키워드 
        //이 함수는 반환형은 없지만
        //2개의 변수 값을 바꾼다.
        private void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            //다음 위치 = 현재 위치 + 현재 속도
            rx = x + vx;
            ry = y + vy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox7.Text, out int x);
            int.TryParse(textBox8.Text, out int y);
            int.TryParse(textBox9.Text, out int vx);
            int.TryParse(textBox10.Text, out int vy);
            MessageBox.Show($"x={x}, y={y}");
            NextPosition(x, y, vx, vy, out x, out y); 
            MessageBox.Show($"x={x}, y={y}");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //outExample(out int abc, out int def, out int hij);
            int abc;
            int def;
            int hij;
            outExample(out abc, out def, out hij);
            MessageBox.Show(abc+def+hij+"");

            foreach (var item in Controls)
            {
                //if(item is TextBox)
                //{
                //    (item as TextBox).Text = "안녕";
                //}
                var temp = item as TextBox;
                if (temp != null)
                    temp.Text = "가나다라마바";
            }
            
        }
        private void outExample(out int a, out int b, out int c)
        {
            a = 100;
            b = 200;
            c = 300;
        }
    }
}
