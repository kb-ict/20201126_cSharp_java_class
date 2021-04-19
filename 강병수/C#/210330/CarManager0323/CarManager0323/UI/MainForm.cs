using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
using CarManager0323.UI;
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

namespace CarManager0323
{
    partial class MainForm : MaterialForm
    {

        DaoOracle dao = new DaoOracle();
        DealHandler dHandler = new DealHandler();

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(DaoOracle dao)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //dao.dbConnect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dao.dbClose();
        }

        private void createTB_Click(object sender, EventArgs e)
        {
            dao.makeAllTB();
            MessageBox.Show("테이블이 생성되었습니다.");
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            dao.dropAllTB();
            MessageBox.Show("테이블이 삭제되었습니다.");
        }

        private void InsertAllData_Click(object sender, EventArgs e)
        {
            dao.insertCar();
            dao.insertCustomer();
            dao.insertSeller();
            dao.insertTrade();
            MessageBox.Show("샘플 정보가 저장되었습니다");
        }

        private void InsertCarData_Click(object sender, EventArgs e)
        {
            new CarInsForm(dao, dHandler).Show();
        }

        private void InsertCustomerData_Click(object sender, EventArgs e)
        {
            new CustomerInsForm(dao, dHandler).Show();
        }

        private void InsertSellerData_Click(object sender, EventArgs e)
        {
            new SellerInsForm(dao, dHandler).Show();
        }

        private void InsertTradeData_Click(object sender, EventArgs e)
        {
            List <Trade> list = dHandler.getDealList();
            if (list[0].Car == null || list[0].Customer == null || list[0].Seller == null)
            {
                MessageBox.Show("구매 내역 정보가 누락되었습니다.");
                return;
            }
            dao.insertTrade(list[0]);
            dHandler.dealListClear();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
