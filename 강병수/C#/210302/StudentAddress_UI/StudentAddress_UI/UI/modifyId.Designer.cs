
namespace StudentAddress_UI.UI
{
    partial class modifyId
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
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.modifyIDTextBox = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(31, 137);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.TabIndex = 0;
            this.uiSymbolButton1.Text = "확인";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Red;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(186, 137);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61453;
            this.uiSymbolButton2.TabIndex = 0;
            this.uiSymbolButton2.Text = "취소";
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(90, 72);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(138, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "ID를 입력하시오";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modifyIDTextBox
            // 
            this.modifyIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modifyIDTextBox.FillColor = System.Drawing.Color.White;
            this.modifyIDTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.modifyIDTextBox.Location = new System.Drawing.Point(78, 100);
            this.modifyIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modifyIDTextBox.Maximum = 2147483647D;
            this.modifyIDTextBox.Minimum = -2147483648D;
            this.modifyIDTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.modifyIDTextBox.Name = "modifyIDTextBox";
            this.modifyIDTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.modifyIDTextBox.Size = new System.Drawing.Size(166, 29);
            this.modifyIDTextBox.TabIndex = 2;
            // 
            // modifyId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 193);
            this.Controls.Add(this.modifyIDTextBox);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Name = "modifyId";
            this.Text = "수정할 정보의 ID 입력";
            this.Load += new System.EventHandler(this.modifyId_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox modifyIDTextBox;
    }
}