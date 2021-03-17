
namespace addrWin0302.UI
{
    partial class UpdateForm
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
            this.updatebtn = new Sunny.UI.UISymbolButton();
            this.listView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.nametxt = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.teltxt = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addrtxt = new CxFlatUI.CxFlatTextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.emailtxt = new CxFlatUI.CxFlatTextBox();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.FillColor = System.Drawing.Color.Crimson;
            this.updatebtn.FillHoverColor = System.Drawing.Color.Aquamarine;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.updatebtn.Location = new System.Drawing.Point(430, 525);
            this.updatebtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.RectColor = System.Drawing.Color.Turquoise;
            this.updatebtn.Size = new System.Drawing.Size(228, 38);
            this.updatebtn.Style = Sunny.UI.UIStyle.Custom;
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "선택 수정";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.listView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listView.Font = new System.Drawing.Font("HY동녘M", 9F);
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 75);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(676, 316);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // list_count
            // 
            this.list_count.Text = "번호";
            this.list_count.Width = 40;
            // 
            // list_name
            // 
            this.list_name.Text = "이름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 80;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전화";
            this.list_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_tel.Width = 150;
            // 
            // list_addr
            // 
            this.list_addr.Text = "주소";
            this.list_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_addr.Width = 220;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.Width = 152;
            // 
            // viewExit
            // 
            this.viewExit.BackColor = System.Drawing.Color.Transparent;
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.viewExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewExit.FillPressColor = System.Drawing.Color.MediumSeaGreen;
            this.viewExit.FillSelectedColor = System.Drawing.Color.MediumSeaGreen;
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.Location = new System.Drawing.Point(566, 24);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.Radius = 0;
            this.viewExit.RectColor = System.Drawing.Color.MediumSeaGreen;
            this.viewExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewExit.RectPressColor = System.Drawing.Color.MediumSeaGreen;
            this.viewExit.RectSelectedColor = System.Drawing.Color.MediumSeaGreen;
            this.viewExit.Size = new System.Drawing.Size(133, 39);
            this.viewExit.Style = Sunny.UI.UIStyle.Custom;
            this.viewExit.Symbol = 61457;
            this.viewExit.TabIndex = 6;
            this.viewExit.Text = "닫기";
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(39, 407);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(77, 35);
            this.uiSymbolLabel1.TabIndex = 9;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nametxt.Hint = "";
            this.nametxt.Location = new System.Drawing.Point(122, 407);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Multiline = false;
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nametxt.SelectedText = "";
            this.nametxt.SelectionLength = 0;
            this.nametxt.SelectionStart = 0;
            this.nametxt.Size = new System.Drawing.Size(183, 38);
            this.nametxt.TabIndex = 10;
            this.nametxt.TabStop = false;
            this.nametxt.Text = "name";
            this.nametxt.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(362, 407);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(77, 35);
            this.uiSymbolLabel2.TabIndex = 9;
            this.uiSymbolLabel2.Text = "전화";
            // 
            // teltxt
            // 
            this.teltxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.teltxt.Hint = "";
            this.teltxt.Location = new System.Drawing.Point(445, 407);
            this.teltxt.MaxLength = 32767;
            this.teltxt.Multiline = false;
            this.teltxt.Name = "teltxt";
            this.teltxt.PasswordChar = '\0';
            this.teltxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.teltxt.SelectedText = "";
            this.teltxt.SelectionLength = 0;
            this.teltxt.SelectionStart = 0;
            this.teltxt.Size = new System.Drawing.Size(213, 38);
            this.teltxt.TabIndex = 10;
            this.teltxt.TabStop = false;
            this.teltxt.Text = "tel";
            this.teltxt.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(39, 466);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(77, 35);
            this.uiSymbolLabel3.TabIndex = 9;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // addrtxt
            // 
            this.addrtxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrtxt.Hint = "";
            this.addrtxt.Location = new System.Drawing.Point(122, 466);
            this.addrtxt.MaxLength = 32767;
            this.addrtxt.Multiline = false;
            this.addrtxt.Name = "addrtxt";
            this.addrtxt.PasswordChar = '\0';
            this.addrtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addrtxt.SelectedText = "";
            this.addrtxt.SelectionLength = 0;
            this.addrtxt.SelectionStart = 0;
            this.addrtxt.Size = new System.Drawing.Size(536, 38);
            this.addrtxt.TabIndex = 10;
            this.addrtxt.TabStop = false;
            this.addrtxt.Text = "address";
            this.addrtxt.UseSystemPasswordChar = false;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(39, 525);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(77, 35);
            this.uiSymbolLabel4.TabIndex = 9;
            this.uiSymbolLabel4.Text = "이메일";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailtxt.Hint = "";
            this.emailtxt.Location = new System.Drawing.Point(122, 525);
            this.emailtxt.MaxLength = 32767;
            this.emailtxt.Multiline = false;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.PasswordChar = '\0';
            this.emailtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailtxt.SelectedText = "";
            this.emailtxt.SelectionLength = 0;
            this.emailtxt.SelectionStart = 0;
            this.emailtxt.Size = new System.Drawing.Size(285, 38);
            this.emailtxt.TabIndex = 10;
            this.emailtxt.TabStop = false;
            this.emailtxt.Text = "email";
            this.emailtxt.UseSystemPasswordChar = false;
            // 
            // UpdateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.addrtxt);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.viewExit);
            this.Name = "UpdateFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateFrom";
            this.Load += new System.EventHandler(this.UpdateFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton updatebtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UISymbolButton viewExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatTextBox nametxt;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private CxFlatUI.CxFlatTextBox teltxt;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private CxFlatUI.CxFlatTextBox addrtxt;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private CxFlatUI.CxFlatTextBox emailtxt;
    }
}