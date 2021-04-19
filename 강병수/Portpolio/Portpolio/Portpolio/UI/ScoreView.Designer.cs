
namespace Portpolio.UI
{
    partial class ScoreView
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
            this.StuScore = new System.Windows.Forms.ListView();
            this.Student_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score_Korean = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score_Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score_English = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score_History = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score_Average = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.ListView_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StuScore
            // 
            this.StuScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student_Number,
            this.Student_Name,
            this.Score_Korean,
            this.Score_Math,
            this.Score_English,
            this.Score_History,
            this.Score_Average});
            this.StuScore.FullRowSelect = true;
            this.StuScore.GridLines = true;
            this.StuScore.HideSelection = false;
            this.StuScore.Location = new System.Drawing.Point(25, 21);
            this.StuScore.Name = "StuScore";
            this.StuScore.Size = new System.Drawing.Size(464, 190);
            this.StuScore.TabIndex = 0;
            this.StuScore.UseCompatibleStateImageBehavior = false;
            this.StuScore.View = System.Windows.Forms.View.Details;
            // 
            // Student_Number
            // 
            this.Student_Number.Text = "  번 호";
            // 
            // Student_Name
            // 
            this.Student_Name.Text = "이 름";
            this.Student_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Student_Name.Width = 100;
            // 
            // Score_Korean
            // 
            this.Score_Korean.Text = "국 어";
            this.Score_Korean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score_Math
            // 
            this.Score_Math.Text = "수 학";
            this.Score_Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score_English
            // 
            this.Score_English.Text = "영 어";
            this.Score_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score_History
            // 
            this.Score_History.Text = "한 국 사";
            this.Score_History.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Score_Average
            // 
            this.Score_Average.Text = "평 균";
            this.Score_Average.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "데이터 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListView_OK
            // 
            this.ListView_OK.Location = new System.Drawing.Point(277, 269);
            this.ListView_OK.Name = "ListView_OK";
            this.ListView_OK.Size = new System.Drawing.Size(115, 50);
            this.ListView_OK.TabIndex = 2;
            this.ListView_OK.Text = "확인";
            this.ListView_OK.UseVisualStyleBackColor = true;
            this.ListView_OK.Click += new System.EventHandler(this.ListView_OK_Click);
            // 
            // ScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 361);
            this.Controls.Add(this.ListView_OK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StuScore);
            this.Name = "ScoreView";
            this.Text = "학생 정보";
            this.Load += new System.EventHandler(this.ScoreView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView StuScore;
        private System.Windows.Forms.ColumnHeader Student_Number;
        private System.Windows.Forms.ColumnHeader Student_Name;
        private System.Windows.Forms.ColumnHeader Score_Korean;
        private System.Windows.Forms.ColumnHeader Score_Math;
        private System.Windows.Forms.ColumnHeader Score_English;
        private System.Windows.Forms.ColumnHeader Score_History;
        private System.Windows.Forms.ColumnHeader Score_Average;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ListView_OK;
    }
}