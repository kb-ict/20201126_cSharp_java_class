using CarManager0323.DB;
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
        public CarInsForm()
        {
            InitializeComponent();
        }

        public CarInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
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
            Car car = new Car(CarModel.Text, CarYear.Text, CarPrice.Text, CarColor.Text);
            oracle.insertCar(car);
            Close();
            

        }
    }
}
