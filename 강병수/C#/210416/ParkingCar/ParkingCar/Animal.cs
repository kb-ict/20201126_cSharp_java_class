using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCar
{
    abstract class Animal : iRunnable, iFight
    {
        public abstract void Eat();

        public void fight()
        {
            System.Windows.Forms.MessageBox.Show("Bam");
            //throw new NotImplementedException();
        }

        public void Run()
        {
            System.Windows.Forms.MessageBox.Show("슉슉");
            //throw new NotImplementedException();
        }

        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("zzzzz");
        }
    }
}
