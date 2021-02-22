using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();
        }
    }
}
