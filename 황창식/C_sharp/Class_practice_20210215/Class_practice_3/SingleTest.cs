using System;

namespace Class_practice_3
{
    class SingleTest
    {
        Random r = new Random();
        private static SingleTest inst;
        private int data;
        SingleTest()
        {
            data = r.Next(0, 100);
        }

        public static SingleTest getInstance()
        {
            if (inst == null)
                inst = new SingleTest();
            return inst;
        }

        public int getData()
        {
            return data;
        }

    }
}
