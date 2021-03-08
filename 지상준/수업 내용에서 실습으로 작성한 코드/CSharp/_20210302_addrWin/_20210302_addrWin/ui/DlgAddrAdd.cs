using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210302_addrWin
{
    public partial class DlgAddrAdd : MaterialForm
    {
        private StudentHandler sh;

        private Student st;
        private bool isCancel = false;

        public bool IsCancel { get => isCancel; set => isCancel = value; }
        public string GetName { get => uiTextBoxName.Text; }
        public string GetTel { get => uiTextBoxTel.Text; }
        public string GetAddress { get => uiTextBoxAddress.Text; }
        public string GetEmail { get => uiTextBoxEmail.Text; }

        public DlgAddrAdd()
        {
            InitializeComponent();
        }

        public void showDialogWithRandStudentAddr(StudentHandler sh)
        {
            this.sh = sh;

            st = StudentHandler.getRandStudentAddr();
            uiTextBoxName.Text = st.Name;
            uiTextBoxTel.Text = st.Tel;
            uiTextBoxAddress.Text = st.Address;
            uiTextBoxEmail.Text = st.Email;

            base.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sh.addItem(new Student(GetName, GetTel, GetAddress, GetEmail));
            isCancel = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isCancel = false;
            this.Close();
        }
    }
}
