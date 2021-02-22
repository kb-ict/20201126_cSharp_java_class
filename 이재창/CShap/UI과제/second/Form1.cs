using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pl_left.Height = btn_dashboard.Height;
            pl_left.Top = btn_dashboard.Top;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pl_left.Height = btn_dashboard.Height;
            pl_left.Top = btn_dashboard.Top;
        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            pl_left.Height = btn_sellers.Height;
            pl_left.Top = btn_sellers.Top;
        }

        private void btn_calender_Click(object sender, EventArgs e)
        {
            pl_left.Top = btn_calender.Top;
            pl_left.Height = btn_calender.Height;
        }

        private void btn_tasks_Click(object sender, EventArgs e)
        {
            pl_left.Height = btn_tasks.Height;
            pl_left.Top = btn_tasks.Top;
        }
    }
}
