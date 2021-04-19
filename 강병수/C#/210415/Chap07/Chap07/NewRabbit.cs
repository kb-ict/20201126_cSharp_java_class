using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class NewRabbit : Animal
    {
        public void Bark()
        {
            System.Windows.Forms.MessageBox.Show("깡총깡총");
        }

        public override void Fight()
        {
            System.Windows.Forms.MessageBox.Show("갉아먹기");
        }
    }
}
