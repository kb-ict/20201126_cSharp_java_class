
namespace CarManager0323.UI
{
    partial class DealView
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
            this.dealList = new System.Windows.Forms.ListView();
            this.deal_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custDetail = new Sunny.UI.UIButton();
            this.viewExit = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // dealList
            // 
            this.dealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deal_count,
            this.deal_name,
            this.deal_model,
            this.deal_price,
            this.deal_seller,
            this.deal_date});
            this.dealList.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dealList.FullRowSelect = true;
            this.dealList.HideSelection = false;
            this.dealList.Location = new System.Drawing.Point(76, 78);
            this.dealList.Name = "dealList";
            this.dealList.Size = new System.Drawing.Size(647, 198);
            this.dealList.TabIndex = 1;
            this.dealList.UseCompatibleStateImageBehavior = false;
            this.dealList.View = System.Windows.Forms.View.Details;
            // 
            // deal_count
            // 
            this.deal_count.Text = "번 호";
            // 
            // deal_name
            // 
            this.deal_name.Text = "고객 이름";
            this.deal_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_name.Width = 100;
            // 
            // deal_model
            // 
            this.deal_model.Text = "구매 차량";
            this.deal_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_model.Width = 120;
            // 
            // deal_price
            // 
            this.deal_price.Text = "구매 가격";
            this.deal_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_price.Width = 130;
            // 
            // deal_seller
            // 
            this.deal_seller.Text = "판매자";
            this.deal_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_seller.Width = 100;
            // 
            // deal_date
            // 
            this.deal_date.Text = "거래 날짜";
            this.deal_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_date.Width = 130;
            // 
            // custDetail
            // 
            this.custDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.custDetail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custDetail.Location = new System.Drawing.Point(165, 298);
            this.custDetail.MinimumSize = new System.Drawing.Size(1, 1);
            this.custDetail.Name = "custDetail";
            this.custDetail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.custDetail.Size = new System.Drawing.Size(100, 35);
            this.custDetail.Style = Sunny.UI.UIStyle.Custom;
            this.custDetail.TabIndex = 2;
            this.custDetail.Text = "고객 상세 정보";
            this.custDetail.Click += new System.EventHandler(this.custDetail_Click);
            // 
            // viewExit
            // 
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.FillColor = System.Drawing.Color.Red;
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.Location = new System.Drawing.Point(444, 298);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.RectColor = System.Drawing.Color.Red;
            this.viewExit.Size = new System.Drawing.Size(100, 35);
            this.viewExit.Style = Sunny.UI.UIStyle.Custom;
            this.viewExit.TabIndex = 2;
            this.viewExit.Text = "닫기";
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // DealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 390);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.custDetail);
            this.Controls.Add(this.dealList);
            this.Name = "DealView";
            this.Text = "거래 내역 보기";
            this.Load += new System.EventHandler(this.DealView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealList;
        private System.Windows.Forms.ColumnHeader deal_count;
        private System.Windows.Forms.ColumnHeader deal_name;
        private System.Windows.Forms.ColumnHeader deal_model;
        private System.Windows.Forms.ColumnHeader deal_price;
        private System.Windows.Forms.ColumnHeader deal_seller;
        private Sunny.UI.UIButton custDetail;
        private Sunny.UI.UIButton viewExit;
        private System.Windows.Forms.ColumnHeader deal_date;
    }
}