using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class Rabbit
    {
        public string name { get; set; }
        public int age { get; set; }
        public string breedName { get; set; }
        public string masterName { get; set; }

        public void Eat()
        {
            System.Windows.Forms.MessageBox.Show("당근");
        }
        public void Bark()
        {
            System.Windows.Forms.MessageBox.Show("깡총깡총");
        }
    }
}
