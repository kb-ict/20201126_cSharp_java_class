using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210218
{
    class MemberInfo
    {
        private string id;
        private string name;
        private string tel;
        private string address;
        private string email;
        
        /*private static MemberInfo inst;
        public static MemberInfo getInst()
        {
            if (inst == null)
            {
                inst = new MemberInfo();
            }
            return inst;
        }*/

        public MemberInfo()
        {

        }

        public MemberInfo(string name, string tel, string address, string email)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        public MemberInfo(string id, string name, string tel, string address, string email) : this(name, tel, address, email)
        {
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }
    }
}
