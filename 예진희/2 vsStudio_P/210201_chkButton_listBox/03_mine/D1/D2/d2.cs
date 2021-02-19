using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2
{
    public partial class d2 : Form
    {
        public d2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                checkBox1.Checked = false;
                int value = Convert.ToInt32(textBox1.Text);

                if (value.GetType != Int32)
                {
                    return;
                }
                progressBar1.Value = value;
            }
            if (checkBox1.Checked == true)
            {
                label1.Text = textBox1.Text;
                listBox1.Items.Add(textBox1.Text);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("선택값 없음");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void d2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("첫번째");
        }
    }
}
