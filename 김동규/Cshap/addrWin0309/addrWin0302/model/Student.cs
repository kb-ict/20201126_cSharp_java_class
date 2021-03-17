using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    class Student
    {
        private string id;
        private string name;
        private string tel;
        private string adress;
        private string email;
        private static Student inst;
        public static Student getInst()
        {
            if(inst == null)
            {
                inst = new Student();
            }
            return inst;
        }
        public Student()
        {

        }

        

        public Student(string name, string tel, string adress, string email)
        {
            this.name = name;
            this.tel = tel;
            this.adress = adress;
            this.email = email;
        }

        public Student(string id, string name, string tel, string adress, string email)
        {
            this.id = id;
            this.name = name;
            this.tel = tel;
            this.adress = adress;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }

        /*  public void showAddress()
          {
              Console.WriteLine("이름: {0}",name);
              Console.WriteLine("전화: {0}", tel);
              Console.WriteLine("주소: {0}", Adress);
              Console.WriteLine("이메일: {0}", email);
              Console.WriteLine("-----------------------");
          }*/
    }
}
