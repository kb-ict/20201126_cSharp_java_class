using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }*/

            checkBox1.Checked = !checkBox1.Checked;
            if (checkBox1.Checked)
            {
                //MessageBox.Show("Test");
                Console.WriteLine(checkedListBox1.Items[0]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            textBox1.Text += $"{checkedListBox1.Items[e.Index]}: {e.NewValue}\r\n";
        }

        // clear 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();         
        }

        // 추가 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            string[] strItems = new string[] { "둘리", "도우너", "또치", "고길동" };
            checkedListBox1.Items.AddRange(strItems);
            checkedListBox1.SelectedIndex = checkedListBox1.Items.Count - 1;
        }
        
        // 삭제 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            if (index != -1)
            {
                checkedListBox1.Items.RemoveAt(index);
            }
            Process.Start("");
        }
    }
}
