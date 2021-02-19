
namespace EmartIbgu_Kiosk
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1_Best = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this._3_NowSale1 = new EmartIbgu_Kiosk._3_NowSale();
            this._4th_customerCenter1 = new EmartIbgu_Kiosk._4th_customerCenter();
            this._3rd_Location1 = new EmartIbgu_Kiosk._3rd_Location();
            this._2nd_bestSeller1 = new EmartIbgu_Kiosk._2nd_bestSeller();
            this._1st_Main1 = new EmartIbgu_Kiosk._1st_Main();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.btn1_Best);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 1020);
            this.panel1.TabIndex = 0;
            // 
            // btn1_Best
            // 
            this.btn1_Best.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btn1_Best.FlatAppearance.BorderSize = 0;
            this.btn1_Best.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_Best.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.btn1_Best.ForeColor = System.Drawing.Color.White;
            this.btn1_Best.Image = ((System.Drawing.Image)(resources.GetObject("btn1_Best.Image")));
            this.btn1_Best.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1_Best.Location = new System.Drawing.Point(0, 92);
            this.btn1_Best.Margin = new System.Windows.Forms.Padding(0);
            this.btn1_Best.Name = "btn1_Best";
            this.btn1_Best.Size = new System.Drawing.Size(70, 56);
            this.btn1_Best.TabIndex = 1;
            this.btn1_Best.Text = "베스트";
            this.btn1_Best.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1_Best.UseVisualStyleBackColor = false;
            this.btn1_Best.BackgroundImageChanged += new System.EventHandler(this.button1_Click);
            this.btn1_Best.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(0, 311);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 56);
            this.button5.TabIndex = 1;
            this.button5.Text = "문의";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 238);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "위치";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "세일중";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 76);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this._3rd_Location1);
            this.panel3.Controls.Add(this._2nd_bestSeller1);
            this.panel3.Controls.Add(this._1st_Main1);
            this.panel3.Controls.Add(this._3_NowSale1);
            this.panel3.Controls.Add(this._4th_customerCenter1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 1020);
            this.panel3.TabIndex = 4;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(510, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(60, 60);
            this.exit.TabIndex = 9;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // _3_NowSale1
            // 
            this._3_NowSale1.BackColor = System.Drawing.Color.Transparent;
            this._3_NowSale1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_3_NowSale1.BackgroundImage")));
            this._3_NowSale1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._3_NowSale1.Location = new System.Drawing.Point(69, 0);
            this._3_NowSale1.Margin = new System.Windows.Forms.Padding(0);
            this._3_NowSale1.MaximumSize = new System.Drawing.Size(500, 1020);
            this._3_NowSale1.Name = "_3_NowSale1";
            this._3_NowSale1.Size = new System.Drawing.Size(500, 1020);
            this._3_NowSale1.TabIndex = 11;
            this._3_NowSale1.Load += new System.EventHandler(this._3_NowSale1_Load);
            // 
            // _4th_customerCenter1
            // 
            this._4th_customerCenter1.BackColor = System.Drawing.Color.Transparent;
            this._4th_customerCenter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_4th_customerCenter1.BackgroundImage")));
            this._4th_customerCenter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._4th_customerCenter1.Location = new System.Drawing.Point(70, 0);
            this._4th_customerCenter1.Margin = new System.Windows.Forms.Padding(0);
            this._4th_customerCenter1.MaximumSize = new System.Drawing.Size(500, 1020);
            this._4th_customerCenter1.Name = "_4th_customerCenter1";
            this._4th_customerCenter1.Size = new System.Drawing.Size(500, 1020);
            this._4th_customerCenter1.TabIndex = 7;
            this._4th_customerCenter1.Load += new System.EventHandler(this._4th_customerCenter1_Load);
            // 
            // _3rd_Location1
            // 
            this._3rd_Location1.BackColor = System.Drawing.Color.Transparent;
            this._3rd_Location1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_3rd_Location1.BackgroundImage")));
            this._3rd_Location1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._3rd_Location1.Location = new System.Drawing.Point(70, 0);
            this._3rd_Location1.Margin = new System.Windows.Forms.Padding(0);
            this._3rd_Location1.MaximumSize = new System.Drawing.Size(500, 1020);
            this._3rd_Location1.Name = "_3rd_Location1";
            this._3rd_Location1.Size = new System.Drawing.Size(500, 1020);
            this._3rd_Location1.TabIndex = 6;
            this._3rd_Location1.Load += new System.EventHandler(this._3rd_Location1_Load);
            // 
            // _2nd_bestSeller1
            // 
            this._2nd_bestSeller1.BackColor = System.Drawing.Color.Transparent;
            this._2nd_bestSeller1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_2nd_bestSeller1.BackgroundImage")));
            this._2nd_bestSeller1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._2nd_bestSeller1.Location = new System.Drawing.Point(70, 0);
            this._2nd_bestSeller1.Margin = new System.Windows.Forms.Padding(0);
            this._2nd_bestSeller1.MaximumSize = new System.Drawing.Size(500, 1020);
            this._2nd_bestSeller1.Name = "_2nd_bestSeller1";
            this._2nd_bestSeller1.Size = new System.Drawing.Size(500, 1020);
            this._2nd_bestSeller1.TabIndex = 5;
            this._2nd_bestSeller1.Load += new System.EventHandler(this._2nd_bestSeller1_Load);
            // 
            // _1st_Main1
            // 
            this._1st_Main1.BackColor = System.Drawing.Color.Transparent;
            this._1st_Main1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_1st_Main1.BackgroundImage")));
            this._1st_Main1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._1st_Main1.Location = new System.Drawing.Point(70, 0);
            this._1st_Main1.Margin = new System.Windows.Forms.Padding(0);
            this._1st_Main1.MaximumSize = new System.Drawing.Size(643, 1700);
            this._1st_Main1.Name = "_1st_Main1";
            this._1st_Main1.Size = new System.Drawing.Size(500, 1020);
            this._1st_Main1.TabIndex = 10;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(570, 1020);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn1_Best;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private _2nd_bestSeller _2nd_bestSeller1;
        private _3rd_Location _3rd_Location1;
        private _4th_customerCenter _4th_customerCenter1;
        private System.Windows.Forms.Button exit;
        private _1st_Main _1st_Main1;
        private _3_NowSale _3_NowSale1;
    }
}

