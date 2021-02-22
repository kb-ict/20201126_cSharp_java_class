
namespace _20210128_Calc
{
    partial class MyForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btmDivide = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxResult
            // 
            this.txtBxResult.BackColor = System.Drawing.Color.Black;
            this.txtBxResult.ForeColor = System.Drawing.Color.LightGray;
            this.txtBxResult.Location = new System.Drawing.Point(12, 12);
            this.txtBxResult.Multiline = true;
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.ReadOnly = true;
            this.txtBxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxResult.Size = new System.Drawing.Size(217, 78);
            this.txtBxResult.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(30, 112);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(23, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(59, 112);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(23, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(88, 112);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(23, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(30, 141);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(23, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(59, 141);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(23, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(88, 141);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(23, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(30, 170);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(23, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(59, 170);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(23, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(88, 170);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(23, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(59, 199);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(23, 23);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(153, 112);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(23, 23);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(182, 112);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(153, 141);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(23, 23);
            this.btnMultiple.TabIndex = 13;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btmDivide
            // 
            this.btmDivide.Location = new System.Drawing.Point(182, 141);
            this.btmDivide.Name = "btmDivide";
            this.btmDivide.Size = new System.Drawing.Size(23, 23);
            this.btmDivide.TabIndex = 14;
            this.btmDivide.Text = "/";
            this.btmDivide.UseVisualStyleBackColor = true;
            this.btmDivide.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(182, 199);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(23, 23);
            this.btnResult.TabIndex = 15;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(88, 199);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(23, 23);
            this.btnDot.TabIndex = 16;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btn_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 244);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btmDivide);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBxResult);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btmDivide;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnDot;
    }
}

