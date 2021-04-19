using AddressBook;
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
    partial class readForm : MaterialForm
    {
        StudentControl ct = new StudentControl();

        public readForm(StudentControl ct)
        {
            InitializeComponent();
            this.ct = ct;
        }

        public readForm()
        {
        }

        private void readForm_Load(object sender, EventArgs e)
        {
            initListView();
            initGridView();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initListView()
        {
            /*for (int i = 0; i < addressList.Count; i++)
            {
                string[] data = { StudentControl.getInst().getList(addressList[i].Id, addressList[i].Name, addressList[i].Tel,
                                                                    addressList[i].Address, addressList[i].Email ) };
                listView.Items.Add(new ListViewItem(data));
            }*/

            int count = StudentControl.getInst().getList().Count;
            for(int j = 0; j<count; j++)
            {
                List<Student> addrList = StudentControl.getInst().getList();
                listView.Items.Add(new ListViewItem(new string[] { (j + 1).ToString(), addrList[j].Name, addrList[j].Tel, addrList[j].Address, addrList[j].Email }));
            }

            setRowColor(listView, Color.White, Color.WhiteSmoke);
            int index = listView.Items.Count - 1;
            //listView.Items[index].Selected = true; 초기화되었을때 선택한 항목이 존재, 밑의 선택.삭제와 동시에 입력하면 충돌남
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }

        private void initGridView()
        {
            int count = StudentControl.getInst().getList().Count;
            for (int i = 0; i < count; i++)
            {
                List<Student> addrList = StudentControl.getInst().getList();
                gridView.Rows.Add(new string[] { (i + 1).ToString(), addrList[i].Name, addrList[i].Tel, addrList[i].Address, addrList[i].Email});
            }
            int index = gridView.Rows.Count - 1;
            gridView.FirstDisplayedScrollingRowIndex = index;
            gridView.CurrentCell = gridView.Rows[index - 1].Cells[0];
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                string name = listView.Items[n].SubItems[1].Text;
                string tel = listView.Items[n].SubItems[2].Text;
                string address = listView.Items[n].SubItems[3].Text;
                string email = listView.Items[n].SubItems[4].Text;
                Console.WriteLine("이름: {0} ", name);
                Console.WriteLine("전화: {0} ", tel);
                Console.WriteLine("주소: {0} ", address);
                Console.WriteLine("메일: {0} ", email);
                listView.Items.RemoveAt(n); //선택한 항목 클릭하면 삭제
            }
        }


        private void setRowColor(ListView list, Color color1, Color color2)
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
    }
}
