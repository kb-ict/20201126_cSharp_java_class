using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap06
{
    public partial class Form1 : Form
    {
        Account a1;
        Account a2;

        public Form1()
        {
            InitializeComponent();
        }

        //계좌를 개설해주는 버튼입니다.
        private void button7_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int money);
            string name = textBox2.Text;

            a1 = new Account(money, name);

            string message = a1.name + "님, " + "잔액은 " + a1.myMoney + "입니다.";

            foreach (var item in Controls)
            {
                if(item is Label)
                {
                    if ((item as Label).Name == "temp")
                        Controls.Remove((item as Label));
                }
            }

            Label msg = new Label();
            msg.Name = "temp";
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(200, 200);
            Controls.Add(msg);

        }
        //계좌를 개설해주는 버튼입니다.
        private void button8_Click(object sender, EventArgs e)
        {
            a2 = a1; //참조변수의 특성상 문제 발생
            //a2 = new Account(a1.myMoney, a1.name); //참조변수 에러 해결하기
            a2.myMoney = int.Parse(textBox4.Text);
            a2.name = textBox3.Text;
            
            string message = a2.name + "님, " + "잔액은 " + a2.myMoney + "입니다.";

            //for (int i = 0; i < 2; i++)
            //{
            //    foreach (var item in Controls)
            //    {
            //        if (item is Label)
            //        {
            //            if ((item as Label).Name == "temp1"
            //                || (item as Label).Name == "temp2")
            //            {
            //                Controls.Remove((item as Label));
            //            }
            //        }
            //    }
            //}
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is Label)
                {
                    if ((Controls[i] as Label).Name == "temp1" || (Controls[i] as Label).Name == "temp2")
                        Controls.Remove((Controls[i] as Label));

                }
            }

            Label msg = new Label();
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(200, 250);
            msg.Name = "temp1";
            Controls.Add(msg);

            Label msg2 = new Label();
            msg2.Text = a2.name + a2.myMoney;
            msg2.AutoSize = true;
            msg2.Location = new Point(200, 300);
            msg2.Name = "temp2";

            Controls.Add(msg2);

            //MessageBox.Show();
        }
    }
}
