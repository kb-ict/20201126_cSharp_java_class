﻿using AddressBook;
using AddressBook.Control;
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
    public partial class deleteId : MaterialForm
    {
        List<Student> addressList = new List<Student>();
        readForm read = new readForm();
        public deleteId()
        {
            InitializeComponent();
        }

        private void deleteId_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            List<Student> addrList = StudentControl.getInst().getList();
            for (int i = 0; i<addrList.Count; i++)
            {
                if(addrList[i].Name.Equals(deleteIdTextBox.Text)) // 주의: 텍스트박스 이름 옆에 Text 넣어줘야함 이거 생각못하고 반나절 날림
                {
                    addrList.RemoveAt(i--);
                }
            }
            Close();
        }
    }
}
