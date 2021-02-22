using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Start
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.Name.IndexOf("btn") == 0)
                {
                    c.Click += btn_Click;
                }
            }
        }

        // 버튼 클릭 이벤트의 콜백 메서드
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int length = tb_calc.Text.Length;

            if (btn.Name == "btn_add")
            {
                if (length > 0)
                {
                    if (Check())
                    {
                        tb_calc.Text += "+";
                        list.Add("+");
                    }
                }
            }
            else if (btn.Name == "btn_sub")
            {
                if (length > 0)
                {
                    if (Check())
                    {
                        tb_calc.Text += "-";
                        list.Add("-");
                    }
                }
            }
            else if (btn.Name == "btn_mul")
            {
                if (length > 0)
                {
                    if (Check())
                    {
                        tb_calc.Text += "*";
                        list.Add("*");
                    }
                }
            }
            else if (btn.Name == "btn_div")
            {
                if (length > 0)
                {
                    if (Check())
                    {
                        tb_calc.Text += "/";
                        list.Add("/");
                    }
                }
            }
            else if (btn.Name == "btn_result")
            {
                if (length > 0)
                {
                    if (Check())
                    {
                        ShowResult();
                    }
                }
            }
            else if (btn.Name == "btn_clear")
            {
                tb_calc.Clear();
            }
            else
            {
                // 버튼의 Name 속성의 앞에서부터 4글자("btn_")를 지움
                tb_calc.Text += btn.Name.Remove(0, 4);
            }
        }

        // 텍스트 박스의 가장 오른쪽 문자열이 숫자인지 아닌지 확인함
        private bool Check()
        {
            // 텍스트 박스의 가장 오른쪽 문자열을 가져옴
            switch (tb_calc.Text.Substring(tb_calc.Text.Length - 1))
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    return false;
                default:
                    return true;
            }
        }

        // 계산 후 텍스트 박스에 출력
        private void ShowResult()
        {
            string[] values = tb_calc.Text.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            double result = double.Parse(values[0]);
            for (int i = 0; i < values.Length - 1; i++)
            {
                switch (list[i])
                {
                    case "+":
                        result += double.Parse(values[i + 1]);
                        break;
                    case "-":
                        result -= double.Parse(values[i + 1]);
                        break;
                    case "*":
                        result *= double.Parse(values[i + 1]);
                        break;
                    case "/":
                        result /= double.Parse(values[i + 1]);
                        break;
                }
            }

            tb_calc.Text = result.ToString();
            // 리스트를 비워줌
            list.Clear();
        }        
    }
}