
namespace CarManager0323.UI
{
    partial class CustDetailView
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
            this.custDetailList = new System.Windows.Forms.ListView();
            this.custCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // custDetailList
            // 
            this.custDetailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.custCount,
            this.custName,
            this.custTel,
            this.custAddr,
            this.custMail});
            this.custDetailList.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custDetailList.FullRowSelect = true;
            this.custDetailList.HideSelection = false;
            this.custDetailList.Location = new System.Drawing.Point(12, 85);
            this.custDetailList.Name = "custDetailList";
            this.custDetailList.Size = new System.Drawing.Size(754, 198);
            this.custDetailList.TabIndex = 2;
            this.custDetailList.UseCompatibleStateImageBehavior = false;
            this.custDetailList.View = System.Windows.Forms.View.Details;
            // 
            // custCount
            // 
            this.custCount.Text = "번 호";
            // 
            // custName
            // 
            this.custName.Text = "고객 이름";
            this.custName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.custName.Width = 80;
            // 
            // custTel
            // 
            this.custTel.Text = "전화번호";
            this.custTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.custTel.Width = 139;
            // 
            // custAddr
            // 
            this.custAddr.Text = "주 소";
            this.custAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.custAddr.Width = 280;
            // 
            // custMail
            // 
            this.custMail.Text = "메일";
            this.custMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.custMail.Width = 170;
            // 
            // CustDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.custDetailList);
            this.Name = "CustDetailView";
            this.Text = "고객 상세 정보";
            this.Load += new System.EventHandler(this.CustDetailView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView custDetailList;
        private System.Windows.Forms.ColumnHeader custCount;
        private System.Windows.Forms.ColumnHeader custName;
        private System.Windows.Forms.ColumnHeader custTel;
        private System.Windows.Forms.ColumnHeader custAddr;
        private System.Windows.Forms.ColumnHeader custMail;
    }
}