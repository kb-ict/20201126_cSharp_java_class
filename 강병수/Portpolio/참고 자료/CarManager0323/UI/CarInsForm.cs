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
    partial class CarInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        public CarInsForm()
        {
            InitializeComponent();
        }

        public CarInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CarInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void CarInsFormcs_Load(object sender, EventArgs e)
        {

        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addOK_Click(object sender, EventArgs e)
        {
            if (CarModel.Text == "" || CarPrice.Text == "" || CarYear.Text == "" || CarColor.Text == "")
            {
                MessageBox.Show("정보가 누락되었습니다.");
                return;
            }
            List<Trade> list = dHandler.getDealList();
            Car car = new Car(CarModel.Text, CarYear.Text, CarPrice.Text, CarColor.Text);
            list[0].Car = car;
            oracle.insertCar(car);
            MessageBox.Show("정보가 저장되었습니다");
            Close();
        }
    }
}
