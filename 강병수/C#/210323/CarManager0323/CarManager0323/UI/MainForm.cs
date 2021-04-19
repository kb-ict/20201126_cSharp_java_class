using CarManager0323.DB;
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
    public partial class MainForm : MaterialForm
    {

        DaoOracle dao = new DaoOracle();

        public MainForm()
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
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            dao.dropAllTB();
        }
    }
}
