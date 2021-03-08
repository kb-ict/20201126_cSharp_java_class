
using Sunny.UI;

namespace _20210302_addrWin
{
    partial class DlgAddrAdd
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
            this.uiTextBoxName = new Sunny.UI.UITextBox();
            this.uiLabelName = new Sunny.UI.UILabel();
            this.uiLabelTel = new Sunny.UI.UILabel();
            this.uiTextBoxTel = new Sunny.UI.UITextBox();
            this.uiLabelAddress = new Sunny.UI.UILabel();
            this.uiTextBoxAddress = new Sunny.UI.UITextBox();
            this.uiLabelEmail = new Sunny.UI.UILabel();
            this.uiTextBoxEmail = new Sunny.UI.UITextBox();
            this.btnSubmit = new CxFlatUI.CxFlatRoundButton();
            this.btnCancel = new CxFlatUI.CxFlatRoundButton();
            this.SuspendLayout();
            // 
            // uiTextBoxName
            // 
            this.uiTextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxName.FillColor = System.Drawing.Color.White;
            this.uiTextBoxName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBoxName.Location = new System.Drawing.Point(147, 75);
            this.uiTextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxName.Maximum = 2147483647D;
            this.uiTextBoxName.Minimum = -2147483648D;
            this.uiTextBoxName.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBoxName.Name = "uiTextBoxName";
            this.uiTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiTextBoxName.Size = new System.Drawing.Size(240, 29);
            this.uiTextBoxName.Style = Sunny.UI.UIStyle.Green;
            this.uiTextBoxName.TabIndex = 0;
            this.uiTextBoxName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelName
            // 
            this.uiLabelName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelName.Location = new System.Drawing.Point(12, 75);
            this.uiLabelName.Name = "uiLabelName";
            this.uiLabelName.Size = new System.Drawing.Size(100, 29);
            this.uiLabelName.TabIndex = 1;
            this.uiLabelName.Text = "이름";
            this.uiLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabelTel
            // 
            this.uiLabelTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelTel.Location = new System.Drawing.Point(12, 114);
            this.uiLabelTel.Name = "uiLabelTel";
            this.uiLabelTel.Size = new System.Drawing.Size(100, 29);
            this.uiLabelTel.TabIndex = 3;
            this.uiLabelTel.Text = "전화";
            this.uiLabelTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBoxTel
            // 
            this.uiTextBoxTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxTel.FillColor = System.Drawing.Color.White;
            this.uiTextBoxTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBoxTel.Location = new System.Drawing.Point(147, 114);
            this.uiTextBoxTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxTel.Maximum = 2147483647D;
            this.uiTextBoxTel.Minimum = -2147483648D;
            this.uiTextBoxTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBoxTel.Name = "uiTextBoxTel";
            this.uiTextBoxTel.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiTextBoxTel.Size = new System.Drawing.Size(240, 29);
            this.uiTextBoxTel.Style = Sunny.UI.UIStyle.Green;
            this.uiTextBoxTel.TabIndex = 2;
            this.uiTextBoxTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelAddress
            // 
            this.uiLabelAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelAddress.Location = new System.Drawing.Point(12, 153);
            this.uiLabelAddress.Name = "uiLabelAddress";
            this.uiLabelAddress.Size = new System.Drawing.Size(100, 29);
            this.uiLabelAddress.TabIndex = 3;
            this.uiLabelAddress.Text = "주소";
            this.uiLabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBoxAddress
            // 
            this.uiTextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxAddress.FillColor = System.Drawing.Color.White;
            this.uiTextBoxAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBoxAddress.Location = new System.Drawing.Point(147, 153);
            this.uiTextBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxAddress.Maximum = 2147483647D;
            this.uiTextBoxAddress.Minimum = -2147483648D;
            this.uiTextBoxAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBoxAddress.Name = "uiTextBoxAddress";
            this.uiTextBoxAddress.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxAddress.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiTextBoxAddress.Size = new System.Drawing.Size(240, 29);
            this.uiTextBoxAddress.Style = Sunny.UI.UIStyle.Green;
            this.uiTextBoxAddress.TabIndex = 2;
            this.uiTextBoxAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelEmail
            // 
            this.uiLabelEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelEmail.Location = new System.Drawing.Point(12, 192);
            this.uiLabelEmail.Name = "uiLabelEmail";
            this.uiLabelEmail.Size = new System.Drawing.Size(100, 29);
            this.uiLabelEmail.TabIndex = 3;
            this.uiLabelEmail.Text = "메일";
            this.uiLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBoxEmail
            // 
            this.uiTextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxEmail.FillColor = System.Drawing.Color.White;
            this.uiTextBoxEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBoxEmail.Location = new System.Drawing.Point(147, 192);
            this.uiTextBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxEmail.Maximum = 2147483647D;
            this.uiTextBoxEmail.Minimum = -2147483648D;
            this.uiTextBoxEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBoxEmail.Name = "uiTextBoxEmail";
            this.uiTextBoxEmail.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBoxEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiTextBoxEmail.Size = new System.Drawing.Size(240, 29);
            this.uiTextBoxEmail.Style = Sunny.UI.UIStyle.Green;
            this.uiTextBoxEmail.TabIndex = 2;
            this.uiTextBoxEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ButtonType = CxFlatUI.ButtonType.Success;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(165, 239);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 49);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "제출";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonType = CxFlatUI.ButtonType.Danger;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(279, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 49);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DlgAddrAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uiLabelEmail);
            this.Controls.Add(this.uiLabelAddress);
            this.Controls.Add(this.uiTextBoxEmail);
            this.Controls.Add(this.uiLabelTel);
            this.Controls.Add(this.uiTextBoxAddress);
            this.Controls.Add(this.uiTextBoxTel);
            this.Controls.Add(this.uiLabelName);
            this.Controls.Add(this.uiTextBoxName);
            this.Name = "DlgAddrAdd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 추가";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox uiTextBoxName;
        private Sunny.UI.UILabel uiLabelName;
        private Sunny.UI.UILabel uiLabelTel;
        private Sunny.UI.UITextBox uiTextBoxTel;
        private Sunny.UI.UILabel uiLabelAddress;
        private Sunny.UI.UITextBox uiTextBoxAddress;
        private Sunny.UI.UILabel uiLabelEmail;
        private Sunny.UI.UITextBox uiTextBoxEmail;
        private CxFlatUI.CxFlatRoundButton btnSubmit;
        private CxFlatUI.CxFlatRoundButton btnCancel;


    }
}