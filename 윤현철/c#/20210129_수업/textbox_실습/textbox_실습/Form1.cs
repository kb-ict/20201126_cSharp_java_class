using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
                MessageBox.Show("checked...");
                Console.WriteLine("checked...");
            }
            /*checkBox1.Checked = !checkBox1.Checked;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);

            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*if (e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox1.CheckedItems.Count == 1)
                {
                    //button2.Enabled = false;
                }
            }
            else
            {
               // button2.Enabled = true;
            }*/
            textBox1.Text = textBox1.Text+"e.NewValue : " + e.NewValue +"\r\n";

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string curItem = checkedListBox1.SelectedItem.ToString();
            //textBox1.Text = textBox1.Text + "curItem :" + curItem+"\r\n";
            // Find the string in ListBox2.
           
        }

        private void c(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "selected index : " + checkedListBox1.SelectedIndex + "\r\n";
            if(checkedListBox1.SelectedIndex!=-1)
            {
                MessageBox.Show("Item is not availabe inbox");
                return;
            }
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            /*int index = checkedListBox1.FindString(curItem);
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            if (index == -1)
                MessageBox.Show("Item is not available in ListBox2");
            else
                checkedListBox1.SetSelected(index, true);*/
        }
    }
    
}
