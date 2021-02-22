using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 인터페이스
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a[0] = 100;
            Console.WriteLine(a[0]);
        }
    }

    abstract class Test
    {
        public int T { get; set; }
        public abstract void TPrint();
        public void TPrint2()
        {
            Console.WriteLine("TPrint2()");
        }
    }

    interface ITest
    {
        int It { get; set; }
        void IPrint();
    }

    class A : Test, ITest
    {
        //public int It { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int It { get; set; }

        int[] arr = new int[10];
        public int this[int a]
        {
            /*get { return arr[a]; }
            set { arr[a] = value; }*/
            get => arr[a];
            set => arr[a] = value;
        }
        public void IPrint()
        {
            Console.WriteLine("IA");
        }

        public override void TPrint()
        {
            Console.WriteLine("A");
        }
    }
}
