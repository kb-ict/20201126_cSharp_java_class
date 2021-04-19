using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("checkedBox1.Checked: "+ checkBox1.Checked);

            //checkBox1.Checked = true;

            if(checkBox1.Checked)
            {
                checkBox1.Checked = false;
            } else
            {
                checkBox1.Checked = true;
                MessageBox.Show("체크됨");
            }

            // checkBox1.Checked = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] Item = { "토마토", "사과", "오렌지" };
            checkedListBox1.Items.AddRange(Item);
            checkedListBox1.CheckOnClick = true;
            
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string item = checkedListBox1.SelectedItem.ToString();
            textBox1.Text += item + "\r\n";*/
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /* if (e.NewValue == CheckState.Unchecked)
             {
             }
             else
             {
                 //button2.Enabled = true;
             } */

            textBox1.Text += "e.NewValue" + e.NewValue + "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("체크리스트 박스에 선택한 내용이 없음");
                return;
            }

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);

            /*int index = listBox2.FindString(curItem);
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");
            else
                listBox2.SetSelected(index, true); */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] items = new string[] { "참외", "감자", "오이", "수박", "고구마" };
            comboBox1.Items.AddRange(items);
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           if( comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("콤보박스에 선택된 내용이 없음");
                return;
            }
            else
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }
    }
}
