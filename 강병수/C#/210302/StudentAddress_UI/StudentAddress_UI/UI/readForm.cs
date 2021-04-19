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
    public partial class readForm : MaterialForm
    {
        List<Student> addressList = new List<Student>();

        public readForm()
        {
            InitializeComponent();
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
            for (int i = 0; i<addressList.Count; i++)
            {
                listView.Items.Add(new ListViewItem(
                    new string[] { (i+2).ToString(), "홍길동", "010-4542-1234", "조선 한양 홍대감댁", "hong@naver.com" }));
            }

            setRowColor(listView, Color.White, Color.WhiteSmoke);
            int index = listView.Items.Count - 1;
            listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach(ListViewItem item in list.Items)
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

        private void initGridView()
        {
            string[] data = { "1", "홍길동", "010-4542-1234", "조선 한양 홍대감댁", "hong@naver.com" };
            gridView.Rows.Add(data);
            for (int i = 0; i < 50; i++)
            {
                gridView.Rows.Add(new string[] { (i + 2).ToString(), "홍길동", "010-4542-1234", "조선 한양 홍대감댁", "hong@naver.com" });
            }
            int count = gridView.Rows.Count - 1;
            gridView.FirstDisplayedScrollingRowIndex = count;
            gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
