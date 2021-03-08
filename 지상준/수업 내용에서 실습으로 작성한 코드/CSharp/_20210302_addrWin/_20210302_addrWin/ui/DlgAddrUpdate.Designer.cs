
namespace _20210302_addrWin.ui
{
    partial class DlgAddrUpdate
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
            this.btnCancel = new CxFlatUI.CxFlatRoundButton();
            this.btnSubmit = new CxFlatUI.CxFlatRoundButton();
            this.uiLabelEmail = new Sunny.UI.UILabel();
            this.uiLabelAddress = new Sunny.UI.UILabel();
            this.uiTextBoxEmail = new Sunny.UI.UITextBox();
            this.uiLabelTel = new Sunny.UI.UILabel();
            this.uiTextBoxAddress = new Sunny.UI.UITextBox();
            this.uiTextBoxTel = new Sunny.UI.UITextBox();
            this.uiLabelName = new Sunny.UI.UILabel();
            this.uiTextBoxName = new Sunny.UI.UITextBox();
            this.comboBoxIdUpdate = new System.Windows.Forms.ComboBox();
            this.uiLabelIdUpdate = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonType = CxFlatUI.ButtonType.Danger;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(279, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 49);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ButtonType = CxFlatUI.ButtonType.Success;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(165, 239);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 49);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "제출";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // uiLabelEmail
            // 
            this.uiLabelEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelEmail.Location = new System.Drawing.Point(12, 192);
            this.uiLabelEmail.Name = "uiLabelEmail";
            this.uiLabelEmail.Size = new System.Drawing.Size(100, 29);
            this.uiLabelEmail.TabIndex = 11;
            this.uiLabelEmail.Text = "메일";
            this.uiLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabelAddress
            // 
            this.uiLabelAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelAddress.Location = new System.Drawing.Point(12, 153);
            this.uiLabelAddress.Name = "uiLabelAddress";
            this.uiLabelAddress.Size = new System.Drawing.Size(100, 29);
            this.uiLabelAddress.TabIndex = 12;
            this.uiLabelAddress.Text = "주소";
            this.uiLabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.uiTextBoxEmail.TabIndex = 8;
            this.uiTextBoxEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelTel
            // 
            this.uiLabelTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelTel.Location = new System.Drawing.Point(12, 114);
            this.uiLabelTel.Name = "uiLabelTel";
            this.uiLabelTel.Size = new System.Drawing.Size(100, 29);
            this.uiLabelTel.TabIndex = 13;
            this.uiLabelTel.Text = "전화";
            this.uiLabelTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.uiTextBoxAddress.TabIndex = 9;
            this.uiTextBoxAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiTextBoxTel.TabIndex = 10;
            this.uiTextBoxTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelName
            // 
            this.uiLabelName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelName.Location = new System.Drawing.Point(12, 75);
            this.uiLabelName.Name = "uiLabelName";
            this.uiLabelName.Size = new System.Drawing.Size(100, 29);
            this.uiLabelName.TabIndex = 7;
            this.uiLabelName.Text = "이름";
            this.uiLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.uiTextBoxName.TabIndex = 6;
            this.uiTextBoxName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxIdUpdate
            // 
            this.comboBoxIdUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxIdUpdate.FormattingEnabled = true;
            this.comboBoxIdUpdate.Location = new System.Drawing.Point(266, 34);
            this.comboBoxIdUpdate.Name = "comboBoxIdUpdate";
            this.comboBoxIdUpdate.Size = new System.Drawing.Size(121, 20);
            this.comboBoxIdUpdate.TabIndex = 16;
            // 
            // uiLabelIdUpdate
            // 
            this.uiLabelIdUpdate.BackColor = System.Drawing.Color.Wheat;
            this.uiLabelIdUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabelIdUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.uiLabelIdUpdate.Location = new System.Drawing.Point(165, 34);
            this.uiLabelIdUpdate.Name = "uiLabelIdUpdate";
            this.uiLabelIdUpdate.Size = new System.Drawing.Size(95, 20);
            this.uiLabelIdUpdate.TabIndex = 17;
            this.uiLabelIdUpdate.Text = "수정하는 ID";
            this.uiLabelIdUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DlgAddrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.uiLabelIdUpdate);
            this.Controls.Add(this.comboBoxIdUpdate);
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
            this.Name = "DlgAddrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 수정";
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton btnCancel;
        private CxFlatUI.CxFlatRoundButton btnSubmit;
        private Sunny.UI.UILabel uiLabelEmail;
        private Sunny.UI.UILabel uiLabelAddress;
        private Sunny.UI.UITextBox uiTextBoxEmail;
        private Sunny.UI.UILabel uiLabelTel;
        private Sunny.UI.UITextBox uiTextBoxAddress;
        private Sunny.UI.UITextBox uiTextBoxTel;
        private Sunny.UI.UILabel uiLabelName;
        private Sunny.UI.UITextBox uiTextBoxName;
        private System.Windows.Forms.ComboBox comboBoxIdUpdate;
        private Sunny.UI.UILabel uiLabelIdUpdate;
    }
}