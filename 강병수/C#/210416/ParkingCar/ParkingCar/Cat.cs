using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCar
{
    class Cat : Animal, iFight, iRunnable
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("카짓 음식 훔치러 간다.");
            //구현이 안 되어 있다는 에러를 띄우는 것
            //throw new NotImplementedException();
        }


    }
}
