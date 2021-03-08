
namespace _20210302_addrWin
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
            this.btnAddrAdd = new CxFlatUI.CxFlatRoundButton();
            this.btnAddrView = new CxFlatUI.CxFlatRoundButton();
            this.btnAddrRamd = new CxFlatUI.CxFlatRoundButton();
            this.btnAddrDel = new CxFlatUI.CxFlatRoundButton();
            this.btnAddrDelAll = new CxFlatUI.CxFlatRoundButton();
            this.btnAddrUpdate = new CxFlatUI.CxFlatRoundButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.btnHelp = new Sunny.UI.UISymbolButton();
            this.btnExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddrAdd
            // 
            this.btnAddrAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.btnAddrAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddrAdd.Location = new System.Drawing.Point(325, 93);
            this.btnAddrAdd.Name = "btnAddrAdd";
            this.btnAddrAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAddrAdd.TabIndex = 0;
            this.btnAddrAdd.Text = "주소록 추가";
            this.btnAddrAdd.TextColor = System.Drawing.Color.White;
            this.btnAddrAdd.Click += new System.EventHandler(this.btnAddrAdd_Click);
            // 
            // btnAddrView
            // 
            this.btnAddrView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.btnAddrView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddrView.Location = new System.Drawing.Point(325, 141);
            this.btnAddrView.Name = "btnAddrView";
            this.btnAddrView.Size = new System.Drawing.Size(180, 40);
            this.btnAddrView.TabIndex = 1;
            this.btnAddrView.Text = "주소록 보기";
            this.btnAddrView.TextColor = System.Drawing.Color.White;
            this.btnAddrView.Click += new System.EventHandler(this.btnAddrView_Click);
            // 
            // btnAddrRamd
            // 
            this.btnAddrRamd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.btnAddrRamd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddrRamd.Location = new System.Drawing.Point(325, 189);
            this.btnAddrRamd.Name = "btnAddrRamd";
            this.btnAddrRamd.Size = new System.Drawing.Size(180, 40);
            this.btnAddrRamd.TabIndex = 2;
            this.btnAddrRamd.Text = "랜덤 데이터 추가";
            this.btnAddrRamd.TextColor = System.Drawing.Color.White;
            this.btnAddrRamd.Click += new System.EventHandler(this.btnRamdomAdd_Click);
            // 
            // btnAddrDel
            // 
            this.btnAddrDel.ButtonType = CxFlatUI.ButtonType.Primary;
            this.btnAddrDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddrDel.Location = new System.Drawing.Point(325, 235);
            this.btnAddrDel.Name = "btnAddrDel";
            this.btnAddrDel.Size = new System.Drawing.Size(180, 40);
            this.btnAddrDel.TabIndex = 3;
            this.btnAddrDel.Text = "주소록 삭제";
            this.btnAddrDel.TextColor = System.Drawing.Color.White;
            this.btnAddrDel.Click += new System.EventHandler(this.btnAddrDel_Click);
            // 
            // btnAddrDelAll
            // 
            this.btnAddrDelAll.ButtonType = CxFlatUI.ButtonType.Primary;
            this.btnAddrDelAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddrDelAll.Location = new System.Drawing.Point(325, 281);
            this.btnAddrDelAll.Name = "btnAddrDelAll";
            this.btnAddrDelAll.Size = new System.Drawing.Size(180, 40);
            this.btnAddrDelAll.TabIndex = 4;
            this.btnAddrDelAll.Text = "주소록 전체 삭제";
            this.btnAddrDelAll.TextColor = System.Drawing.Color.White;
            this.btnAddrDelAll.Click += new System.EventHandler(this.btnAddrDelAll_Click);
            // 
            // btnAddrUpdate
            // 
            this.btnAddrUpdate.ButtonType = CxFlatUI.ButtonType.Primary;
            this.btnAddrUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddrUpdate.Location = new System.Drawing.Point(325, 327);
            this.btnAddrUpdate.Name = "btnAddrUpdate";
            this.btnAddrUpdate.Size = new System.Drawing.Size(180, 40);
            this.btnAddrUpdate.TabIndex = 5;
            this.btnAddrUpdate.Text = "주소록 수정";
            this.btnAddrUpdate.TextColor = System.Drawing.Color.White;
            this.btnAddrUpdate.Click += new System.EventHandler(this.btnAddrUpdate_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(226, 35);
            this.uiSymbolLabel1.Symbol = 62142;
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램 1.0";
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(17, 67);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(246, 329);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 7;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnHelp.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btnHelp.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btnHelp.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnHelp.IsCircle = true;
            this.btnHelp.Location = new System.Drawing.Point(274, 7);
            this.btnHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnHelp.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btnHelp.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btnHelp.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btnHelp.Size = new System.Drawing.Size(40, 40);
            this.btnHelp.Style = Sunny.UI.UIStyle.Green;
            this.btnHelp.Symbol = 61529;
            this.btnHelp.SymbolSize = 30;
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnExit.IsCircle = true;
            this.btnExit.Location = new System.Drawing.Point(320, 7);
            this.btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnExit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.Style = Sunny.UI.UIStyle.Red;
            this.btnExit.Symbol = 61457;
            this.btnExit.SymbolSize = 30;
            this.btnExit.TabIndex = 9;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.btnAddrUpdate);
            this.Controls.Add(this.btnAddrDelAll);
            this.Controls.Add(this.btnAddrDel);
            this.Controls.Add(this.btnAddrRamd);
            this.Controls.Add(this.btnAddrView);
            this.Controls.Add(this.btnAddrAdd);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton btnAddrAdd;
        private CxFlatUI.CxFlatRoundButton btnAddrView;
        private CxFlatUI.CxFlatRoundButton btnAddrRamd;
        private CxFlatUI.CxFlatRoundButton btnAddrDel;
        private CxFlatUI.CxFlatRoundButton btnAddrDelAll;
        private CxFlatUI.CxFlatRoundButton btnAddrUpdate;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolButton btnHelp;
        private Sunny.UI.UISymbolButton btnExit;
    }
}

