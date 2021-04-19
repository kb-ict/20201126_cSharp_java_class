
namespace Portpolio.UI
{
    partial class DeleteStudent
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
            this.StudentNumber = new System.Windows.Forms.TextBox();
            this.deleteOK = new System.Windows.Forms.Button();
            this.DeleteCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "삭제할 학생의 번호를 입력하십시오";
            // 
            // StudentNumber
            // 
            this.StudentNumber.Location = new System.Drawing.Point(155, 88);
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(100, 21);
            this.StudentNumber.TabIndex = 1;
            this.StudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteOK
            // 
            this.deleteOK.Location = new System.Drawing.Point(80, 142);
            this.deleteOK.Name = "deleteOK";
            this.deleteOK.Size = new System.Drawing.Size(75, 23);
            this.deleteOK.TabIndex = 2;
            this.deleteOK.Text = "확인";
            this.deleteOK.UseVisualStyleBackColor = true;
            this.deleteOK.Click += new System.EventHandler(this.deleteOK_Click);
            // 
            // DeleteCancel
            // 
            this.DeleteCancel.Location = new System.Drawing.Point(258, 142);
            this.DeleteCancel.Name = "DeleteCancel";
            this.DeleteCancel.Size = new System.Drawing.Size(75, 23);
            this.DeleteCancel.TabIndex = 2;
            this.DeleteCancel.Text = "취소";
            this.DeleteCancel.UseVisualStyleBackColor = true;
            this.DeleteCancel.Click += new System.EventHandler(this.DeleteCancel_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 217);
            this.Controls.Add(this.DeleteCancel);
            this.Controls.Add(this.deleteOK);
            this.Controls.Add(this.StudentNumber);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStudent";
            this.Text = "학생 정보 삭제";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentNumber;
        private System.Windows.Forms.Button deleteOK;
        private System.Windows.Forms.Button DeleteCancel;
    }
}