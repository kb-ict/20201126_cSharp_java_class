using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sam1_butt_txtbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 콤포넌트 ≒ 클래스
            String str = textBox1.Text;
            //var str = textBox1.Text; //var도 가능
            // 속성값을 코딩할 수 있음.
            //가져오면 get을 실행

            //if (str.Length > 0)
            //{
            //    MessageBox.Show(str);
            //}

            //if (!(str.Length < 1))
            //{
            //MessageBox.Show(str);
            //}

            if (str.Trim().Length > 0)
            {
                MessageBox.Show(str);
            }
            // 사칙연산 계산기 예제
        }
    }
}
