using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
            MessageBox.Show("Test");
            Console.WriteLine("again");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
            Form2 f = new Form2();
            f.Show(); //Modeless 모달리스
            Console.WriteLine("again");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(); //Modal 모달
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Eat();
            c.Sleep();

            Dog d = new Dog();
            d.Eat();
            d.Sleep();

            //다형성 복습
            Animal a = new Dog();
            Animal b = new Cat();
            a.Eat(); //a에는 Dog가 들어가있다.
            b.Eat(); //b에는 Cat이 들어가있다.
        }
    }
}
