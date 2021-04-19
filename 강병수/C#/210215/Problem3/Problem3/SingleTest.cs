using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class SingleTest
    {
        private static SingleTest inst;
        private int data;
        Random ran = new Random();
        
        public SingleTest()
        {
            data = (int)(ran.NextDouble() * 100);
        }

        public static SingleTest getInstance()
        {
            if(inst == null)
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
