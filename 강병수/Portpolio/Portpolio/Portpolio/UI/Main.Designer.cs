
namespace Portpolio.UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Add_Score = new System.Windows.Forms.Button();
            this.Modify_Score = new System.Windows.Forms.Button();
            this.Delete_Score = new System.Windows.Forms.Button();
            this.Exit_Program = new System.Windows.Forms.Button();
            this.View_Score = new System.Windows.Forms.Button();
            this.LinktoGitHub = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Score
            // 
            this.Add_Score.Location = new System.Drawing.Point(281, 12);
            this.Add_Score.Name = "Add_Score";
            this.Add_Score.Size = new System.Drawing.Size(113, 49);
            this.Add_Score.TabIndex = 0;
            this.Add_Score.Text = "학생 점수 추가";
            this.Add_Score.UseVisualStyleBackColor = true;
            this.Add_Score.Click += new System.EventHandler(this.Add_Score_Click);
            // 
            // Modify_Score
            // 
            this.Modify_Score.Location = new System.Drawing.Point(400, 67);
            this.Modify_Score.Name = "Modify_Score";
            this.Modify_Score.Size = new System.Drawing.Size(113, 49);
            this.Modify_Score.TabIndex = 0;
            this.Modify_Score.Text = "학생 점수 수정";
            this.Modify_Score.UseVisualStyleBackColor = true;
            this.Modify_Score.Click += new System.EventHandler(this.Modify_Score_Click);
            // 
            // Delete_Score
            // 
            this.Delete_Score.Location = new System.Drawing.Point(281, 67);
            this.Delete_Score.Name = "Delete_Score";
            this.Delete_Score.Size = new System.Drawing.Size(113, 49);
            this.Delete_Score.TabIndex = 0;
            this.Delete_Score.Text = "학생 점수 삭제";
            this.Delete_Score.UseVisualStyleBackColor = true;
            this.Delete_Score.Click += new System.EventHandler(this.Delete_Score_Click);
            // 
            // Exit_Program
            // 
            this.Exit_Program.Location = new System.Drawing.Point(342, 122);
            this.Exit_Program.Name = "Exit_Program";
            this.Exit_Program.Size = new System.Drawing.Size(113, 49);
            this.Exit_Program.TabIndex = 0;
            this.Exit_Program.Text = "프로그램 종료";
            this.Exit_Program.UseVisualStyleBackColor = true;
            this.Exit_Program.Click += new System.EventHandler(this.Exit_Program_Click);
            // 
            // View_Score
            // 
            this.View_Score.Location = new System.Drawing.Point(400, 12);
            this.View_Score.Name = "View_Score";
            this.View_Score.Size = new System.Drawing.Size(113, 49);
            this.View_Score.TabIndex = 0;
            this.View_Score.Text = "학생 점수 조회";
            this.View_Score.UseVisualStyleBackColor = true;
            this.View_Score.Click += new System.EventHandler(this.View_Score_Click);
            // 
            // LinktoGitHub
            // 
            this.LinktoGitHub.AutoSize = true;
            this.LinktoGitHub.Location = new System.Drawing.Point(284, 255);
            this.LinktoGitHub.Name = "LinktoGitHub";
            this.LinktoGitHub.Size = new System.Drawing.Size(41, 12);
            this.LinktoGitHub.TabIndex = 1;
            this.LinktoGitHub.TabStop = true;
            this.LinktoGitHub.Text = "만든이";
            this.LinktoGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinktoGitHub_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 276);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LinktoGitHub);
            this.Controls.Add(this.Exit_Program);
            this.Controls.Add(this.Delete_Score);
            this.Controls.Add(this.Modify_Score);
            this.Controls.Add(this.View_Score);
            this.Controls.Add(this.Add_Score);
            this.Name = "Main";
            this.Text = "학생 점수 관리 프로그램";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Score;
        private System.Windows.Forms.Button Modify_Score;
        private System.Windows.Forms.Button Delete_Score;
        private System.Windows.Forms.Button Exit_Program;
        private System.Windows.Forms.Button View_Score;
        private System.Windows.Forms.LinkLabel LinktoGitHub;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}