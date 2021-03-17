using adressTest0218;
using adressTest0218.control;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addrWin0302.UI
{
     partial class AddForm : MaterialForm
    {
        StudentHandler sc;

        

        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }
       

        private void addOk_Click(object sender, EventArgs e)
        {
            if (addName.Text.Trim().Length==0)
            {
                MessageBox.Show("이름 입력");
            }
            else if(addTel.Text.Trim().Length == 0)
            {
                MessageBox.Show("전화 입력");
            }
            else if(addAddr.Text.Trim().Length == 0)
            {
                MessageBox.Show("주소 입력");
            }
            else if(addEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("이메일 입력");
            }
            else { 
            sc.getList().Add(new Student(
               sc.getID(),
               addName.Text,
               addTel.Text, 
               addAddr.Text, 
               addEmail.Text));
                MessageBox.Show("정상적으로 데이터가 입력되었습니다.");
            Close();
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
