
namespace StudentAddress_UI.UI
{
    partial class readForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listView = new System.Windows.Forms.ListView();
            this.listCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridView = new Sunny.UI.UIDataGridView();
            this.gridCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listCount,
            this.listName,
            this.listTel,
            this.listAddress,
            this.listEmail});
            this.listView.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 82);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(754, 198);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // listCount
            // 
            this.listCount.Text = "번 호";
            // 
            // listName
            // 
            this.listName.Text = "이 름";
            this.listName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listName.Width = 80;
            // 
            // listTel
            // 
            this.listTel.Text = "전 화 번 호";
            this.listTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listTel.Width = 140;
            // 
            // listAddress
            // 
            this.listAddress.Text = "주소";
            this.listAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listAddress.Width = 280;
            // 
            // listEmail
            // 
            this.listEmail.Text = "이 메 일";
            this.listEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listEmail.Width = 170;
            // 
            // gridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridView.ColumnHeadersHeight = 32;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridCount,
            this.gridName,
            this.gridTel,
            this.gridAddress,
            this.gridEmail});
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gridView.Location = new System.Drawing.Point(12, 286);
            this.gridView.Name = "gridView";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridView.RowTemplate.Height = 29;
            this.gridView.SelectedIndex = -1;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.ShowGridLine = true;
            this.gridView.Size = new System.Drawing.Size(754, 179);
            this.gridView.TabIndex = 1;
            // 
            // gridCount
            // 
            this.gridCount.HeaderText = "번 호";
            this.gridCount.Name = "gridCount";
            // 
            // gridName
            // 
            this.gridName.HeaderText = "이 름";
            this.gridName.Name = "gridName";
            // 
            // gridTel
            // 
            this.gridTel.HeaderText = "전화번호";
            this.gridTel.Name = "gridTel";
            // 
            // gridAddress
            // 
            this.gridAddress.HeaderText = "주 소";
            this.gridAddress.Name = "gridAddress";
            this.gridAddress.Width = 180;
            // 
            // gridEmail
            // 
            this.gridEmail.HeaderText = "이 메 일";
            this.gridEmail.Name = "gridEmail";
            // 
            // viewExit
            // 
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.Location = new System.Drawing.Point(331, 500);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.Size = new System.Drawing.Size(110, 39);
            this.viewExit.Style = Sunny.UI.UIStyle.Custom;
            this.viewExit.TabIndex = 2;
            this.viewExit.Text = "확인";
            this.viewExit.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // readForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 570);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.listView);
            this.Name = "readForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 보기";
            this.Load += new System.EventHandler(this.readForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private Sunny.UI.UIDataGridView gridView;
        private Sunny.UI.UISymbolButton viewExit;
        private System.Windows.Forms.ColumnHeader listCount;
        private System.Windows.Forms.ColumnHeader listName;
        private System.Windows.Forms.ColumnHeader listTel;
        private System.Windows.Forms.ColumnHeader listAddress;
        private System.Windows.Forms.ColumnHeader listEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmail;
    }
}