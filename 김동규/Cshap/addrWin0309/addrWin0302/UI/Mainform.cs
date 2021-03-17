using addrWin0302.UI;
using adressTest0218.control;
using adressTest0218.util;
using MaterialSkin;
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

namespace addrWin0302
{
    public partial class MainForm : MaterialForm
    {
        StudentMenu menu = new StudentMenu();
        StudentHandler sc = new StudentHandler();
        

        public MainForm()
        {
            InitializeComponent();


            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

        }
      
        //list view 공통
         public void mview(ListView list)
        {
            
            for (int i = 0; i < sc.getList().Count; i++)
            {
                list.Items.Add(new ListViewItem(new string[]{
                    (i + 1).ToString(),
                     sc.getList()[i].Name,
                     sc.getList()[i].Tel,
                     sc.getList()[i].Adress,
                     sc.getList()[i].Email }
                     ));
            }
            
            setRowColor(list, Color.White, Color.LightGray);
            int index = list.Items.Count - 1;
            list.Items[index].Selected = true;
            list.Items[index].Focused = true;
            list.EnsureVisible(index);
        }

        //짝수 홀수 뷰 색상
        public void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }

        }

        //나가기
        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //주소록 help
        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("update 2021년3월2일 by 김동규");
        }
        //주소록 추가
        private void addrAdd_Click(object sender, EventArgs e)
        {
           // sc.addItem();
            new AddForm(sc).ShowDialog();
        }

        //주소록 보기
        private void addrView_Click(object sender, EventArgs e)
        {
            ViewForm vf = new ViewForm(sc,this);
            //StudentHandler.getInst().viewItem();
            if (sc.getList().Count > 0)
                //ViewForm.getVf(sc,this).ShowDialog();
                vf.ShowDialog();
            else
                MessageBox.Show("데이터가 없습니다.");
            
        }
        //주소록 랜덤 추가
        private void addrAddRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤 데이터 생성", "랜덤하게 데이터를 생성할 갯수를 입력하세요","0");
            if (cnt == "") return;
            sc.randItem(Convert.ToInt32(cnt));
        }
        //주소록 삭제
        private void addrDel_Click(object sender, EventArgs e)
        {
            if (sc.getList().Count > 0)
                new DelForm(sc).ShowDialog();
            else
                MessageBox.Show("데이터가 없습니다.");
        }

        //주소록 전체 삭제
        private void addrDelAll_Click(object sender, EventArgs e)
        {
            sc.cleanItem();
            MessageBox.Show("데이터 전체삭제 완료");
        }

        //주소록 수정
        private void addrUpdate_Click(object sender, EventArgs e)
        {
            //menu.modifyMenu();
           
            if (sc.getList().Count > 0)
                new UpdateForm(sc,this).ShowDialog();
            else
                MessageBox.Show("데이터가 없습니다.");
        }

        //랜덤추가시 프롬프트 상자로 입력 받기
        private string myInputBox(string title, string body, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            return input;
        }
    }
}
