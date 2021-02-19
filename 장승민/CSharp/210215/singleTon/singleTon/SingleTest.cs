using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;
        Random rd = new Random();
        public SingleTest()
        {
            data = (int)(rd.Next(0, 99));
        }
        public static SingleTest getInstance()
        {
            if (inst == null)
            {
                inst = new SingleTest();
            }
            return inst;
        }
        public int getData()
        {
            return data;
        }
    }
}
