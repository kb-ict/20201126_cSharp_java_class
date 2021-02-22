using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    public class Student
    {       
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }

        public Student() { }
        public Student(string name, string tel, string address, string email)
        {
            Name = name;
            Tel = tel;
            Address = address;
            Email = email;
        }

        public Student(string name, string tel, string address, string email, string id)
            : this(name, tel, address, email)
        {
            Id = id;
        }
    }
}
