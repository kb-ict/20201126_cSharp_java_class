using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1
{
    public partial class d1 : Form
    {
        public d1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            { btnClick(sender); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            { btnClick(sender); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            { btnClick(sender); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            { btnClick(sender); }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            { btnClick(sender); }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            { btnClick(sender); }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            { btnClick(sender); }
        }

        void btnClick(object sender)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            label1.Text += btn.Text;
        }
    }
}
