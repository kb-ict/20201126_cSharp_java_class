using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] items = new string[] { "토마토", "사과", "오렌지" };
            checkedListBox1.Items.AddRange(items);
            checkedListBox1.CheckOnClick = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("목록에서 선택한 내용이 없습니다.");
                //return;
            }
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-------------------------\r\n";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                textBox1.Text += "B. checked : " + checkedListBox1.CheckedItems[i] + "\r\n";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*String item = checkedListBox1.SelectedItem.ToString();
            textBox1.Text += item + "\r\n";*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] items = new string[] {"가나다","123","abc","라마바","def"};
            comboBox1.Items.AddRange(items);
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("콤보박스에 선택한 내용이 없습니다");
                return;
            }
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {   //e = 
            textBox1.Text += "A. index : " + e.Index + ", value : " + e.NewValue + "\r\n";
        }

        
    }
}
