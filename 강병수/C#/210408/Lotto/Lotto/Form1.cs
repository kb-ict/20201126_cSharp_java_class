using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] prev = new int[6];

        private void Prev_button_Click(object sender, EventArgs e)
        {
            
            prev[0] = Convert.ToInt32(prev_num1.Text);
            prev[1] = Convert.ToInt32(prev_num2.Text);
            prev[2] = Convert.ToInt32(prev_num3.Text);
            prev[3] = Convert.ToInt32(prev_num4.Text);
            prev[4] = Convert.ToInt32(prev_num5.Text);
            prev[5] = Convert.ToInt32(prev_num6.Text);

        }

        private void Roll_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            
            int[] number = new int[6];
            //0이상 10 미만 숫자 하나 출력 Next(10)
            //1이상 46 미만의 숫자 하나 출력 Next(1,46)
            //MessageBox.Show(r.Next(1,46).ToString());

            for(int i = 0; i<number.Length; i++)
            {
                number[i] = r.Next(1, 46);
                for(int j = 0; j < i; j++) {

                    if (number[i] == prev[j])
                    {
                        i--;
                        break;
                    }

                    if (number[i] == number[j])
                    {
                        i--;
                        break;
                    }

                    if (number[i] == (number[j])+1)
                    {
                        i--;
                        break;
                    }

                    if (number[i] == (number[j])-1)
                    {
                        i--;
                        break;
                    }
                }
            }

            first_num.Text = number[0].ToString();
            second_num.Text = number[1].ToString();
            third_num.Text = number[2].ToString();
            forth_num.Text = number[3].ToString();
            fifth_num.Text = number[4].ToString();
            sixth_num.Text = number[5].ToString();

            
        }

        
    }
}
