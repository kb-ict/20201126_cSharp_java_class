using adressTest0218.control;
using MaterialSkin.Controls;
using adressTest0218;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addrWin0302.UI
{
     partial class DelForm : MaterialForm
    {
        StudentHandler sc;
        public DelForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void initListView()
        {

            for (int i = 0; i < sc.getList().Count; i++)
            {
                this.listView.Items.Add(new ListViewItem(new string[]{
                    (i + 1).ToString(),
                     sc.getList()[i].Name,
                     sc.getList()[i].Tel,
                     sc.getList()[i].Adress,
                     sc.getList()[i].Email }
                     ));
            }

            setRowColor(listView, Color.White, Color.LightGray);
            int index = listView.Items.Count - 1;
            listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
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

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int n = 0;
                while (true) {

                   
                        if (listView.SelectedItems.Count == 0) {
                            break;
                        }
                        n = listView.SelectedItems[0].Index;
                        sc.getList().RemoveAt(n);
                        listView.Items.RemoveAt(n);
                       
                    /*string name = listView.Items[n].SubItems[1].Text;
                    string tel = listView.Items[n].SubItems[2].Text;
                    string addr = listView.Items[n].SubItems[3].Text;
                    string email = listView.Items[n].SubItems[4].Text;*/

                    // listView.BeginUpdate();

                    //listView.EndUpdate();
                }
                ViewForm.getVf(sc).setRowColor(listView, Color.White, Color.LightGray);
            }
            

        }
        private void DelFrom_Load(object sender, EventArgs e)
        {
            initListView();
        }
    }
}
