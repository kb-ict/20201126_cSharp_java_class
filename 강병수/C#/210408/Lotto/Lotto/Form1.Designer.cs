
namespace Lotto
{
    partial class Form1
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
            this.first_num = new System.Windows.Forms.Label();
            this.second_num = new System.Windows.Forms.Label();
            this.third_num = new System.Windows.Forms.Label();
            this.forth_num = new System.Windows.Forms.Label();
            this.fifth_num = new System.Windows.Forms.Label();
            this.sixth_num = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prev_num1 = new System.Windows.Forms.TextBox();
            this.prev_num2 = new System.Windows.Forms.TextBox();
            this.prev_num3 = new System.Windows.Forms.TextBox();
            this.prev_num4 = new System.Windows.Forms.TextBox();
            this.prev_num5 = new System.Windows.Forms.TextBox();
            this.prev_num6 = new System.Windows.Forms.TextBox();
            this.Prev_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first_num
            // 
            this.first_num.AutoSize = true;
            this.first_num.Location = new System.Drawing.Point(41, 200);
            this.first_num.Name = "first_num";
            this.first_num.Size = new System.Drawing.Size(11, 12);
            this.first_num.TabIndex = 0;
            this.first_num.Text = "-";
            // 
            // second_num
            // 
            this.second_num.AutoSize = true;
            this.second_num.Location = new System.Drawing.Point(86, 200);
            this.second_num.Name = "second_num";
            this.second_num.Size = new System.Drawing.Size(11, 12);
            this.second_num.TabIndex = 1;
            this.second_num.Text = "-";
            // 
            // third_num
            // 
            this.third_num.AutoSize = true;
            this.third_num.Location = new System.Drawing.Point(131, 199);
            this.third_num.Name = "third_num";
            this.third_num.Size = new System.Drawing.Size(11, 12);
            this.third_num.TabIndex = 2;
            this.third_num.Text = "-";
            // 
            // forth_num
            // 
            this.forth_num.AutoSize = true;
            this.forth_num.Location = new System.Drawing.Point(176, 199);
            this.forth_num.Name = "forth_num";
            this.forth_num.Size = new System.Drawing.Size(11, 12);
            this.forth_num.TabIndex = 3;
            this.forth_num.Text = "-";
            // 
            // fifth_num
            // 
            this.fifth_num.AutoSize = true;
            this.fifth_num.Location = new System.Drawing.Point(221, 198);
            this.fifth_num.Name = "fifth_num";
            this.fifth_num.Size = new System.Drawing.Size(11, 12);
            this.fifth_num.TabIndex = 4;
            this.fifth_num.Text = "-";
            // 
            // sixth_num
            // 
            this.sixth_num.AutoSize = true;
            this.sixth_num.Location = new System.Drawing.Point(266, 198);
            this.sixth_num.Name = "sixth_num";
            this.sixth_num.Size = new System.Drawing.Size(11, 12);
            this.sixth_num.TabIndex = 5;
            this.sixth_num.Text = "-";
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(121, 162);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(75, 23);
            this.Roll.TabIndex = 6;
            this.Roll.Text = "번호 생성";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "지난 회차의 로또 번호를 입력하십시오";
            // 
            // prev_num1
            // 
            this.prev_num1.Location = new System.Drawing.Point(30, 38);
            this.prev_num1.Name = "prev_num1";
            this.prev_num1.Size = new System.Drawing.Size(37, 21);
            this.prev_num1.TabIndex = 8;
            // 
            // prev_num2
            // 
            this.prev_num2.Location = new System.Drawing.Point(73, 38);
            this.prev_num2.Name = "prev_num2";
            this.prev_num2.Size = new System.Drawing.Size(37, 21);
            this.prev_num2.TabIndex = 8;
            // 
            // prev_num3
            // 
            this.prev_num3.Location = new System.Drawing.Point(116, 38);
            this.prev_num3.Name = "prev_num3";
            this.prev_num3.Size = new System.Drawing.Size(37, 21);
            this.prev_num3.TabIndex = 8;
            // 
            // prev_num4
            // 
            this.prev_num4.Location = new System.Drawing.Point(159, 38);
            this.prev_num4.Name = "prev_num4";
            this.prev_num4.Size = new System.Drawing.Size(37, 21);
            this.prev_num4.TabIndex = 8;
            // 
            // prev_num5
            // 
            this.prev_num5.Location = new System.Drawing.Point(202, 38);
            this.prev_num5.Name = "prev_num5";
            this.prev_num5.Size = new System.Drawing.Size(37, 21);
            this.prev_num5.TabIndex = 8;
            // 
            // prev_num6
            // 
            this.prev_num6.Location = new System.Drawing.Point(245, 38);
            this.prev_num6.Name = "prev_num6";
            this.prev_num6.Size = new System.Drawing.Size(37, 21);
            this.prev_num6.TabIndex = 8;
            // 
            // Prev_button
            // 
            this.Prev_button.Location = new System.Drawing.Point(104, 78);
            this.Prev_button.Name = "Prev_button";
            this.Prev_button.Size = new System.Drawing.Size(128, 37);
            this.Prev_button.TabIndex = 9;
            this.Prev_button.Text = "지난 회차 번호 생성";
            this.Prev_button.UseVisualStyleBackColor = true;
            this.Prev_button.Click += new System.EventHandler(this.Prev_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 237);
            this.Controls.Add(this.Prev_button);
            this.Controls.Add(this.prev_num6);
            this.Controls.Add(this.prev_num5);
            this.Controls.Add(this.prev_num4);
            this.Controls.Add(this.prev_num3);
            this.Controls.Add(this.prev_num2);
            this.Controls.Add(this.prev_num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.sixth_num);
            this.Controls.Add(this.fifth_num);
            this.Controls.Add(this.forth_num);
            this.Controls.Add(this.third_num);
            this.Controls.Add(this.second_num);
            this.Controls.Add(this.first_num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label first_num;
        private System.Windows.Forms.Label second_num;
        private System.Windows.Forms.Label third_num;
        private System.Windows.Forms.Label forth_num;
        private System.Windows.Forms.Label fifth_num;
        private System.Windows.Forms.Label sixth_num;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prev_num1;
        private System.Windows.Forms.TextBox prev_num2;
        private System.Windows.Forms.TextBox prev_num3;
        private System.Windows.Forms.TextBox prev_num4;
        private System.Windows.Forms.TextBox prev_num5;
        private System.Windows.Forms.TextBox prev_num6;
        private System.Windows.Forms.Button Prev_button;
    }
}

