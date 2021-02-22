
namespace MYSQL
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
            this.lv_student = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_dataAdd = new System.Windows.Forms.Button();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.gb_student = new System.Windows.Forms.GroupBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.gb_student.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_student
            // 
            this.lv_student.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_student.FullRowSelect = true;
            this.lv_student.GridLines = true;
            this.lv_student.HideSelection = false;
            this.lv_student.Location = new System.Drawing.Point(26, 177);
            this.lv_student.Name = "lv_student";
            this.lv_student.Size = new System.Drawing.Size(515, 311);
            this.lv_student.TabIndex = 0;
            this.lv_student.UseCompatibleStateImageBehavior = false;
            this.lv_student.View = System.Windows.Forms.View.Details;
            this.lv_student.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_student_ColumnClick);
            this.lv_student.SelectedIndexChanged += new System.EventHandler(this.lv_student_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "num";
            this.columnHeader1.Text = "학번";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "num";
            this.columnHeader3.Text = "나이";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "학과";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "주소";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 140;
            // 
            // btn_dataAdd
            // 
            this.btn_dataAdd.Location = new System.Drawing.Point(221, 68);
            this.btn_dataAdd.Name = "btn_dataAdd";
            this.btn_dataAdd.Size = new System.Drawing.Size(69, 25);
            this.btn_dataAdd.TabIndex = 5;
            this.btn_dataAdd.Text = "추가";
            this.btn_dataAdd.UseVisualStyleBackColor = true;
            this.btn_dataAdd.Click += new System.EventHandler(this.btn_dataAdd_Click);
            // 
            // tb_department
            // 
            this.tb_department.Location = new System.Drawing.Point(65, 76);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(106, 21);
            this.tb_department.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(65, 22);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(106, 21);
            this.tb_name.TabIndex = 1;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(65, 49);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(106, 21);
            this.tb_age.TabIndex = 2;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(65, 103);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(106, 21);
            this.tb_address.TabIndex = 4;
            // 
            // gb_student
            // 
            this.gb_student.Controls.Add(this.lbl_address);
            this.gb_student.Controls.Add(this.lbl_age);
            this.gb_student.Controls.Add(this.lbl_name);
            this.gb_student.Controls.Add(this.lbl_department);
            this.gb_student.Controls.Add(this.tb_name);
            this.gb_student.Controls.Add(this.tb_department);
            this.gb_student.Controls.Add(this.tb_address);
            this.gb_student.Controls.Add(this.tb_age);
            this.gb_student.Location = new System.Drawing.Point(26, 23);
            this.gb_student.Name = "gb_student";
            this.gb_student.Size = new System.Drawing.Size(189, 136);
            this.gb_student.TabIndex = 8;
            this.gb_student.TabStop = false;
            this.gb_student.Text = "학생정보";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(23, 106);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(29, 12);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "주소";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(23, 52);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(29, 12);
            this.lbl_age.TabIndex = 8;
            this.lbl_age.Text = "나이";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(23, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(29, 12);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "이름";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(23, 79);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(29, 12);
            this.lbl_department.TabIndex = 8;
            this.lbl_department.Text = "학과";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(221, 40);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(69, 25);
            this.btn_select.TabIndex = 6;
            this.btn_select.Text = "조회";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(221, 96);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(69, 25);
            this.btn_modify.TabIndex = 9;
            this.btn_modify.Text = "수정";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(221, 124);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(69, 25);
            this.btn_remove.TabIndex = 10;
            this.btn_remove.Text = "삭제";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 510);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.gb_student);
            this.Controls.Add(this.btn_dataAdd);
            this.Controls.Add(this.lv_student);
            this.Name = "Form1";
            this.Text = "학생관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_student.ResumeLayout(false);
            this.gb_student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_student;
        private System.Windows.Forms.Button btn_dataAdd;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.GroupBox gb_student;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_remove;
    }
}

