
namespace addrWin0302
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.addrHelp = new Sunny.UI.UISymbolButton();
            this.addrExit = new Sunny.UI.UISymbolButton();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.addrAdd = new Sunny.UI.UIButton();
            this.addrDel = new Sunny.UI.UIButton();
            this.addrDelAll = new Sunny.UI.UIButton();
            this.addrAddRand = new Sunny.UI.UIButton();
            this.addrView = new Sunny.UI.UIButton();
            this.addrUpdate = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 29);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(238, 29);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 12;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램1.0";
            // 
            // addrHelp
            // 
            this.addrHelp.BackColor = System.Drawing.Color.Transparent;
            this.addrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrHelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addrHelp.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.addrHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrHelp.IsCircle = true;
            this.addrHelp.Location = new System.Drawing.Point(532, 29);
            this.addrHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrHelp.Name = "addrHelp";
            this.addrHelp.RectColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectPressColor = System.Drawing.Color.Transparent;
            this.addrHelp.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrHelp.Size = new System.Drawing.Size(60, 60);
            this.addrHelp.Style = Sunny.UI.UIStyle.Custom;
            this.addrHelp.Symbol = 61736;
            this.addrHelp.SymbolSize = 40;
            this.addrHelp.TabIndex = 16;
            this.addrHelp.Click += new System.EventHandler(this.addrHelp_Click);
            // 
            // addrExit
            // 
            this.addrExit.BackColor = System.Drawing.Color.Transparent;
            this.addrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addrExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addrExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrExit.IsCircle = true;
            this.addrExit.Location = new System.Drawing.Point(610, 29);
            this.addrExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrExit.Name = "addrExit";
            this.addrExit.RectColor = System.Drawing.Color.Transparent;
            this.addrExit.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrExit.RectPressColor = System.Drawing.Color.Transparent;
            this.addrExit.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrExit.Size = new System.Drawing.Size(60, 60);
            this.addrExit.Style = Sunny.UI.UIStyle.Custom;
            this.addrExit.Symbol = 61457;
            this.addrExit.SymbolSize = 40;
            this.addrExit.TabIndex = 16;
            this.addrExit.Click += new System.EventHandler(this.addrExit_Click);
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(244, 235);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(215, 216);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 13;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // addrAdd
            // 
            this.addrAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addrAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addrAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.addrAdd.Font = new System.Drawing.Font("HY동녘M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrAdd.Location = new System.Drawing.Point(34, 160);
            this.addrAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrAdd.Name = "addrAdd";
            this.addrAdd.Radius = 80;
            this.addrAdd.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.addrAdd.RectColor = System.Drawing.Color.Transparent;
            this.addrAdd.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrAdd.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrAdd.RectPressColor = System.Drawing.Color.Transparent;
            this.addrAdd.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrAdd.Size = new System.Drawing.Size(216, 53);
            this.addrAdd.Style = Sunny.UI.UIStyle.Custom;
            this.addrAdd.TabIndex = 17;
            this.addrAdd.Text = "주소록 추가";
            this.addrAdd.Click += new System.EventHandler(this.addrAdd_Click);
            // 
            // addrDel
            // 
            this.addrDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addrDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addrDel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addrDel.Font = new System.Drawing.Font("HY동녘M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrDel.Location = new System.Drawing.Point(441, 160);
            this.addrDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrDel.Name = "addrDel";
            this.addrDel.Radius = 80;
            this.addrDel.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.addrDel.RectColor = System.Drawing.Color.Transparent;
            this.addrDel.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrDel.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrDel.RectPressColor = System.Drawing.Color.Transparent;
            this.addrDel.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrDel.Size = new System.Drawing.Size(216, 53);
            this.addrDel.Style = Sunny.UI.UIStyle.Custom;
            this.addrDel.TabIndex = 17;
            this.addrDel.Text = "주소록 삭제";
            this.addrDel.Click += new System.EventHandler(this.addrDel_Click);
            // 
            // addrDelAll
            // 
            this.addrDelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addrDelAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrDelAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addrDelAll.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addrDelAll.Font = new System.Drawing.Font("HY동녘M", 16F);
            this.addrDelAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrDelAll.Location = new System.Drawing.Point(465, 316);
            this.addrDelAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrDelAll.Name = "addrDelAll";
            this.addrDelAll.Radius = 60;
            this.addrDelAll.RectColor = System.Drawing.Color.Transparent;
            this.addrDelAll.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrDelAll.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrDelAll.RectPressColor = System.Drawing.Color.Transparent;
            this.addrDelAll.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrDelAll.Size = new System.Drawing.Size(216, 53);
            this.addrDelAll.Style = Sunny.UI.UIStyle.Custom;
            this.addrDelAll.TabIndex = 17;
            this.addrDelAll.Text = "주소록 전체 삭제";
            this.addrDelAll.Click += new System.EventHandler(this.addrDelAll_Click);
            // 
            // addrAddRand
            // 
            this.addrAddRand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addrAddRand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrAddRand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addrAddRand.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.addrAddRand.Font = new System.Drawing.Font("HY동녘M", 16F);
            this.addrAddRand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrAddRand.Location = new System.Drawing.Point(12, 316);
            this.addrAddRand.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrAddRand.Name = "addrAddRand";
            this.addrAddRand.Radius = 60;
            this.addrAddRand.RectColor = System.Drawing.Color.Transparent;
            this.addrAddRand.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrAddRand.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrAddRand.RectPressColor = System.Drawing.Color.Transparent;
            this.addrAddRand.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrAddRand.Size = new System.Drawing.Size(216, 53);
            this.addrAddRand.Style = Sunny.UI.UIStyle.Custom;
            this.addrAddRand.TabIndex = 17;
            this.addrAddRand.Text = "주소록 데이터 추가";
            this.addrAddRand.Click += new System.EventHandler(this.addrAddRand_Click);
            // 
            // addrView
            // 
            this.addrView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addrView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addrView.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.addrView.Font = new System.Drawing.Font("HY동녘M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrView.Location = new System.Drawing.Point(34, 472);
            this.addrView.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrView.Name = "addrView";
            this.addrView.Radius = 80;
            this.addrView.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightBottom)));
            this.addrView.RectColor = System.Drawing.Color.Transparent;
            this.addrView.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrView.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrView.RectPressColor = System.Drawing.Color.Transparent;
            this.addrView.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrView.Size = new System.Drawing.Size(216, 53);
            this.addrView.Style = Sunny.UI.UIStyle.Custom;
            this.addrView.TabIndex = 17;
            this.addrView.Text = "주소록 보기";
            this.addrView.Click += new System.EventHandler(this.addrView_Click);
            // 
            // addrUpdate
            // 
            this.addrUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addrUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addrUpdate.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addrUpdate.Font = new System.Drawing.Font("HY동녘M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addrUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrUpdate.Location = new System.Drawing.Point(441, 472);
            this.addrUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrUpdate.Name = "addrUpdate";
            this.addrUpdate.Radius = 80;
            this.addrUpdate.RadiusSides = ((Sunny.UI.UICornerRadiusSides)((Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.addrUpdate.RectColor = System.Drawing.Color.Transparent;
            this.addrUpdate.RectDisableColor = System.Drawing.Color.Transparent;
            this.addrUpdate.RectHoverColor = System.Drawing.Color.Transparent;
            this.addrUpdate.RectPressColor = System.Drawing.Color.Transparent;
            this.addrUpdate.RectSelectedColor = System.Drawing.Color.Transparent;
            this.addrUpdate.Size = new System.Drawing.Size(216, 53);
            this.addrUpdate.Style = Sunny.UI.UIStyle.Custom;
            this.addrUpdate.TabIndex = 17;
            this.addrUpdate.Text = "주소록 수정";
            this.addrUpdate.Click += new System.EventHandler(this.addrUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.addrDelAll);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.addrDel);
            this.Controls.Add(this.addrAddRand);
            this.Controls.Add(this.addrView);
            this.Controls.Add(this.addrAdd);
            this.Controls.Add(this.addrExit);
            this.Controls.Add(this.addrHelp);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolButton addrHelp;
        private Sunny.UI.UISymbolButton addrExit;
        private Sunny.UI.UIButton addrAdd;
        private Sunny.UI.UIButton addrDel;
        private Sunny.UI.UIButton addrDelAll;
        private Sunny.UI.UIButton addrAddRand;
        private Sunny.UI.UIButton addrView;
        private Sunny.UI.UIButton addrUpdate;
    }
}

