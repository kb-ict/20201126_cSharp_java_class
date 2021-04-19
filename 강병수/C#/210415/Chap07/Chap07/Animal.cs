using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public string breedName { get; set; }

        public void Eat()
        {
            System.Windows.Forms.MessageBox.Show("캣닢");
        }

        public virtual void Fight()
        {
            System.Windows.Forms.MessageBox.Show("퍽퍽");
        }

        public override string ToString()
        {
            //return name + age;
            return "내 주인의 이름은 " + name + "이고, 내 나이는 " + age + "이다.";
        }

    }
}
