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

namespace CarManager0323.UI
{
    public partial class CustDetailView : MaterialForm
    {
        private DaoOracle oracle;

        public CustDetailView()
        {
            InitializeComponent();
        }

        private void CustDetailView_Load(object sender, EventArgs e)
        {
            InitCustDetailView();
            oracle.selectDeal();
        }

        private void InitCustDetailView()
        {

        }
    }
}
