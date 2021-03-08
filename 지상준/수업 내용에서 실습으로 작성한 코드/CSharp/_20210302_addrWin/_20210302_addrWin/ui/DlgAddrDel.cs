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
    public partial class DlgAddrDel : MaterialForm
    {
        private List<Student> addrList;
        public string TextBoxName { get => uiTextBoxName.Text; set => uiTextBoxName.Text = value; }

        private bool isCancel = false;
        private bool isListCountZero = false;
        private bool isValidName = false;

        public bool IsCancel { get => isCancel; }
        public bool IsListCountZero { get => isListCountZero; }
        public bool IsValidName { get => isValidName; }

        public DlgAddrDel()
        {
            InitializeComponent();
        }

        public void showDialogWithStudentAddrList(List<Student> addrList)
        {
            this.addrList = addrList;
            base.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (addrList.Count == 0)
            {
                isCancel = false;
                isListCountZero = true;
                isValidName = false;
                this.Close();
                return;
            }

            string name = TextBoxName;
            isValidName = false;
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    isValidName = true;
                    addrList.RemoveAt(i--);
                }
            }

            isCancel = false;
            isListCountZero = false;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isCancel = true;
            isValidName = false;
            isListCountZero = (addrList.Count == 0) ? true : false;
            this.Close();
        }
    }
}
