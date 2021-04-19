
namespace CarManager0323.UI
{
    partial class CustomerInsForm
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
            this.symbolEmail = new Sunny.UI.UISymbolLabel();
            this.symbolAddress = new Sunny.UI.UISymbolLabel();
            this.symbolTel = new Sunny.UI.UISymbolLabel();
            this.symbolName = new Sunny.UI.UISymbolLabel();
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.addOK = new Sunny.UI.UISymbolButton();
            this.CustMail = new Sunny.UI.UITextBox();
            this.CustAddr = new Sunny.UI.UITextBox();
            this.CustTel = new Sunny.UI.UITextBox();
            this.CustName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // symbolEmail
            // 
            this.symbolEmail.BackColor = System.Drawing.Color.Transparent;
            this.symbolEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolEmail.Location = new System.Drawing.Point(249, 258);
            this.symbolEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolEmail.Name = "symbolEmail";
            this.symbolEmail.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolEmail.Size = new System.Drawing.Size(121, 35);
            this.symbolEmail.Style = Sunny.UI.UIStyle.Custom;
            this.symbolEmail.Symbol = 57360;
            this.symbolEmail.TabIndex = 21;
            this.symbolEmail.Text = "메일";
            // 
            // symbolAddress
            // 
            this.symbolAddress.BackColor = System.Drawing.Color.Transparent;
            this.symbolAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolAddress.Location = new System.Drawing.Point(249, 196);
            this.symbolAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolAddress.Name = "symbolAddress";
            this.symbolAddress.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolAddress.Size = new System.Drawing.Size(121, 35);
            this.symbolAddress.Symbol = 57473;
            this.symbolAddress.TabIndex = 22;
            this.symbolAddress.Text = "주소";
            // 
            // symbolTel
            // 
            this.symbolTel.BackColor = System.Drawing.Color.Transparent;
            this.symbolTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolTel.Location = new System.Drawing.Point(248, 133);
            this.symbolTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolTel.Name = "symbolTel";
            this.symbolTel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolTel.Size = new System.Drawing.Size(121, 35);
            this.symbolTel.Symbol = 57488;
            this.symbolTel.TabIndex = 23;
            this.symbolTel.Text = "전화";
            // 
            // symbolName
            // 
            this.symbolName.BackColor = System.Drawing.Color.Transparent;
            this.symbolName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolName.Location = new System.Drawing.Point(248, 75);
            this.symbolName.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolName.Name = "symbolName";
            this.symbolName.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolName.Size = new System.Drawing.Size(121, 35);
            this.symbolName.Symbol = 57482;
            this.symbolName.TabIndex = 24;
            this.symbolName.Text = "이름";
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.FillColor = System.Drawing.Color.Red;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(430, 340);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.RectColor = System.Drawing.Color.Red;
            this.addCancel.Size = new System.Drawing.Size(96, 35);
            this.addCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCancel.Symbol = 61534;
            this.addCancel.TabIndex = 19;
            // 
            // addOK
            // 
            this.addOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOK.FillColor = System.Drawing.Color.Lime;
            this.addOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOK.Location = new System.Drawing.Point(275, 340);
            this.addOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOK.Name = "addOK";
            this.addOK.RectColor = System.Drawing.Color.Lime;
            this.addOK.Size = new System.Drawing.Size(94, 35);
            this.addOK.Style = Sunny.UI.UIStyle.Custom;
            this.addOK.TabIndex = 20;
            // 
            // CustMail
            // 
            this.CustMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustMail.FillColor = System.Drawing.Color.White;
            this.CustMail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CustMail.Location = new System.Drawing.Point(403, 264);
            this.CustMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustMail.Maximum = 2147483647D;
            this.CustMail.Minimum = -2147483648D;
            this.CustMail.MinimumSize = new System.Drawing.Size(1, 1);
            this.CustMail.Name = "CustMail";
            this.CustMail.Padding = new System.Windows.Forms.Padding(5);
            this.CustMail.Size = new System.Drawing.Size(150, 29);
            this.CustMail.TabIndex = 15;
            // 
            // CustAddr
            // 
            this.CustAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustAddr.FillColor = System.Drawing.Color.White;
            this.CustAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CustAddr.Location = new System.Drawing.Point(403, 202);
            this.CustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustAddr.Maximum = 2147483647D;
            this.CustAddr.Minimum = -2147483648D;
            this.CustAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.CustAddr.Name = "CustAddr";
            this.CustAddr.Padding = new System.Windows.Forms.Padding(5);
            this.CustAddr.Size = new System.Drawing.Size(150, 29);
            this.CustAddr.TabIndex = 16;
            // 
            // CustTel
            // 
            this.CustTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustTel.FillColor = System.Drawing.Color.White;
            this.CustTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CustTel.Location = new System.Drawing.Point(403, 139);
            this.CustTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustTel.Maximum = 2147483647D;
            this.CustTel.Minimum = -2147483648D;
            this.CustTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.CustTel.Name = "CustTel";
            this.CustTel.Padding = new System.Windows.Forms.Padding(5);
            this.CustTel.Size = new System.Drawing.Size(150, 29);
            this.CustTel.TabIndex = 17;
            // 
            // CustName
            // 
            this.CustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustName.FillColor = System.Drawing.Color.White;
            this.CustName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CustName.Location = new System.Drawing.Point(403, 75);
            this.CustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustName.Maximum = 2147483647D;
            this.CustName.Minimum = -2147483648D;
            this.CustName.MinimumSize = new System.Drawing.Size(1, 1);
            this.CustName.Name = "CustName";
            this.CustName.Padding = new System.Windows.Forms.Padding(5);
            this.CustName.Size = new System.Drawing.Size(150, 29);
            this.CustName.TabIndex = 18;
            // 
            // CustomerInsFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.symbolEmail);
            this.Controls.Add(this.symbolAddress);
            this.Controls.Add(this.symbolTel);
            this.Controls.Add(this.symbolName);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addOK);
            this.Controls.Add(this.CustMail);
            this.Controls.Add(this.CustAddr);
            this.Controls.Add(this.CustTel);
            this.Controls.Add(this.CustName);
            this.Name = "CustomerInsFormcs";
            this.Text = "고객 정보 추가";
            this.Load += new System.EventHandler(this.CustomerInsFormcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel symbolEmail;
        private Sunny.UI.UISymbolLabel symbolAddress;
        private Sunny.UI.UISymbolLabel symbolTel;
        private Sunny.UI.UISymbolLabel symbolName;
        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton addOK;
        private Sunny.UI.UITextBox CustMail;
        private Sunny.UI.UITextBox CustAddr;
        private Sunny.UI.UITextBox CustTel;
        private Sunny.UI.UITextBox CustName;
    }
}