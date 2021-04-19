
namespace StudentAddress_UI.UI
{
    partial class deleteId
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.deleteIdTextBox = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(69, 78);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(145, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "이름을 입력하시오";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteIdTextBox
            // 
            this.deleteIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deleteIdTextBox.FillColor = System.Drawing.Color.White;
            this.deleteIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deleteIdTextBox.Location = new System.Drawing.Point(64, 106);
            this.deleteIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteIdTextBox.Maximum = 2147483647D;
            this.deleteIdTextBox.Minimum = -2147483648D;
            this.deleteIdTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteIdTextBox.Name = "deleteIdTextBox";
            this.deleteIdTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.deleteIdTextBox.Size = new System.Drawing.Size(150, 29);
            this.deleteIdTextBox.TabIndex = 1;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(12, 160);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.TabIndex = 2;
            this.uiSymbolButton1.Text = "확인";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Red;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(150, 160);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61453;
            this.uiSymbolButton2.TabIndex = 2;
            this.uiSymbolButton2.Text = "취소";
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // deleteId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 207);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.deleteIdTextBox);
            this.Controls.Add(this.uiLabel1);
            this.Name = "deleteId";
            this.Text = "삭제할 정보의 이름 입력";
            this.Load += new System.EventHandler(this.deleteId_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox deleteIdTextBox;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
    }
}