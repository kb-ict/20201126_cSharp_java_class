
namespace _20210302_addrWin.ui
{
    partial class DlgAddrDel
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
            this.uiLabelName = new Sunny.UI.UILabel();
            this.uiTextBoxName = new Sunny.UI.UITextBox();
            this.btnCancel = new CxFlatUI.CxFlatRoundButton();
            this.btnSubmit = new CxFlatUI.CxFlatRoundButton();
            this.SuspendLayout();
            // 
            // uiLabelName
            // 
            this.uiLabelName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelName.Location = new System.Drawing.Point(12, 75);
            this.uiLabelName.Name = "uiLabelName";
            this.uiLabelName.Size = new System.Drawing.Size(100, 29);
            this.uiLabelName.TabIndex = 3;
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
            this.uiTextBoxName.TabIndex = 2;
            this.uiTextBoxName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonType = CxFlatUI.ButtonType.Danger;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(279, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 49);
            this.btnCancel.TabIndex = 7;
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
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "삭제";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DlgAddrDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.uiLabelName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uiTextBoxName);
            this.Name = "DlgAddrDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 삭제";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabelName;
        private Sunny.UI.UITextBox uiTextBoxName;
        private CxFlatUI.CxFlatRoundButton btnCancel;
        private CxFlatUI.CxFlatRoundButton btnSubmit;
    }
}