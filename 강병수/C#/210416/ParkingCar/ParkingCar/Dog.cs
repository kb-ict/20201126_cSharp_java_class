using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCar
{
    class Dog : Animal
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("촵촵촵");
            //throw new NotImplementedException();
        }
    }
}
