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
     partial class ViewForm : MaterialForm
    {
        //  StudentHandler sc;
        StudentHandler sc;
        MainForm form;
        static ViewForm vf;
       
       
        public ViewForm()
        {
           
            InitializeComponent();
           
        }
        public ViewForm(StudentHandler sc)
        {

            InitializeComponent();
            this.sc = sc;
        }

        public ViewForm(StudentHandler sc, MainForm form)
        {

            InitializeComponent();
            this.sc = sc;
            this.form = form;
        }

        public static ViewForm getVf(StudentHandler sc)
        {
            if (vf == null)
            {
                vf = new ViewForm(sc);
            }
            return vf;
        }

       

        public void showlist()
        {
            
           
            form.mview(listView);
        }

        public void initListView()
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
           
            /*string[] data = { "1", "홍길동", "010-2929-3939", "조선 한양 홍대감댁", "hong@naver.com" };
            listView.Items.Add(new ListViewItem(data));
            for (int i = 0; i < 50; i++) {
                listView.Items.Add(new ListViewItem(
                    new string[]
                    {
                       (i+2).ToString(), "홍길동", "010-2929-3939", "조선 한양 홍대감댁", "hong@naver.com"
                    }
                    ));
            }*/ 
            setRowColor(listView, Color.White, Color.LightGray);
            int index = listView.Items.Count-1;
            listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }

        public void setRowColor(ListView list,Color color1, Color color2)
        {
            foreach(ListViewItem item in list.Items)
            {
                if((item.Index %2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }

        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // initListView();
            form.mview(listView);
            //showlist();
            initGridView();
        }

        private void initGridView()
        {
            
            for (int i = 0; i < sc.getList().Count; i++)
            {
                gridView.Rows.Add(
                    i+1,
                    sc.getList()[i].Name,
                    sc.getList()[i].Tel,
                    sc.getList()[i].Adress,
                    sc.getList()[i].Email
                    ) ;
            }
            int count = gridView.Rows.Count - 1;
            gridView.FirstDisplayedScrollingRowIndex = count;
               
            gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];
            

        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
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

                Console.WriteLine("이름: {0}",name);
                Console.WriteLine("전화: {0}", tel);
                Console.WriteLine("주소: {0}", addr);
                Console.WriteLine("메일: {0}", email);
            }
        }
    }
}
