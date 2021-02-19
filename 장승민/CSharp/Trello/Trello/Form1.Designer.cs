
namespace Trello
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
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.btnDyntxt_1 = new System.Windows.Forms.Button();
            this.btnDyntxt_2 = new System.Windows.Forms.Button();
            this.btnDyntxt_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoEllipsis = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuCustomLabel1.Image")));
            this.bunifuCustomLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(145, 63);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Treeeello";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoEllipsis = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuCustomLabel2.Image")));
            this.bunifuCustomLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(56, 87);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(145, 63);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "To do";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoEllipsis = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuCustomLabel3.Image")));
            this.bunifuCustomLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(392, 87);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(145, 63);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Doing";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoEllipsis = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuCustomLabel4.Image")));
            this.bunifuCustomLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(733, 87);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(145, 63);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Done";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDyntxt_1
            // 
            this.btnDyntxt_1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDyntxt_1.FlatAppearance.BorderSize = 0;
            this.btnDyntxt_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDyntxt_1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDyntxt_1.Location = new System.Drawing.Point(45, 178);
            this.btnDyntxt_1.Name = "btnDyntxt_1";
            this.btnDyntxt_1.Size = new System.Drawing.Size(166, 33);
            this.btnDyntxt_1.TabIndex = 4;
            this.btnDyntxt_1.Text = "+";
            this.btnDyntxt_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDyntxt_1.UseVisualStyleBackColor = false;
            this.btnDyntxt_1.Click += new System.EventHandler(this.btnDyntxt_1_Click);
            // 
            // btnDyntxt_2
            // 
            this.btnDyntxt_2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDyntxt_2.FlatAppearance.BorderSize = 0;
            this.btnDyntxt_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDyntxt_2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDyntxt_2.Location = new System.Drawing.Point(381, 178);
            this.btnDyntxt_2.Name = "btnDyntxt_2";
            this.btnDyntxt_2.Size = new System.Drawing.Size(166, 33);
            this.btnDyntxt_2.TabIndex = 5;
            this.btnDyntxt_2.Text = "+";
            this.btnDyntxt_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDyntxt_2.UseVisualStyleBackColor = false;
            this.btnDyntxt_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDyntxt_3
            // 
            this.btnDyntxt_3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDyntxt_3.FlatAppearance.BorderSize = 0;
            this.btnDyntxt_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDyntxt_3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDyntxt_3.Location = new System.Drawing.Point(722, 178);
            this.btnDyntxt_3.Name = "btnDyntxt_3";
            this.btnDyntxt_3.Size = new System.Drawing.Size(166, 33);
            this.btnDyntxt_3.TabIndex = 6;
            this.btnDyntxt_3.Text = "+";
            this.btnDyntxt_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDyntxt_3.UseVisualStyleBackColor = false;
            this.btnDyntxt_3.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(974, 660);
            this.Controls.Add(this.btnDyntxt_3);
            this.Controls.Add(this.btnDyntxt_2);
            this.Controls.Add(this.btnDyntxt_1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnDyntxt_1;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button btnDyntxt_3;
        private System.Windows.Forms.Button btnDyntxt_2;
    }
}

