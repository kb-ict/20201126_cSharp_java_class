﻿using AddressBook;
using AddressBook.Control;
using AddressBook.View;
using MaterialSkin.Controls;
using StudentAddress_UI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAddress_UI
{
    public partial class mainForm : MaterialForm
    {
        myMenu menu = new myMenu();
        StudentControl ct =new StudentControl();
        Student st = new Student();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("마지막 업데이트: 2021년 3월 2일");
        }

        private void addAddress_Click(object sender, EventArgs e)
        {
            //ct.addStudentInfo();
            new addForm().ShowDialog();
        }

        private void randomAddress_Click(object sender, EventArgs e)
        {
            string count = myInputBox("랜덤 데이터 생성", "랜덤하게 데이터를 생성할 갯수 입력", "0");
            if (count == "") return;
            StudentControl.getInst().randData(Convert.ToInt32(count));
        }

        private void readAddress_Click(object sender, EventArgs e)
        {
            new readForm().ShowDialog();
            //StudentControl.getInst().readStudentInfo();
        }

        private void deleteAddress_Click(object sender, EventArgs e)
        {
            new deleteId().ShowDialog();
            //StudentControl.getInst().removeStudentInfo(menu.delMenu());
        }

        private void modifyAddress_Click(object sender, EventArgs e)
        {
            new modifyId().ShowDialog();
            //StudentControl.getInst().modifyStudentInfo(menu.modifyMenu());
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            StudentControl.getInst().removeAllInfo();
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string myInputBox(string title, string body, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            return input;
        }
    }
}
