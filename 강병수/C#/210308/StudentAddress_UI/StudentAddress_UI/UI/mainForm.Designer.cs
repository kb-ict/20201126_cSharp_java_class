
namespace StudentAddress_UI
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.addAddress = new CxFlatUI.Controls.CxFlatButton();
            this.readAddress = new CxFlatUI.Controls.CxFlatButton();
            this.modifyAddress = new CxFlatUI.Controls.CxFlatButton();
            this.randomAddress = new CxFlatUI.Controls.CxFlatButton();
            this.deleteAddress = new CxFlatUI.Controls.CxFlatButton();
            this.deleteAll = new CxFlatUI.Controls.CxFlatButton();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.AppExit = new Sunny.UI.UISymbolButton();
            this.AppHelp = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addAddress
            // 
            this.addAddress.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addAddress.Location = new System.Drawing.Point(434, 91);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(193, 76);
            this.addAddress.TabIndex = 0;
            this.addAddress.Text = "주소록 정보 추가";
            this.addAddress.TextColor = System.Drawing.Color.White;
            this.addAddress.Click += new System.EventHandler(this.addAddress_Click);
            // 
            // readAddress
            // 
            this.readAddress.ButtonType = CxFlatUI.ButtonType.Primary;
            this.readAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.readAddress.Location = new System.Drawing.Point(434, 187);
            this.readAddress.Name = "readAddress";
            this.readAddress.Size = new System.Drawing.Size(193, 76);
            this.readAddress.TabIndex = 0;
            this.readAddress.Text = "주소록 정보 보기";
            this.readAddress.TextColor = System.Drawing.Color.White;
            this.readAddress.Click += new System.EventHandler(this.readAddress_Click);
            // 
            // modifyAddress
            // 
            this.modifyAddress.ButtonType = CxFlatUI.ButtonType.Primary;
            this.modifyAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.modifyAddress.Location = new System.Drawing.Point(434, 281);
            this.modifyAddress.Name = "modifyAddress";
            this.modifyAddress.Size = new System.Drawing.Size(193, 76);
            this.modifyAddress.TabIndex = 0;
            this.modifyAddress.Text = "주소록 정보 수정";
            this.modifyAddress.TextColor = System.Drawing.Color.White;
            this.modifyAddress.Click += new System.EventHandler(this.modifyAddress_Click);
            // 
            // randomAddress
            // 
            this.randomAddress.ButtonType = CxFlatUI.ButtonType.Primary;
            this.randomAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.randomAddress.Location = new System.Drawing.Point(639, 91);
            this.randomAddress.Name = "randomAddress";
            this.randomAddress.Size = new System.Drawing.Size(193, 76);
            this.randomAddress.TabIndex = 0;
            this.randomAddress.Text = "주소록 랜덤 생성";
            this.randomAddress.TextColor = System.Drawing.Color.White;
            this.randomAddress.Click += new System.EventHandler(this.randomAddress_Click);
            // 
            // deleteAddress
            // 
            this.deleteAddress.ButtonType = CxFlatUI.ButtonType.Primary;
            this.deleteAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteAddress.Location = new System.Drawing.Point(639, 187);
            this.deleteAddress.Name = "deleteAddress";
            this.deleteAddress.Size = new System.Drawing.Size(193, 76);
            this.deleteAddress.TabIndex = 0;
            this.deleteAddress.Text = "주소록 정보 삭제";
            this.deleteAddress.TextColor = System.Drawing.Color.White;
            this.deleteAddress.Click += new System.EventHandler(this.deleteAddress_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.ButtonType = CxFlatUI.ButtonType.Primary;
            this.deleteAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteAll.Location = new System.Drawing.Point(639, 281);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(193, 76);
            this.deleteAll.TabIndex = 0;
            this.deleteAll.Text = "주소록 전체 삭제";
            this.deleteAll.TextColor = System.Drawing.Color.White;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.White;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(27, 73);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(258, 305);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cxFlatPictureBox1.TabIndex = 2;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("HY산B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(2, 23);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(300, 44);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.SymbolSize = 30;
            this.uiSymbolLabel1.TabIndex = 3;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램";
            // 
            // AppExit
            // 
            this.AppExit.BackColor = System.Drawing.Color.Transparent;
            this.AppExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppExit.FillColor = System.Drawing.Color.Transparent;
            this.AppExit.FillHoverColor = System.Drawing.Color.Transparent;
            this.AppExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AppExit.ForeColor = System.Drawing.Color.Red;
            this.AppExit.Location = new System.Drawing.Point(847, 23);
            this.AppExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppExit.Name = "AppExit";
            this.AppExit.RectColor = System.Drawing.Color.Transparent;
            this.AppExit.Size = new System.Drawing.Size(43, 44);
            this.AppExit.Style = Sunny.UI.UIStyle.Custom;
            this.AppExit.Symbol = 61457;
            this.AppExit.TabIndex = 4;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // AppHelp
            // 
            this.AppHelp.BackColor = System.Drawing.Color.Transparent;
            this.AppHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppHelp.FillColor = System.Drawing.Color.Transparent;
            this.AppHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.AppHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AppHelp.Location = new System.Drawing.Point(794, 23);
            this.AppHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppHelp.Name = "AppHelp";
            this.AppHelp.RectColor = System.Drawing.Color.Transparent;
            this.AppHelp.Size = new System.Drawing.Size(47, 44);
            this.AppHelp.Style = Sunny.UI.UIStyle.Custom;
            this.AppHelp.Symbol = 61736;
            this.AppHelp.TabIndex = 4;
            this.AppHelp.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 390);
            this.Controls.Add(this.AppHelp);
            this.Controls.Add(this.AppExit);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.deleteAddress);
            this.Controls.Add(this.randomAddress);
            this.Controls.Add(this.modifyAddress);
            this.Controls.Add(this.readAddress);
            this.Controls.Add(this.addAddress);
            this.Name = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.Controls.CxFlatButton addAddress;
        private CxFlatUI.Controls.CxFlatButton readAddress;
        private CxFlatUI.Controls.CxFlatButton modifyAddress;
        private CxFlatUI.Controls.CxFlatButton randomAddress;
        private CxFlatUI.Controls.CxFlatButton deleteAddress;
        private CxFlatUI.Controls.CxFlatButton deleteAll;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton AppExit;
        private Sunny.UI.UISymbolButton AppHelp;
    }
}

