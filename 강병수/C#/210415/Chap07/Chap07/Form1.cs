using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap07
{
    public partial class Form1 : Form
    {

        List<Rabbit> rabbit = new List<Rabbit>()
            { new Rabbit(), new Rabbit()};
        List<Cat> cat = new List<Cat>()
            { new Cat(), new Cat()};

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in rabbit)
            {
                item.Eat();
                item.Bark();
            }
            foreach (var item in cat)
            {
                item.Eat();
                item.meow();
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewCat c = new NewCat();
            c.Eat();
            c.name = "강병수";
            c.breedName = "인간";
            NewRabbit r = new NewRabbit();
            r.Eat();

            List<Animal> Animals = new List<Animal>()
            {
                new NewRabbit(), new NewCat(), new NewRabbit(), new NewCat()
            };
            //(Animals[0] as NewRabbit).breedName = "롭이어";

            foreach (var item in Animals)
            {
                item.Eat();
                var rabbit = item as NewRabbit;
                if (rabbit != null)
                {
                    rabbit.Bark();
                }
                var cat = item as NewCat;
                if (cat != null)
                {
                    cat.meow();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            NewRabbit r = new NewRabbit();
            NewCat c = new NewCat();

            a.Fight();
            r.Fight();
            c.Fight();

            a.name = "강병수";
            a.age = 29;

            r.name = "안셀";
            r.age = 3;

            MessageBox.Show(a.ToString());
            MessageBox.Show(r.ToString());

            Cat oldcat = new Cat();
            oldcat.name = "나옹";
            oldcat.age = 25;
            MessageBox.Show(oldcat.ToString());
        }
    }
}
