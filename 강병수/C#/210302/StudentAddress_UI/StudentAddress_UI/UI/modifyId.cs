using AddressBook;
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
    public partial class modifyId : MaterialForm
    {
        List<Student> addressList = new List<Student>();

        public modifyId()
        {
            InitializeComponent();
        }

        private void modifyId_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<addressList.Count; i++)
            {
                if(addressList[i].Id == modifyIDTextBox.Text)
                {

                }
                else
                {
                    MessageBox.Show("입력한 정보와 일치하는 ID가 존재하지 않습니다.");
                    Close();
                }
                    
            }
        }
    }
}
