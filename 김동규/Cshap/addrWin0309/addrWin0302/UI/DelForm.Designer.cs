
namespace addrWin0302.UI
{
    partial class DelForm
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
            this.viewExit = new Sunny.UI.UISymbolButton();
            this.listView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delbtn = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
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
            this.viewExit.TabIndex = 3;
            this.viewExit.Text = "닫기";
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.listView.Font = new System.Drawing.Font("HY동녘M", 9F);
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 81);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(676, 466);
            this.listView.TabIndex = 4;
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
            // delbtn
            // 
            this.delbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delbtn.FillColor = System.Drawing.Color.Crimson;
            this.delbtn.FillHoverColor = System.Drawing.Color.Aquamarine;
            this.delbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delbtn.Location = new System.Drawing.Point(490, 553);
            this.delbtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.delbtn.Name = "delbtn";
            this.delbtn.RectColor = System.Drawing.Color.Turquoise;
            this.delbtn.Size = new System.Drawing.Size(198, 35);
            this.delbtn.Style = Sunny.UI.UIStyle.Custom;
            this.delbtn.TabIndex = 5;
            this.delbtn.Text = "선택 삭제";
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // DelFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.viewExit);
            this.Name = "DelFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DelFrom";
            this.Load += new System.EventHandler(this.DelFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton viewExit;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UISymbolButton delbtn;
    }
}