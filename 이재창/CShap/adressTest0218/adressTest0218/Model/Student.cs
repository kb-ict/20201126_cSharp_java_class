using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    /// <summary>
    /// 주소록 클래스
    /// </summary>
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }      

        public Student() { }

        public Student(string id, string name, string tel, string address, string email)
        {
            Id = id;
            Name = name;
            Tel = tel;
            Address = address;
            Email = email;
        }
    }
}
