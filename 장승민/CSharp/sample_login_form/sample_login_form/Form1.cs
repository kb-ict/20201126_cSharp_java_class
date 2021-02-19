using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string message = $"{textBox1.Text},{textBox2.Text} ";
            //MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"{textBox1.Text},{textBox2.Text} ";
            MessageBox.Show(message);
        }
    }
}
