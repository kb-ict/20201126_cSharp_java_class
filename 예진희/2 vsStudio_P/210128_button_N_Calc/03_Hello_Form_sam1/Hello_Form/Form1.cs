using System;
using System.Windows.Forms;

namespace Hello_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // gui코딩
        // 클릭으로 생성하는 이벤트 : 모든 이벤트가 다 나오진 않음

        //private void mybutton1_mouseleave(object sender, EventArgs e)
        //{MessageBox.Show("hello...");}

        // 빈값 입력 시 창 안뜨게
        private void button3_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;

            if (message == "")
            {
                MessageBox.Show("내용을 입력하세요");
            }
            else
            {
                MessageBox.Show($"입력 내용: {message}");
            }


        }
    }
}
