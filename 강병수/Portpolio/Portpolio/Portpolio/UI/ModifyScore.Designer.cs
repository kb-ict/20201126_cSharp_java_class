
namespace Portpolio.UI
{
    partial class ModifyScore
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
            this.ExitModify = new System.Windows.Forms.Button();
            this.ModifyData = new System.Windows.Forms.Button();
            this.Stu_Histo = new System.Windows.Forms.TextBox();
            this.Stu_Eng = new System.Windows.Forms.TextBox();
            this.Stu_Math = new System.Windows.Forms.TextBox();
            this.Stu_Kor = new System.Windows.Forms.TextBox();
            this.Stu_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitModify
            // 
            this.ExitModify.Location = new System.Drawing.Point(211, 305);
            this.ExitModify.Name = "ExitModify";
            this.ExitModify.Size = new System.Drawing.Size(75, 23);
            this.ExitModify.TabIndex = 15;
            this.ExitModify.Text = "취소";
            this.ExitModify.UseVisualStyleBackColor = true;
            this.ExitModify.Click += new System.EventHandler(this.ExitModify_Click);
            // 
            // ModifyData
            // 
            this.ModifyData.Location = new System.Drawing.Point(71, 305);
            this.ModifyData.Name = "ModifyData";
            this.ModifyData.Size = new System.Drawing.Size(75, 23);
            this.ModifyData.TabIndex = 16;
            this.ModifyData.Text = "저장";
            this.ModifyData.UseVisualStyleBackColor = true;
            this.ModifyData.Click += new System.EventHandler(this.ModifyData_Click);
            // 
            // Stu_Histo
            // 
            this.Stu_Histo.Location = new System.Drawing.Point(184, 162);
            this.Stu_Histo.Name = "Stu_Histo";
            this.Stu_Histo.Size = new System.Drawing.Size(100, 21);
            this.Stu_Histo.TabIndex = 9;
            // 
            // Stu_Eng
            // 
            this.Stu_Eng.Location = new System.Drawing.Point(184, 121);
            this.Stu_Eng.Name = "Stu_Eng";
            this.Stu_Eng.Size = new System.Drawing.Size(100, 21);
            this.Stu_Eng.TabIndex = 10;
            // 
            // Stu_Math
            // 
            this.Stu_Math.Location = new System.Drawing.Point(184, 84);
            this.Stu_Math.Name = "Stu_Math";
            this.Stu_Math.Size = new System.Drawing.Size(100, 21);
            this.Stu_Math.TabIndex = 11;
            // 
            // Stu_Kor
            // 
            this.Stu_Kor.Location = new System.Drawing.Point(184, 42);
            this.Stu_Kor.Name = "Stu_Kor";
            this.Stu_Kor.Size = new System.Drawing.Size(100, 21);
            this.Stu_Kor.TabIndex = 12;
            // 
            // Stu_Name
            // 
            this.Stu_Name.Location = new System.Drawing.Point(184, 239);
            this.Stu_Name.Name = "Stu_Name";
            this.Stu_Name.Size = new System.Drawing.Size(100, 21);
            this.Stu_Name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "한국사 점수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "영어 점수";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "수학 점수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "국어 점수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "확인을 위하여 수정할 \r\n해당 학생의 이름을 \r\n입력하십시오";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 367);
            this.Controls.Add(this.ExitModify);
            this.Controls.Add(this.ModifyData);
            this.Controls.Add(this.Stu_Histo);
            this.Controls.Add(this.Stu_Eng);
            this.Controls.Add(this.Stu_Math);
            this.Controls.Add(this.Stu_Kor);
            this.Controls.Add(this.Stu_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ModifyScore";
            this.Text = "학생 정보 수정";
            this.Load += new System.EventHandler(this.ModifyScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitModify;
        private System.Windows.Forms.Button ModifyData;
        private System.Windows.Forms.TextBox Stu_Histo;
        private System.Windows.Forms.TextBox Stu_Eng;
        private System.Windows.Forms.TextBox Stu_Math;
        private System.Windows.Forms.TextBox Stu_Kor;
        private System.Windows.Forms.TextBox Stu_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}