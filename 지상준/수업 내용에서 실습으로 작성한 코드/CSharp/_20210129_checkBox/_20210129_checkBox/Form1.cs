using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _20210129_checkBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (checkedListBox1.Items.Contains(textBox1.Text) == false)
                    checkedListBox1.Items.Add(textBox1.Text, CheckState.Unchecked);
                textBox1.Text = "";
            }

        }

        // Activates or deactivates the Add button.
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
            button3.Enabled = false;
            button4.Enabled = false;
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
            if (listBox1.Items.Count > 0)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        // Activates the move button if there are checked items.
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox1.CheckedItems.Count == 1)
                {
                    button2.Enabled = false;
                }
            }
            else
            {
                button2.Enabled = true;
            }
        }

        // Saves the items to a file.
        private void button3_Click(object sender, System.EventArgs e)
        {
            // Insert code to save a file.
            listBox1.Items.Clear();
            IEnumerator myEnumerator;
            myEnumerator = checkedListBox1.CheckedIndices.GetEnumerator();
            int y;
            while (myEnumerator.MoveNext() != false)
            {
                y = (int)myEnumerator.Current;
                checkedListBox1.SetItemChecked(y, false);
            }
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                checkedListBox1.Items.Remove(listBox1.Items[i]);
            }
            listBox1.Items.Clear();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 체크박스 초기화
            // Sets up the initial objects in the CheckedListBox.
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);

            // Changes the selection mode from double-click to single click.
            checkedListBox1.CheckOnClick = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            // 콤보박스 초기화
            string[] items = new string[] { "http://www.microsoft.com", "https://github.com/", "https://www.naver.com/"};
            comboBox1.Items.AddRange(items);
            comboBox1.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("콤보박스에 선택한 내용이 없습니다.");
                return;
            }
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("콤보박스에 선택한 내용이 없습니다.");
                return;
            }

            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start(comboBox1.SelectedItem.ToString());
        }

    }
}
