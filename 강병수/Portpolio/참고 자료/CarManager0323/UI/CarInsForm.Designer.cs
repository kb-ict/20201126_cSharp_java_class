
namespace CarManager0323.UI
{
    partial class CarInsForm
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
            this.CarYear = new Sunny.UI.UITextBox();
            this.CarColor = new Sunny.UI.UITextBox();
            this.CarPrice = new Sunny.UI.UITextBox();
            this.CarModel = new Sunny.UI.UITextBox();
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
            this.symbolEmail.TabIndex = 11;
            this.symbolEmail.Text = "연식";
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
            this.symbolAddress.TabIndex = 12;
            this.symbolAddress.Text = "색상";
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
            this.symbolTel.TabIndex = 13;
            this.symbolTel.Text = "가격";
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
            this.symbolName.TabIndex = 14;
            this.symbolName.Text = "모델";
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
            this.addCancel.TabIndex = 9;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
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
            this.addOK.TabIndex = 10;
            this.addOK.Click += new System.EventHandler(this.addOK_Click);
            // 
            // CarYear
            // 
            this.CarYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CarYear.FillColor = System.Drawing.Color.White;
            this.CarYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CarYear.Location = new System.Drawing.Point(403, 264);
            this.CarYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarYear.Maximum = 2147483647D;
            this.CarYear.Minimum = -2147483648D;
            this.CarYear.MinimumSize = new System.Drawing.Size(1, 1);
            this.CarYear.Name = "CarYear";
            this.CarYear.Padding = new System.Windows.Forms.Padding(5);
            this.CarYear.Size = new System.Drawing.Size(150, 29);
            this.CarYear.TabIndex = 5;
            // 
            // CarColor
            // 
            this.CarColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CarColor.FillColor = System.Drawing.Color.White;
            this.CarColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CarColor.Location = new System.Drawing.Point(403, 202);
            this.CarColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarColor.Maximum = 2147483647D;
            this.CarColor.Minimum = -2147483648D;
            this.CarColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.CarColor.Name = "CarColor";
            this.CarColor.Padding = new System.Windows.Forms.Padding(5);
            this.CarColor.Size = new System.Drawing.Size(150, 29);
            this.CarColor.TabIndex = 6;
            // 
            // CarPrice
            // 
            this.CarPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CarPrice.FillColor = System.Drawing.Color.White;
            this.CarPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CarPrice.Location = new System.Drawing.Point(403, 139);
            this.CarPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarPrice.Maximum = 2147483647D;
            this.CarPrice.Minimum = -2147483648D;
            this.CarPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.CarPrice.Name = "CarPrice";
            this.CarPrice.Padding = new System.Windows.Forms.Padding(5);
            this.CarPrice.Size = new System.Drawing.Size(150, 29);
            this.CarPrice.TabIndex = 7;
            // 
            // CarModel
            // 
            this.CarModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CarModel.FillColor = System.Drawing.Color.White;
            this.CarModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CarModel.Location = new System.Drawing.Point(403, 75);
            this.CarModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarModel.Maximum = 2147483647D;
            this.CarModel.Minimum = -2147483648D;
            this.CarModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.CarModel.Name = "CarModel";
            this.CarModel.Padding = new System.Windows.Forms.Padding(5);
            this.CarModel.Size = new System.Drawing.Size(150, 29);
            this.CarModel.TabIndex = 8;
            // 
            // CarInsForm
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
            this.Controls.Add(this.CarYear);
            this.Controls.Add(this.CarColor);
            this.Controls.Add(this.CarPrice);
            this.Controls.Add(this.CarModel);
            this.Name = "CarInsForm";
            this.Text = "차량 정보 추가";
            this.Load += new System.EventHandler(this.CarInsFormcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel symbolEmail;
        private Sunny.UI.UISymbolLabel symbolAddress;
        private Sunny.UI.UISymbolLabel symbolTel;
        private Sunny.UI.UISymbolLabel symbolName;
        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton addOK;
        private Sunny.UI.UITextBox CarYear;
        private Sunny.UI.UITextBox CarColor;
        private Sunny.UI.UITextBox CarPrice;
        private Sunny.UI.UITextBox CarModel;
    }
}