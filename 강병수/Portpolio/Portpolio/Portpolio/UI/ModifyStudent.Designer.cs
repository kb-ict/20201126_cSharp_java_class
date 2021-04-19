
namespace Portpolio.UI
{
    partial class ModifyStudent
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
            this.ModifyCancel = new System.Windows.Forms.Button();
            this.ModifyOK = new System.Windows.Forms.Button();
            this.StudentNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyCancel
            // 
            this.ModifyCancel.Location = new System.Drawing.Point(267, 148);
            this.ModifyCancel.Name = "ModifyCancel";
            this.ModifyCancel.Size = new System.Drawing.Size(75, 23);
            this.ModifyCancel.TabIndex = 5;
            this.ModifyCancel.Text = "취소";
            this.ModifyCancel.UseVisualStyleBackColor = true;
            this.ModifyCancel.Click += new System.EventHandler(this.ModifyCancel_Click);
            // 
            // ModifyOK
            // 
            this.ModifyOK.Location = new System.Drawing.Point(89, 148);
            this.ModifyOK.Name = "ModifyOK";
            this.ModifyOK.Size = new System.Drawing.Size(75, 23);
            this.ModifyOK.TabIndex = 6;
            this.ModifyOK.Text = "확인";
            this.ModifyOK.UseVisualStyleBackColor = true;
            this.ModifyOK.Click += new System.EventHandler(this.ModifyOK_Click);
            // 
            // StudentNumber
            // 
            this.StudentNumber.Location = new System.Drawing.Point(164, 94);
            this.StudentNumber.Name = "StudentNumber";
            this.StudentNumber.Size = new System.Drawing.Size(100, 21);
            this.StudentNumber.TabIndex = 4;
            this.StudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "수정할 학생의 번호를 입력하십시오";
            // 
            // ModifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 217);
            this.Controls.Add(this.ModifyCancel);
            this.Controls.Add(this.ModifyOK);
            this.Controls.Add(this.StudentNumber);
            this.Controls.Add(this.label1);
            this.Name = "ModifyStudent";
            this.Text = "학생 정보 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyCancel;
        private System.Windows.Forms.Button ModifyOK;
        private System.Windows.Forms.TextBox StudentNumber;
        private System.Windows.Forms.Label label1;
    }
}