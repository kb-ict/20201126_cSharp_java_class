
namespace addrWin0302.UI
{
    partial class ViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridView = new Sunny.UI.UIDataGridView();
            this.gird_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gird_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.ColumnHeadersHeight = 32;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gird_count,
            this.gird_name,
            this.grid_tel,
            this.grid_addr,
            this.grid_email});
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gridView.Location = new System.Drawing.Point(12, 336);
            this.gridView.Name = "gridView";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.RowTemplate.Height = 29;
            this.gridView.SelectedIndex = -1;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.ShowGridLine = true;
            this.gridView.Size = new System.Drawing.Size(676, 252);
            this.gridView.TabIndex = 0;
            // 
            // gird_count
            // 
            this.gird_count.HeaderText = "번호";
            this.gird_count.Name = "gird_count";
            // 
            // gird_name
            // 
            this.gird_name.HeaderText = "이름";
            this.gird_name.Name = "gird_name";
            // 
            // grid_tel
            // 
            this.grid_tel.HeaderText = "전화";
            this.grid_tel.Name = "grid_tel";
            // 
            // grid_addr
            // 
            this.grid_addr.HeaderText = "주소";
            this.grid_addr.Name = "grid_addr";
            // 
            // grid_email
            // 
            this.grid_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grid_email.HeaderText = "이메일";
            this.grid_email.Name = "grid_email";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 78);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(676, 252);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
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
            this.viewExit.TabIndex = 2;
            this.viewExit.Text = "닫기";
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.gridView);
            this.Font = new System.Drawing.Font("HY동녘M", 9F);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 보기";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView gridView;
        private System.Windows.Forms.ListView listView;
        private Sunny.UI.UISymbolButton viewExit;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn gird_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn gird_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_email;
    }
}