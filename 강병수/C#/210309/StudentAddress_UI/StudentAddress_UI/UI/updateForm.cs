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
    partial class updateForm : MaterialForm
    {
        StudentControl ct = new StudentControl();

        public updateForm(StudentControl ct)
        {
            InitializeComponent();
            this.ct = ct;
        }

        public updateForm()
            {
            }


        private void updateForm_Load(object sender, EventArgs e)
        {
            initListView1();
        }

        private void initListView1()
        {
            

            int count = StudentControl.getInst().getList().Count;
            for (int j = 0; j < count; j++)
            {
                List<Student> addrList = StudentControl.getInst().getList();
                listView1.Items.Add(new ListViewItem(new string[] { (j + 1).ToString(), addrList[j].Name, addrList[j].Tel, addrList[j].Address, addrList[j].Email }));
            }

            setRowColor(listView1, Color.White, Color.WhiteSmoke);
            int index = listView1.Items.Count - 1;
            listView1.Items[index].Selected = true;
            listView1.Items[index].Focused = true;
            listView1.EnsureVisible(index);
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

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int n = listView1.SelectedItems[0].Index;
                string name = listView1.Items[n].SubItems[1].Text;
                string tel = listView1.Items[n].SubItems[2].Text;
                string address = listView1.Items[n].SubItems[3].Text;
                string email = listView1.Items[n].SubItems[4].Text;
                Console.WriteLine("이름: {0} ", name);
                Console.WriteLine("전화: {0} ", tel);
                Console.WriteLine("주소: {0} ", address);
                Console.WriteLine("메일: {0} ", email);
                
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
