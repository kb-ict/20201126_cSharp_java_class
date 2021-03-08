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

namespace _20210302_addrWin.util
{
    public partial class DlgAddrView : MaterialForm
    {
        
        public DlgAddrView()
        {
            InitializeComponent();

            listView.Columns.Add("ID", 80, HorizontalAlignment.Center);
            listView.Columns.Add("이름", 55, HorizontalAlignment.Center);
            listView.Columns.Add("전화", 93, HorizontalAlignment.Center);
            listView.Columns.Add("주소", 54, HorizontalAlignment.Center);
            listView.Columns.Add("이메일", 90, HorizontalAlignment.Center);
            // listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void showDialogWithStudentAddrList(List<Student> addrList)
        {
            listView.Items.Clear();

            ListViewItem[] items = new ListViewItem[addrList.Count];
            for (int i = 0; i < addrList.Count; i++)
            {
                items[i] = new ListViewItem(addrList[i].Id);
                items[i].SubItems.Add(addrList[i].Name);
                items[i].SubItems.Add(addrList[i].Tel);
                items[i].SubItems.Add(addrList[i].Address);
                items[i].SubItems.Add(addrList[i].Email);
            }

            // listView.Items[0].Selected = true;
            // listView.Items[0].Focused = true;
            // listView.EnsureVisible(0);

            listView.Items.AddRange(items);
            setRowColor(Color.LightGreen, Color.YellowGreen);

            base.ShowDialog();
        }

        private void setRowColor(Color color1, Color color2)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = color1;
                else
                    item.BackColor = color2;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                string name = listView.Items[n].SubItems[1].Text;
                string tel = listView.Items[n].SubItems[2].Text;
                string addr = listView.Items[n].SubItems[3].Text;
                string email = listView.Items[n].SubItems[4].Text;
                Console.WriteLine("" + name);
                Console.WriteLine("" + tel);
                Console.WriteLine("" + addr);
                Console.WriteLine("" + email);
                // listView.Items.RemoveAt(n);
            }
        }
    }
}
