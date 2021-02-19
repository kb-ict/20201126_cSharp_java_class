using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(
                "checkBox1.Checked : " 
                + checkBox1.Checked
                );
            
            //checkBox1.Checked = true;

            if( checkBox1.Checked )
            {
                checkBox1.Checked = false;
            } else
            {
                checkBox1.Checked = true;

                MessageBox.Show("checked...");
            }

            //checkBox1.Checked = !checkBox1.Checked;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sets up the initial objects in the CheckedListBox.
            string[] myFruit = 
                { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);

            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*if (e.NewValue == CheckState.Unchecked)
            {
            }
            else
            {
            }*/

            textBox1.Text = textBox1.Text 
                + "e.NewValue : " 
                + e.NewValue + "\r\n";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string curItem = 
                checkedListBox1.SelectedItem.ToString();
            textBox1.Text = textBox1.Text
                + "curItem : "
                + curItem + "\r\n";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "selected index : " 
                + checkedListBox1.SelectedIndex
                + "\r\n";
            
            if ( checkedListBox1.SelectedIndex == -1 )
            {
                MessageBox.Show("Item is not availabe in box");
            }

            checkedListBox1.Items.RemoveAt(
                checkedListBox1.SelectedIndex
                );

        }
    }
}
