using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201210_sample_login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"{textBox2.Text}, {textBox1.Text}";
            MessageBox.Show(message);

            int a = 123;
            int b = 456;

           /* string ex = $"첫번째 숫자는 {a}";
            string ex = $"첫번째 숫자는 {a}"; => 자바형*/
        }
    }
}
