using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int DisUnit = 1;
        int top = 20;
        int firstBtnCnt = 0;
        private void btnDyntxt_1_Click(object sender, EventArgs e)
        {
            firstBtnCnt++;
            char name = txt + firstBtnCnt;
            Console.WriteLine(firstBtnCnt);
            TextBox name = new TextBox();
            this.Controls.Add(name);


            txt.Top = top + 200;
            txt.Left = 53;
            DisUnit = DisUnit + 1;
            top = top + 50;
            txt.ForeColor = Color.Green;
            txt.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            txt.Width = 150;
            txt.Height = 50;
        }
        int DisUnit2 = 1;
        int top2 = 20;
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = top2 + 200;
            txt.Left = 390;
            DisUnit2 = DisUnit2 + 1;
            top2 = top2 + 50;
            txt.ForeColor = Color.Green;
            txt.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            txt.Width = 150;
            txt.Height = 50;
        }
        int DisUnit3 = 1;
        int top3 = 20;
        private void button2_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = top3 + 200;
            txt.Left = 730;
            DisUnit3 = DisUnit3 + 1;
            top3 = top3 + 50;
            txt.ForeColor = Color.Green;
            txt.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            txt.Width = 150;
            txt.Height = 50;
        }


    }
}