using AddressBook;
using AddressBook.Control;
using AddressBook.Util;
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

namespace StudentAddress_UI.UI
{
    //public partial class addForm : MaterialForm
    partial class addForm : MaterialForm
    {
        StudentControl ct;

        public addForm()
        {
            InitializeComponent();
        }

        public addForm(StudentControl ct)
        {
            InitializeComponent();
            this.ct = ct;
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            StudentControl.getInst().getList().Add(new Student(new RandomData(r).getRandomID(), addName.Text, addTel.Text, addAddress.Text, addEmail.Text));
            MessageBox.Show("주소록 정보가 저장되었습니다.");
            Close();
        }
        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
