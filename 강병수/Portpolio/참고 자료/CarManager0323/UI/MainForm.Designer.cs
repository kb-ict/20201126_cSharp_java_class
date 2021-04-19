
namespace CarManager0323
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createTB = new Sunny.UI.UIButton();
            this.dropTB = new Sunny.UI.UIButton();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.InsertCarData = new Sunny.UI.UIButton();
            this.InsertCustomerData = new Sunny.UI.UIButton();
            this.InsertSellerData = new Sunny.UI.UIButton();
            this.InsertTradeData = new Sunny.UI.UIButton();
            this.InsertAllData = new Sunny.UI.UIButton();
            this.CloseProgram = new Sunny.UI.UIButton();
            this.DealInfo = new Sunny.UI.UIButton();
            this.ProgramHelp = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createTB
            // 
            this.createTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTB.Location = new System.Drawing.Point(548, 27);
            this.createTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTB.Name = "createTB";
            this.createTB.Size = new System.Drawing.Size(100, 35);
            this.createTB.TabIndex = 0;
            this.createTB.Text = "테이블 생성";
            this.createTB.Click += new System.EventHandler(this.createTB_Click);
            // 
            // dropTB
            // 
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTB.Location = new System.Drawing.Point(677, 27);
            this.dropTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTB.Name = "dropTB";
            this.dropTB.Size = new System.Drawing.Size(100, 35);
            this.dropTB.TabIndex = 0;
            this.dropTB.Text = "테이블 삭제";
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(0, 64);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(542, 386);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 1;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // InsertCarData
            // 
            this.InsertCarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertCarData.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCarData.Location = new System.Drawing.Point(563, 112);
            this.InsertCarData.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertCarData.Name = "InsertCarData";
            this.InsertCarData.Size = new System.Drawing.Size(100, 35);
            this.InsertCarData.TabIndex = 2;
            this.InsertCarData.Text = "차량 정보 추가";
            this.InsertCarData.Click += new System.EventHandler(this.InsertCarData_Click);
            // 
            // InsertCustomerData
            // 
            this.InsertCustomerData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertCustomerData.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCustomerData.Location = new System.Drawing.Point(688, 112);
            this.InsertCustomerData.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertCustomerData.Name = "InsertCustomerData";
            this.InsertCustomerData.Size = new System.Drawing.Size(100, 35);
            this.InsertCustomerData.TabIndex = 2;
            this.InsertCustomerData.Text = "고객 정보 추가";
            this.InsertCustomerData.Click += new System.EventHandler(this.InsertCustomerData_Click);
            // 
            // InsertSellerData
            // 
            this.InsertSellerData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertSellerData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertSellerData.Location = new System.Drawing.Point(563, 176);
            this.InsertSellerData.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertSellerData.Name = "InsertSellerData";
            this.InsertSellerData.Size = new System.Drawing.Size(100, 35);
            this.InsertSellerData.TabIndex = 2;
            this.InsertSellerData.Text = "판매자 정보 추가";
            this.InsertSellerData.Click += new System.EventHandler(this.InsertSellerData_Click);
            // 
            // InsertTradeData
            // 
            this.InsertTradeData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertTradeData.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertTradeData.Location = new System.Drawing.Point(688, 176);
            this.InsertTradeData.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertTradeData.Name = "InsertTradeData";
            this.InsertTradeData.Size = new System.Drawing.Size(100, 35);
            this.InsertTradeData.TabIndex = 2;
            this.InsertTradeData.Text = "거래 정보 추가";
            this.InsertTradeData.Click += new System.EventHandler(this.InsertTradeData_Click);
            // 
            // InsertAllData
            // 
            this.InsertAllData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertAllData.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertAllData.Location = new System.Drawing.Point(563, 235);
            this.InsertAllData.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertAllData.Name = "InsertAllData";
            this.InsertAllData.Size = new System.Drawing.Size(100, 35);
            this.InsertAllData.TabIndex = 2;
            this.InsertAllData.Text = "샘플 정보 추가";
            this.InsertAllData.Click += new System.EventHandler(this.InsertAllData_Click);
            // 
            // CloseProgram
            // 
            this.CloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseProgram.FillColor = System.Drawing.Color.Red;
            this.CloseProgram.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseProgram.Location = new System.Drawing.Point(688, 293);
            this.CloseProgram.MinimumSize = new System.Drawing.Size(1, 1);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.RectColor = System.Drawing.Color.Red;
            this.CloseProgram.Size = new System.Drawing.Size(100, 35);
            this.CloseProgram.Style = Sunny.UI.UIStyle.Custom;
            this.CloseProgram.TabIndex = 2;
            this.CloseProgram.Text = "프로그램 종료";
            this.CloseProgram.Click += new System.EventHandler(this.ExitProgram);
            // 
            // DealInfo
            // 
            this.DealInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DealInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DealInfo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealInfo.Location = new System.Drawing.Point(688, 235);
            this.DealInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.DealInfo.Name = "DealInfo";
            this.DealInfo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DealInfo.Size = new System.Drawing.Size(100, 35);
            this.DealInfo.Style = Sunny.UI.UIStyle.Custom;
            this.DealInfo.TabIndex = 2;
            this.DealInfo.Text = "거래 정보 보기";
            this.DealInfo.Click += new System.EventHandler(this.DealInfo_Click);
            // 
            // ProgramHelp
            // 
            this.ProgramHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgramHelp.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramHelp.Location = new System.Drawing.Point(563, 293);
            this.ProgramHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.ProgramHelp.Name = "ProgramHelp";
            this.ProgramHelp.Size = new System.Drawing.Size(100, 35);
            this.ProgramHelp.TabIndex = 2;
            this.ProgramHelp.Text = "도움말";
            this.ProgramHelp.Click += new System.EventHandler(this.InsertSellerData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseProgram);
            this.Controls.Add(this.InsertAllData);
            this.Controls.Add(this.InsertTradeData);
            this.Controls.Add(this.ProgramHelp);
            this.Controls.Add(this.DealInfo);
            this.Controls.Add(this.InsertSellerData);
            this.Controls.Add(this.InsertCustomerData);
            this.Controls.Add(this.InsertCarData);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.createTB);
            this.Name = "MainForm";
            this.Text = "차량 고객 관리 프로그램 v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton createTB;
        private Sunny.UI.UIButton dropTB;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UIButton InsertCarData;
        private Sunny.UI.UIButton InsertCustomerData;
        private Sunny.UI.UIButton InsertSellerData;
        private Sunny.UI.UIButton InsertTradeData;
        private Sunny.UI.UIButton InsertAllData;
        private Sunny.UI.UIButton CloseProgram;
        private Sunny.UI.UIButton DealInfo;
        private Sunny.UI.UIButton ProgramHelp;
    }
}

