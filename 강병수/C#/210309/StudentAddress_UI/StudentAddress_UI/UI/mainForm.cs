using AddressBook;
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
using System.Drawing.Text;

namespace StudentAddress_UI
{
    public partial class mainForm : MaterialForm
    {
        MyMenu menu = new MyMenu();
        StudentControl ct =new StudentControl();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            initFont();
        }

        private void initFont()
        {
            PrivateFontCollection pFont = new PrivateFontCollection();
            pFont.AddFontFile("font/Nanumpen.ttf");
            Font font = new Font(pFont.Families[0], 12f);
            addAddress.Font = font;
            readAddress.Font = font;
            modifyAddress.Font = font;
            deleteAddress.Font = font;
            deleteAll.Font = font;
            randomAddress.Font = font;
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
            int count = StudentControl.getInst().getList().Count;
            if(count == 0)
            {
                MessageBox.Show("주소록 정보가 존재하지 않습니다.");
            }
            else
            { 
            new readForm(ct).ShowDialog();
                //StudentControl.getInst().readStudentInfo();
            }
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
            MessageBox.Show("주소록 정보가 전부 삭제되었습니다");
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
