using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
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

namespace CarManager0323.UI
{
    partial class DealView : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;

        public DealView()
        {
            InitializeComponent();
        }

        public DealView(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void DealView_Load(object sender, EventArgs e)
        {
            initDealView();
            oracle.selectDeal();
        }


        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void custDetail_Click(object sender, EventArgs e)
        {
            new CustDetailView().ShowDialog();
        }

        private void initDealView()
        {
            List<DealResult> list = oracle.selectDeal();
            /* string[] data = { "1", "홍길동", "그랜저", "4000만원", "전우치", "21/3/31" };
            dealList.Items.Add(new ListViewItem(data)); */
            if (list == null)
            {
                MessageBox.Show("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i=0; i<list.Count; i++)
            {
                dealList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Count.ToString(), list[i].CustName, list[i].Model, list[i].Price, list[i].SellName, list[i].Date
                    }
                    ));
            }
            setRowColor(dealList, Color.White, Color.WhiteSmoke);
            int index = dealList.Items.Count - 1;
            //listView.Items[index].Selected = true; 초기화되었을때 선택한 항목이 존재, 밑의 선택.삭제와 동시에 입력하면 충돌남
            dealList.Items[index].Focused = true;
            dealList.EnsureVisible(index);
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
