
namespace addrWin0302.UI
{
    partial class AddForm
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.addName = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.addTel = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addAddr = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.addEmail = new CxFlatUI.CxFlatTextBox();
            this.addOk = new Sunny.UI.UISymbolButton();
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("HY동녘M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(135, 186);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel1.Symbol = 62142;
            this.uiSymbolLabel1.SymbolSize = 26;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "이  름";
            // 
            // addName
            // 
            this.addName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addName.Hint = "";
            this.addName.Location = new System.Drawing.Point(268, 186);
            this.addName.MaxLength = 32767;
            this.addName.Multiline = false;
            this.addName.Name = "addName";
            this.addName.PasswordChar = '\0';
            this.addName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addName.SelectedText = "";
            this.addName.SelectionLength = 0;
            this.addName.SelectionStart = 0;
            this.addName.Size = new System.Drawing.Size(282, 38);
            this.addName.TabIndex = 2;
            this.addName.TabStop = false;
            this.addName.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(135, 240);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel2.Symbol = 61589;
            this.uiSymbolLabel2.SymbolSize = 26;
            this.uiSymbolLabel2.TabIndex = 0;
            this.uiSymbolLabel2.Text = "전  화";
            // 
            // addTel
            // 
            this.addTel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addTel.Hint = "";
            this.addTel.Location = new System.Drawing.Point(268, 240);
            this.addTel.MaxLength = 32767;
            this.addTel.Multiline = false;
            this.addTel.Name = "addTel";
            this.addTel.PasswordChar = '\0';
            this.addTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addTel.SelectedText = "";
            this.addTel.SelectionLength = 0;
            this.addTel.SelectionStart = 0;
            this.addTel.Size = new System.Drawing.Size(282, 38);
            this.addTel.TabIndex = 2;
            this.addTel.TabStop = false;
            this.addTel.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(135, 294);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel3.Symbol = 61461;
            this.uiSymbolLabel3.SymbolSize = 30;
            this.uiSymbolLabel3.TabIndex = 0;
            this.uiSymbolLabel3.Text = "주  소";
            // 
            // addAddr
            // 
            this.addAddr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addAddr.Hint = "";
            this.addAddr.Location = new System.Drawing.Point(268, 294);
            this.addAddr.MaxLength = 32767;
            this.addAddr.Multiline = false;
            this.addAddr.Name = "addAddr";
            this.addAddr.PasswordChar = '\0';
            this.addAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addAddr.SelectedText = "";
            this.addAddr.SelectionLength = 0;
            this.addAddr.SelectionStart = 0;
            this.addAddr.Size = new System.Drawing.Size(282, 38);
            this.addAddr.TabIndex = 2;
            this.addAddr.TabStop = false;
            this.addAddr.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("HY동녘M", 14.25F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(135, 348);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(107, 35);
            this.uiSymbolLabel4.Symbol = 61664;
            this.uiSymbolLabel4.SymbolSize = 26;
            this.uiSymbolLabel4.TabIndex = 0;
            this.uiSymbolLabel4.Text = "메  일";
            // 
            // addEmail
            // 
            this.addEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addEmail.Hint = "";
            this.addEmail.Location = new System.Drawing.Point(268, 348);
            this.addEmail.MaxLength = 32767;
            this.addEmail.Multiline = false;
            this.addEmail.Name = "addEmail";
            this.addEmail.PasswordChar = '\0';
            this.addEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addEmail.SelectedText = "";
            this.addEmail.SelectionLength = 0;
            this.addEmail.SelectionStart = 0;
            this.addEmail.Size = new System.Drawing.Size(282, 38);
            this.addEmail.TabIndex = 2;
            this.addEmail.TabStop = false;
            this.addEmail.UseSystemPasswordChar = false;
            // 
            // addOk
            // 
            this.addOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOk.FillColor = System.Drawing.Color.Turquoise;
            this.addOk.FillHoverColor = System.Drawing.Color.Aquamarine;
            this.addOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOk.Location = new System.Drawing.Point(135, 425);
            this.addOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOk.Name = "addOk";
            this.addOk.RectColor = System.Drawing.Color.Turquoise;
            this.addOk.Size = new System.Drawing.Size(198, 35);
            this.addOk.Style = Sunny.UI.UIStyle.Custom;
            this.addOk.TabIndex = 3;
            this.addOk.Text = "확인";
            this.addOk.Click += new System.EventHandler(this.addOk_Click);
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.FillColor = System.Drawing.Color.Crimson;
            this.addCancel.FillHoverColor = System.Drawing.Color.Pink;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(352, 425);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.RectColor = System.Drawing.Color.Crimson;
            this.addCancel.Size = new System.Drawing.Size(198, 35);
            this.addCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCancel.TabIndex = 3;
            this.addCancel.Text = "취소";
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // AddFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addOk);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.addAddr);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.addTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Font = new System.Drawing.Font("HY동녘M", 9F);
            this.Name = "AddFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 추가";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatTextBox addName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private CxFlatUI.CxFlatTextBox addTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private CxFlatUI.CxFlatTextBox addAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private CxFlatUI.CxFlatTextBox addEmail;
        private Sunny.UI.UISymbolButton addOk;
        private Sunny.UI.UISymbolButton addCancel;
    }
}