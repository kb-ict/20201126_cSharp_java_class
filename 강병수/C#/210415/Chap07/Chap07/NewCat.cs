using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class NewCat : Animal
    {
        public void meow()
        {
            System.Windows.Forms.MessageBox.Show("야옹야옹");
        }

        public override void Fight()
        {
            System.Windows.Forms.MessageBox.Show("할퀴기");
        }
    }
}
