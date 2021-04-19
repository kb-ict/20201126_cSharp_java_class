using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fruit = new string[] { "사과", "딸기", "배", "감", "포도", "토마토", "귤", "파인애플", "코코넛" };
            checkedListBox1.Items.AddRange(fruit);
            checkedListBox1.CheckOnClick = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("체크 리스트 박스에 선택된 항목이 없음");
                return;
            }
            else
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] vagatable = new string[] { "배추", "무", "당근", "오이", "양파" };
            comboBox1.Items.AddRange(vagatable);
            comboBox1.SelectedIndex = 0;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("콤보 박스에 선택된 항목이 없음");
                return;
            }
            else
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            textBox1.Text += e.Index + "." + e.NewValue + ":" + checkedListBox1.SelectedItem +  "\r\n";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "체크된 아이템\r\n";
            for (int i = 0; i<checkedListBox1.CheckedItems.Count; i++)
            {
                textBox1.Text += "" + checkedListBox1.CheckedItems[i] + "\r\n";
            }
        }
    }
}
