
namespace StudentAddress_UI.UI
{
    partial class addForm
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
            this.addName = new Sunny.UI.UITextBox();
            this.addTel = new Sunny.UI.UITextBox();
            this.addAddress = new Sunny.UI.UITextBox();
            this.addEmail = new Sunny.UI.UITextBox();
            this.addOK = new Sunny.UI.UISymbolButton();
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.symbolName = new Sunny.UI.UISymbolLabel();
            this.symbolTel = new Sunny.UI.UISymbolLabel();
            this.symbolAddress = new Sunny.UI.UISymbolLabel();
            this.symbolEmail = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // addName
            // 
            this.addName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addName.FillColor = System.Drawing.Color.White;
            this.addName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addName.Location = new System.Drawing.Point(190, 82);
            this.addName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addName.Maximum = 2147483647D;
            this.addName.Minimum = -2147483648D;
            this.addName.MinimumSize = new System.Drawing.Size(1, 1);
            this.addName.Name = "addName";
            this.addName.Padding = new System.Windows.Forms.Padding(5);
            this.addName.Size = new System.Drawing.Size(150, 29);
            this.addName.TabIndex = 1;
            // 
            // addTel
            // 
            this.addTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTel.FillColor = System.Drawing.Color.White;
            this.addTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addTel.Location = new System.Drawing.Point(190, 146);
            this.addTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTel.Maximum = 2147483647D;
            this.addTel.Minimum = -2147483648D;
            this.addTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addTel.Name = "addTel";
            this.addTel.Padding = new System.Windows.Forms.Padding(5);
            this.addTel.Size = new System.Drawing.Size(150, 29);
            this.addTel.TabIndex = 1;
            // 
            // addAddress
            // 
            this.addAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addAddress.FillColor = System.Drawing.Color.White;
            this.addAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addAddress.Location = new System.Drawing.Point(190, 209);
            this.addAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAddress.Maximum = 2147483647D;
            this.addAddress.Minimum = -2147483648D;
            this.addAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.addAddress.Name = "addAddress";
            this.addAddress.Padding = new System.Windows.Forms.Padding(5);
            this.addAddress.Size = new System.Drawing.Size(150, 29);
            this.addAddress.TabIndex = 1;
            // 
            // addEmail
            // 
            this.addEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmail.FillColor = System.Drawing.Color.White;
            this.addEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addEmail.Location = new System.Drawing.Point(190, 271);
            this.addEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmail.Maximum = 2147483647D;
            this.addEmail.Minimum = -2147483648D;
            this.addEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.addEmail.Name = "addEmail";
            this.addEmail.Padding = new System.Windows.Forms.Padding(5);
            this.addEmail.Size = new System.Drawing.Size(150, 29);
            this.addEmail.TabIndex = 1;
            // 
            // addOK
            // 
            this.addOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOK.FillColor = System.Drawing.Color.Lime;
            this.addOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOK.Location = new System.Drawing.Point(62, 347);
            this.addOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOK.Name = "addOK";
            this.addOK.RectColor = System.Drawing.Color.Lime;
            this.addOK.Size = new System.Drawing.Size(94, 35);
            this.addOK.Style = Sunny.UI.UIStyle.Custom;
            this.addOK.TabIndex = 3;
            this.addOK.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.FillColor = System.Drawing.Color.Red;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(217, 347);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.RectColor = System.Drawing.Color.Red;
            this.addCancel.Size = new System.Drawing.Size(96, 35);
            this.addCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCancel.Symbol = 61534;
            this.addCancel.TabIndex = 3;
            this.addCancel.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // symbolName
            // 
            this.symbolName.BackColor = System.Drawing.Color.Transparent;
            this.symbolName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolName.Location = new System.Drawing.Point(35, 82);
            this.symbolName.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolName.Name = "symbolName";
            this.symbolName.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolName.Size = new System.Drawing.Size(121, 35);
            this.symbolName.Symbol = 57482;
            this.symbolName.TabIndex = 4;
            this.symbolName.Text = "이름";
            this.symbolName.Click += new System.EventHandler(this.uiSymbolLabel1_Click);
            // 
            // symbolTel
            // 
            this.symbolTel.BackColor = System.Drawing.Color.Transparent;
            this.symbolTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolTel.Location = new System.Drawing.Point(35, 140);
            this.symbolTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolTel.Name = "symbolTel";
            this.symbolTel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolTel.Size = new System.Drawing.Size(121, 35);
            this.symbolTel.Symbol = 57488;
            this.symbolTel.TabIndex = 4;
            this.symbolTel.Text = "전화번호";
            this.symbolTel.Click += new System.EventHandler(this.uiSymbolLabel1_Click);
            // 
            // symbolAddress
            // 
            this.symbolAddress.BackColor = System.Drawing.Color.Transparent;
            this.symbolAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolAddress.Location = new System.Drawing.Point(36, 203);
            this.symbolAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolAddress.Name = "symbolAddress";
            this.symbolAddress.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolAddress.Size = new System.Drawing.Size(121, 35);
            this.symbolAddress.Symbol = 57473;
            this.symbolAddress.TabIndex = 4;
            this.symbolAddress.Text = "주소";
            this.symbolAddress.Click += new System.EventHandler(this.uiSymbolLabel1_Click);
            // 
            // symbolEmail
            // 
            this.symbolEmail.BackColor = System.Drawing.Color.Transparent;
            this.symbolEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolEmail.Location = new System.Drawing.Point(36, 265);
            this.symbolEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolEmail.Name = "symbolEmail";
            this.symbolEmail.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolEmail.Size = new System.Drawing.Size(121, 35);
            this.symbolEmail.Style = Sunny.UI.UIStyle.Custom;
            this.symbolEmail.Symbol = 57360;
            this.symbolEmail.TabIndex = 4;
            this.symbolEmail.Text = "이메일";
            this.symbolEmail.Click += new System.EventHandler(this.uiSymbolLabel1_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 425);
            this.Controls.Add(this.symbolEmail);
            this.Controls.Add(this.symbolAddress);
            this.Controls.Add(this.symbolTel);
            this.Controls.Add(this.symbolName);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addOK);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.addTel);
            this.Controls.Add(this.addName);
            this.Name = "addForm";
            this.Text = "주소록 데이터 추가";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox addName;
        private Sunny.UI.UITextBox addTel;
        private Sunny.UI.UITextBox addAddress;
        private Sunny.UI.UITextBox addEmail;
        private Sunny.UI.UISymbolButton addOK;
        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolLabel symbolName;
        private Sunny.UI.UISymbolLabel symbolTel;
        private Sunny.UI.UISymbolLabel symbolAddress;
        private Sunny.UI.UISymbolLabel symbolEmail;
    }
}