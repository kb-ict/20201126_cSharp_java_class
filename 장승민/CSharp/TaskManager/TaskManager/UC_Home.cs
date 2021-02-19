using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlExtension.Draggable(bunifuTextbox1,true);
            ControlExtension.Draggable(bunifuTextbox2, true);
            ControlExtension.Draggable(bunifuTextbox3, true);
            ControlExtension.Draggable(bunifuTextbox4, true);
            ControlExtension.Draggable(bunifuTextbox5, true);
            ControlExtension.Draggable(bunifuTextbox6, true);
        }
    }
}
