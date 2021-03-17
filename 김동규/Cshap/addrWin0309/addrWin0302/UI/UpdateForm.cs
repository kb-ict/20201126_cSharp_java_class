using adressTest0218.control;
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

namespace addrWin0302.UI
{
   partial class UpdateForm : MaterialForm
    {
        StudentHandler sc;
        private MainForm form;

        public UpdateForm()
        {
            InitializeComponent();
        }

        public UpdateForm(StudentHandler sc,MainForm form)
        {
            InitializeComponent();
            this.sc = sc;
            this.form = form;
        }

        private void initListView()
        {

            for (int i = 0; i < sc.getList().Count; i++)
            {
                listView.Items.Add(new ListViewItem(new string[]{
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int n = listView.SelectedItems[0].Index;
            sc.getList()[n].Name = nametxt.Text;
            sc.getList()[n].Tel = teltxt.Text;
            sc.getList()[n].Adress = addrtxt.Text;
            sc.getList()[n].Email = emailtxt.Text;
            listView.Items[n].SubItems[1].Text = nametxt.Text;
            listView.Items[n].SubItems[2].Text = teltxt.Text;
            listView.Items[n].SubItems[3].Text = addrtxt.Text;
            listView.Items[n].SubItems[4].Text = emailtxt.Text;
            ViewForm.getVf(sc).setRowColor(listView, Color.White, Color.LightGray);
        }

        private void UpdateFrom_Load(object sender, EventArgs e)
        {
            form.mview(listView);
        }
    }
}
