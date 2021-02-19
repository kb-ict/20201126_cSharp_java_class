using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("checkBox1.Checked : " + checkBox1.Checked);
            //checkBox1.Checked = true;
            if (checkBox1.Checked)    // [1-2번] : 1-1 생략, 체크상태일 때 미체크한다.
            {
                checkBox1.Checked = false;
            }
            else                      // 미체크일 때 체크한다.
            {
                checkBox1.Checked = true;
            }

            // 체크가 돼있으면 [1-1번]
            /*if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;      //체크해제

            }
            else//체크상태가 아니면
            {
                checkBox1.Checked = true;       //체크표시해라
                //MessageBox.Show("checked..");   //버튼 클릭시 경고창으로 내용표시
            }*/

            // bull형, 참 거짓밖에 없어서 가능, 자신의 값만 비교하기때문에 줄일 수 있음 [2번] : 다 줄임
            //checkBox1.Checked = !checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sets up the initial objects in the CheckedListBox.
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);
            checkedListBox1.CheckOnClick = true; // 한번만 눌렀을 때 체크되도록 함
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*if (e.NewValue == CheckState.Unchecked)
            {
                button2.Enabled = false; // 활성화 여부
            }
            else
            {
                button2.Enabled = true;
            }*/
            textBox1.Text = textBox1.Text + "e.NewValue " + e.NewValue + "\r\n"; //+= 가능
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string curItem = checkedListBox1.SelectedItem.ToString();
            textBox1.Text = textBox1.Text + "curItem : " + curItem + "\r\n";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "selected index : " + checkedListBox1.SelectedIndex + "\r\n";
            if (checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Item is not available in box");
                return;
            }

            checkedListBox1.Items.RemoveAt(
                checkedListBox1.SelectedIndex);

        }
    }
}
