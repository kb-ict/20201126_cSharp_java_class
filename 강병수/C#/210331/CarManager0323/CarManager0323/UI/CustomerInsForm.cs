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
    partial class CustomerInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        public CustomerInsForm()
        {
            InitializeComponent();
        }

        public CustomerInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CustomerInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void CustomerInsFormcs_Load(object sender, EventArgs e)
        {

        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            if (CustName.Text == "" || CustAddr.Text == "" || CustMail.Text == "" || CustTel.Text == "")
            {
                MessageBox.Show("정보가 누락되었습니다.");
                return;
            }
            List<Trade> list = dHandler.getDealList();
            Customer customer = new Customer(CustName.Text, CustAddr.Text, CustMail.Text, CustTel.Text);
            list[0].Customer = customer;
            oracle.insertCustomer(customer);
            MessageBox.Show("정보가 저장되었습니다");
            Close();
        }
    }
}
