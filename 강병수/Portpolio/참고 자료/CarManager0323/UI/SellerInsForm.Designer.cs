
namespace CarManager0323.UI
{
    partial class SellerInsForm
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
            this.SellerMail = new Sunny.UI.UITextBox();
            this.SellerAddr = new Sunny.UI.UITextBox();
            this.SellerTel = new Sunny.UI.UITextBox();
            this.SellerName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // symbolEmail
            // 
            this.symbolEmail.BackColor = System.Drawing.Color.Transparent;
            this.symbolEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolEmail.Location = new System.Drawing.Point(248, 198);
            this.symbolEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolEmail.Name = "symbolEmail";
            this.symbolEmail.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolEmail.Size = new System.Drawing.Size(121, 35);
            this.symbolEmail.Style = Sunny.UI.UIStyle.Custom;
            this.symbolEmail.Symbol = 57360;
            this.symbolEmail.TabIndex = 31;
            this.symbolEmail.Text = "메일";
            // 
            // symbolAddress
            // 
            this.symbolAddress.BackColor = System.Drawing.Color.Transparent;
            this.symbolAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.symbolAddress.Location = new System.Drawing.Point(248, 255);
            this.symbolAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.symbolAddress.Name = "symbolAddress";
            this.symbolAddress.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.symbolAddress.Size = new System.Drawing.Size(121, 35);
            this.symbolAddress.Symbol = 57473;
            this.symbolAddress.TabIndex = 32;
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
            this.symbolTel.TabIndex = 33;
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
            this.symbolName.TabIndex = 34;
            this.symbolName.Text = "이름";
            // 
            // addCancel
            // 
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.FillColor = System.Drawing.Color.Red;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.Location = new System.Drawing.Point(442, 335);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.RectColor = System.Drawing.Color.Red;
            this.addCancel.Size = new System.Drawing.Size(96, 35);
            this.addCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCancel.Symbol = 61534;
            this.addCancel.TabIndex = 29;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // addOK
            // 
            this.addOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOK.FillColor = System.Drawing.Color.Lime;
            this.addOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOK.Location = new System.Drawing.Point(287, 335);
            this.addOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOK.Name = "addOK";
            this.addOK.RectColor = System.Drawing.Color.Lime;
            this.addOK.Size = new System.Drawing.Size(94, 35);
            this.addOK.Style = Sunny.UI.UIStyle.Custom;
            this.addOK.TabIndex = 30;
            this.addOK.Click += new System.EventHandler(this.addOK_Click);
            // 
            // SellerMail
            // 
            this.SellerMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerMail.FillColor = System.Drawing.Color.White;
            this.SellerMail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SellerMail.Location = new System.Drawing.Point(403, 198);
            this.SellerMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerMail.Maximum = 2147483647D;
            this.SellerMail.Minimum = -2147483648D;
            this.SellerMail.MinimumSize = new System.Drawing.Size(1, 1);
            this.SellerMail.Name = "SellerMail";
            this.SellerMail.Padding = new System.Windows.Forms.Padding(5);
            this.SellerMail.Size = new System.Drawing.Size(150, 29);
            this.SellerMail.TabIndex = 25;
            // 
            // SellerAddr
            // 
            this.SellerAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerAddr.FillColor = System.Drawing.Color.White;
            this.SellerAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SellerAddr.Location = new System.Drawing.Point(403, 255);
            this.SellerAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerAddr.Maximum = 2147483647D;
            this.SellerAddr.Minimum = -2147483648D;
            this.SellerAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.SellerAddr.Name = "SellerAddr";
            this.SellerAddr.Padding = new System.Windows.Forms.Padding(5);
            this.SellerAddr.Size = new System.Drawing.Size(150, 29);
            this.SellerAddr.TabIndex = 26;
            // 
            // SellerTel
            // 
            this.SellerTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerTel.FillColor = System.Drawing.Color.White;
            this.SellerTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SellerTel.Location = new System.Drawing.Point(403, 139);
            this.SellerTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerTel.Maximum = 2147483647D;
            this.SellerTel.Minimum = -2147483648D;
            this.SellerTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.SellerTel.Name = "SellerTel";
            this.SellerTel.Padding = new System.Windows.Forms.Padding(5);
            this.SellerTel.Size = new System.Drawing.Size(150, 29);
            this.SellerTel.TabIndex = 27;
            // 
            // SellerName
            // 
            this.SellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerName.FillColor = System.Drawing.Color.White;
            this.SellerName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.SellerName.Location = new System.Drawing.Point(403, 75);
            this.SellerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellerName.Maximum = 2147483647D;
            this.SellerName.Minimum = -2147483648D;
            this.SellerName.MinimumSize = new System.Drawing.Size(1, 1);
            this.SellerName.Name = "SellerName";
            this.SellerName.Padding = new System.Windows.Forms.Padding(5);
            this.SellerName.Size = new System.Drawing.Size(150, 29);
            this.SellerName.TabIndex = 28;
            // 
            // SellerInsForm
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
            this.Controls.Add(this.SellerMail);
            this.Controls.Add(this.SellerAddr);
            this.Controls.Add(this.SellerTel);
            this.Controls.Add(this.SellerName);
            this.Name = "SellerInsForm";
            this.Text = "판매자 정보 추가";
            this.Load += new System.EventHandler(this.SellerInsFormcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel symbolEmail;
        private Sunny.UI.UISymbolLabel symbolAddress;
        private Sunny.UI.UISymbolLabel symbolTel;
        private Sunny.UI.UISymbolLabel symbolName;
        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton addOK;
        private Sunny.UI.UITextBox SellerMail;
        private Sunny.UI.UITextBox SellerAddr;
        private Sunny.UI.UITextBox SellerTel;
        private Sunny.UI.UITextBox SellerName;
    }
}