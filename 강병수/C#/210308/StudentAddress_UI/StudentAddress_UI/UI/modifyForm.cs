using AddressBook;
using AddressBook.Control;
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

namespace StudentAddress_UI.UI
{
    public partial class modifyForm : MaterialForm
    {
        public modifyForm()
        {
            InitializeComponent();
        }

        private void modifyForm_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            List<Student> addrList = StudentControl.getInst().getList();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
