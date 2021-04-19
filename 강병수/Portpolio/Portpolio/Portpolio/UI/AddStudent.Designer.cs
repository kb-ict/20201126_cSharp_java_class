
namespace Portpolio.UI
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Stu_Num = new System.Windows.Forms.TextBox();
            this.Stu_Name = new System.Windows.Forms.TextBox();
            this.Stu_Kor = new System.Windows.Forms.TextBox();
            this.Stu_Math = new System.Windows.Forms.TextBox();
            this.Stu_Eng = new System.Windows.Forms.TextBox();
            this.Stu_Histo = new System.Windows.Forms.TextBox();
            this.AddScore = new System.Windows.Forms.Button();
            this.ExitScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "학생 이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "국어 점수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "수학 점수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "영어 점수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "한국사 점수";
            // 
            // Stu_Num
            // 
            this.Stu_Num.Location = new System.Drawing.Point(166, 52);
            this.Stu_Num.Name = "Stu_Num";
            this.Stu_Num.Size = new System.Drawing.Size(100, 21);
            this.Stu_Num.TabIndex = 1;
            // 
            // Stu_Name
            // 
            this.Stu_Name.Location = new System.Drawing.Point(166, 90);
            this.Stu_Name.Name = "Stu_Name";
            this.Stu_Name.Size = new System.Drawing.Size(100, 21);
            this.Stu_Name.TabIndex = 1;
            // 
            // Stu_Kor
            // 
            this.Stu_Kor.Location = new System.Drawing.Point(166, 132);
            this.Stu_Kor.Name = "Stu_Kor";
            this.Stu_Kor.Size = new System.Drawing.Size(100, 21);
            this.Stu_Kor.TabIndex = 1;
            // 
            // Stu_Math
            // 
            this.Stu_Math.Location = new System.Drawing.Point(166, 174);
            this.Stu_Math.Name = "Stu_Math";
            this.Stu_Math.Size = new System.Drawing.Size(100, 21);
            this.Stu_Math.TabIndex = 1;
            // 
            // Stu_Eng
            // 
            this.Stu_Eng.Location = new System.Drawing.Point(166, 211);
            this.Stu_Eng.Name = "Stu_Eng";
            this.Stu_Eng.Size = new System.Drawing.Size(100, 21);
            this.Stu_Eng.TabIndex = 1;
            // 
            // Stu_Histo
            // 
            this.Stu_Histo.Location = new System.Drawing.Point(166, 252);
            this.Stu_Histo.Name = "Stu_Histo";
            this.Stu_Histo.Size = new System.Drawing.Size(100, 21);
            this.Stu_Histo.TabIndex = 1;
            // 
            // AddScore
            // 
            this.AddScore.Location = new System.Drawing.Point(51, 318);
            this.AddScore.Name = "AddScore";
            this.AddScore.Size = new System.Drawing.Size(75, 23);
            this.AddScore.TabIndex = 2;
            this.AddScore.Text = "저장";
            this.AddScore.UseVisualStyleBackColor = true;
            this.AddScore.Click += new System.EventHandler(this.AddScore_Click);
            // 
            // ExitScore
            // 
            this.ExitScore.Location = new System.Drawing.Point(191, 318);
            this.ExitScore.Name = "ExitScore";
            this.ExitScore.Size = new System.Drawing.Size(75, 23);
            this.ExitScore.TabIndex = 2;
            this.ExitScore.Text = "취소";
            this.ExitScore.UseVisualStyleBackColor = true;
            this.ExitScore.Click += new System.EventHandler(this.ExitScore_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 367);
            this.Controls.Add(this.ExitScore);
            this.Controls.Add(this.AddScore);
            this.Controls.Add(this.Stu_Histo);
            this.Controls.Add(this.Stu_Eng);
            this.Controls.Add(this.Stu_Math);
            this.Controls.Add(this.Stu_Kor);
            this.Controls.Add(this.Stu_Name);
            this.Controls.Add(this.Stu_Num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "학생 정보 추가";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Stu_Num;
        private System.Windows.Forms.TextBox Stu_Name;
        private System.Windows.Forms.TextBox Stu_Kor;
        private System.Windows.Forms.TextBox Stu_Math;
        private System.Windows.Forms.TextBox Stu_Eng;
        private System.Windows.Forms.TextBox Stu_Histo;
        private System.Windows.Forms.Button AddScore;
        private System.Windows.Forms.Button ExitScore;
    }
}