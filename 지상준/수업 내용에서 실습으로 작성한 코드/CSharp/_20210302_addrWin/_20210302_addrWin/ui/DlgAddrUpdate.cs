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

namespace _20210302_addrWin.ui
{
    public partial class DlgAddrUpdate : MaterialForm
    {

        private StudentHandler sh;

        public string TextBoxName { get => uiTextBoxName.Text; set => uiTextBoxName.Text = value; }
        public string TextBoxTel { get => uiTextBoxTel.Text; set => uiTextBoxTel.Text = value; }
        public string TextBoxAddress { get => uiTextBoxAddress.Text; set => uiTextBoxAddress.Text = value; }
        public string TextBoxEmail { get => uiTextBoxEmail.Text; set => uiTextBoxEmail.Text = value; }

        public DlgAddrUpdate()
        {
            InitializeComponent();
        }

        public void showDialogWithStudentAddrList(StudentHandler sh)
        {
            this.sh = sh;

            comboBoxIdUpdate.Items.Clear();
            for (int i = 0; i < sh.AddrList.Count; i++)
            {
                comboBoxIdUpdate.Items.Add(sh.AddrList[i].Id);

                TextBoxName = "수정할 이름";
                TextBoxTel = "수정할 전화";
                TextBoxAddress = "수정할 주소";
                TextBoxEmail = "수정할 메일";

                uiTextBoxName.Focus();
            }
            if (sh.hasStAddr())
                comboBoxIdUpdate.SelectedIndex = 0;

            base.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Object selectedItem = comboBoxIdUpdate.SelectedItem;
            
            if(selectedItem != null)
                sh.updateItemById(selectedItem.ToString(), TextBoxName, TextBoxTel, TextBoxAddress, TextBoxEmail);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
