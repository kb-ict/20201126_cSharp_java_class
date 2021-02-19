using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munMine2
{
    class SingleTest2_3mine
    { 
        Random r = new Random();
        private static SingleTest2_3mine inst;
        private int data;

        SingleTest2_3mine()
        {
            data = r.Next(1, 100);
        }

        public static SingleTest2_3mine getInstance()
        {
            if(inst == null)
            {
                inst = new SingleTest2_3mine();
            }
            return inst;
        }

        public int getData()
        {
            return data;
        }
    }
}
