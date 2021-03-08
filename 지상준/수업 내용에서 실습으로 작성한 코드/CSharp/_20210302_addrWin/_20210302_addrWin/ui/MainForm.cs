using _20210302_addrWin.ui;
using _20210302_addrWin.util;
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

namespace _20210302_addrWin
{
    public partial class MainForm : MaterialForm
    {
        private StudentHandler sh;
        private DlgAddrAdd dlgAddrAdd;
        private DlgAddrView dlgAddrView;
        private DlgAddrDel dlgAddrDel;
        private DlgAddrUpdate dlgAddrUpdate;

        public MainForm()
        {
            InitializeComponent();

            sh = new StudentHandler();
            dlgAddrAdd = new DlgAddrAdd();
            dlgAddrView = new DlgAddrView();
            dlgAddrDel = new DlgAddrDel();
            dlgAddrUpdate = new DlgAddrUpdate();
        }

        // 도움말
        private DlgTest dlgTest = new DlgTest();
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update " +  DateTime.Now);

            // dlgTest.ShowDialog();

            // 솔루션 탐색기 >> 참조 >> 참조 우측클릭 참조 추가 >> 어셈블리 >> Microsoft.VisualBasic 참조하기
            // Point parentPoint = this.Location;
            // int parentHeight = this.Height; // 메인폼(현재폼)의 높이
            // int parentWidth = this.Width; // 메인폼(현재폼)의 너비
            // Microsoft.VisualBasic.Interaction.InputBox("a", "b", "c", parentPoint.X + 40, parentPoint.Y + 120);
        }

        // 종료
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 1. 주소록 추가
        private void btnAddrAdd_Click(object sender, EventArgs e)
        {
            dlgAddrAdd.showDialogWithRandStudentAddr(sh);

            if(dlgAddrAdd.IsCancel)
                MessageBox.Show("추가되었습니다");
            else
                MessageBox.Show("취소되었습니다");
        }

        // 2. 주소록 보기
        private void btnAddrView_Click(object sender, EventArgs e)
        {
            // sh.showAddrListByUsingMBox();
            dlgAddrView.showDialogWithStudentAddrList(sh.AddrList);
        }

        // 3. 랜덤 데이터 추가
        private void btnRamdomAdd_Click(object sender, EventArgs e)
        {
            sh.addItem(StudentHandler.getRandStudentAddr());
        }

        // 4. 주소록 삭제
        private void btnAddrDel_Click(object sender, EventArgs e)
        {
            dlgAddrDel.showDialogWithStudentAddrList(sh.AddrList);

            if(dlgAddrDel.IsCancel)
                MessageBox.Show("취소되었습니다");
            else
            {
                if(dlgAddrDel.IsValidName)
                    MessageBox.Show(dlgAddrDel.TextBoxName + "님이 주소록에서 삭제되었습니다");
                else
                {
                    if(dlgAddrDel.IsListCountZero)
                        MessageBox.Show("주소록이 비어있습니다");
                    else
                        MessageBox.Show(dlgAddrDel.TextBoxName + "님은 주소록에 없습니다");
                }

                dlgAddrDel.TextBoxName = "";
            }
        }

        // 5. 주소록 전체 삭제
        private void btnAddrDelAll_Click(object sender, EventArgs e)
        {
            sh.delItem(true);
        }

        // 6. 주소록 수정
        private void btnAddrUpdate_Click(object sender, EventArgs e)
        {
            dlgAddrUpdate.showDialogWithStudentAddrList(sh);
        }
    }

}
