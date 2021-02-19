using System;
using System.Windows.Forms;

namespace EmartIbgu_Kiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _1st_Main1.BringToFront();
            _2nd_bestSeller1.BringToFront();
            _3_NowSale1.BringToFront();
            _3rd_Location1.BringToFront();
            _4th_customerCenter1.BringToFront();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _3_NowSale1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _3rd_Location1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _4th_customerCenter1.BringToFront();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _1st_Main1.BringToFront();
        }

        private void _2nd_bestSeller1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            _2nd_bestSeller1.BringToFront();
        }

        private void _1st_Main1_Load(object sender, EventArgs e)
        {

        }

        private void _4th_customerCenter1_Load(object sender, EventArgs e)
        {

        }

        private void _3rd_Location1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void _3_NowSale1_Load(object sender, EventArgs e)
        {

        }
    }
}
