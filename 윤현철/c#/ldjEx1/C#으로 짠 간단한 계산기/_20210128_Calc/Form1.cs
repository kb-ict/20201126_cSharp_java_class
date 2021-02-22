using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _20210128_Calc
{
    public partial class MyForm : Form
    {
        // ArrayList numList = new ArrayList();
        string split = string.Empty;
        double result = 0;
        Boolean isFirst = true;
        Boolean isEnd = false;
        Boolean isDivideZero = false;
        Button previous_calcBtn = null;
        Button current_calcBtn = null;

        Boolean calcBtnToggle = false;

        public MyForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtBxResult.Text += btn.Text;
            calcBtnToggle = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            current_calcBtn = (Button)sender;

            string[] numItems;
            double numItem;

            if(!calcBtnToggle)
            {
                MessageBox.Show("연산자를 연속 입력하거나 혹은, 연산할 숫자가 없습니다. 잘못된 입력");

                isFirst = true;
                isEnd = false;
                split = string.Empty;
                result = 0;
                calcBtnToggle = false;

                txtBxResult.Text = "";
                return;
            }

            calcBtnToggle = true;

            if (isFirst)
            {
                numItem = double.Parse(txtBxResult.Text);

                txtBxResult.Text += current_calcBtn.Text;
                previous_calcBtn = current_calcBtn;

                split = txtBxResult.Text;

                result = numItem;
                isFirst = false;
                return;
            }


            string calc = previous_calcBtn.Text;
            switch (calc)
            {
                case "+":
                    numItems = txtBxResult.Text.Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries);
                    if (!isEnd)
                    {
                        txtBxResult.Text += current_calcBtn.Text;
                        split = txtBxResult.Text;
                    }
                    numItem = double.Parse(numItems[0]);
                    result += numItem;
                    break;

                case "-":
                    numItems = txtBxResult.Text.Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries);
                    if (!isEnd)
                    {
                        txtBxResult.Text += current_calcBtn.Text;
                        split = txtBxResult.Text;
                    }
                    numItem = double.Parse(numItems[0]);
                    result -= numItem;
                    break;

                case "*":
                    numItems = txtBxResult.Text.Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries);
                    if (!isEnd)
                    {
                        txtBxResult.Text += current_calcBtn.Text;
                        split = txtBxResult.Text;
                    }
                    numItem = double.Parse(numItems[0]);
                    result *= numItem;
                    break;

                case "/":
                    numItems = txtBxResult.Text.Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries);
                    if (!isEnd)
                    {
                        txtBxResult.Text += current_calcBtn.Text;
                        split = txtBxResult.Text;
                    }
                    numItem = double.Parse(numItems[0]);
                    if (numItem == 0)
                    {
                        MessageBox.Show("0은 잘못된 입력");

                        isFirst = true;
                        isEnd = false;
                        split = string.Empty;
                        result = 0;
                        isDivideZero = true;

                        txtBxResult.Text = "";
                        return;
                    }
                    result /= numItem;


                    break;

                default:
                    break;
            }
            previous_calcBtn = current_calcBtn;


        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            isEnd = true;
            btnCalc_Click(current_calcBtn, e);

            if(!isDivideZero)
                MessageBox.Show(result.ToString());

            isFirst = true;
            isEnd = false;
            split = string.Empty;
            result = 0;
            calcBtnToggle = false;
            isDivideZero = false;

            txtBxResult.Text = "";
        }
    }
}
