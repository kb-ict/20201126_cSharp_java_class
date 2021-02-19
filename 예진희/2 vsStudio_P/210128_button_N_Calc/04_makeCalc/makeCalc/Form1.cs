using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // https://m.blog.naver.com/pko603/221586472178
            
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnTmp = (Button)sender;
            textBox1.Text += btnTmp.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string[] plusSplit = textBox1.Text.Split('+');
            //텍스트를 +로 split
            double result = 0;

            for (int i = 0; i < plusSplit.Length; i++)
            {
                String[] minusSplit = plusSplit[i].Split('-');
                double minusSplitResult = 0;

                for (int j = 0; j < minusSplit.Length; j++)
                {
                    string[] multiSplit = minusSplit[j].Split('*');
                    double multiSplitResult = 0;
                    for (int k = 0; k < multiSplit.Length; k++)
                    {
                        string[] divSplit = multiSplit[k].Split('/');
                        double divSplitResult = 0;

                        for (int l = 0; l < divSplit.Length; l++)
                        {
                            if (l == 0)
                                divSplitResult += Convert.ToDouble(divSplit[l]);
                            else
                                divSplitResult /= Convert.ToDouble(divSplit[l]);
                        }
                        multiSplit[k] = Convert.ToString(divSplitResult);
                        if (k == 0)
                            multiSplitResult += Convert.ToDouble(multiSplit[k]);
                        else
                            multiSplitResult -= Convert.ToDouble(multiSplit[k]);
                    }
                    multiSplit[j] = Convert.ToString(multiSplitResult);
                    if (j == 0)
                        minusSplitResult += Convert.ToDouble(minusSplit[j]);
                    else
                        minusSplitResult -= Convert.ToDouble(minusSplit[j]);

                }
                plusSplit[i] = Convert.ToString(minusSplitResult);

                Console.WriteLine(plusSplit[i]);
                result += Convert.ToDouble(plusSplit[i]);
            }

            label1.Text = Convert.ToString(result);
            // 라벨의 텍스트에 결과를 넣음
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
    }
}
