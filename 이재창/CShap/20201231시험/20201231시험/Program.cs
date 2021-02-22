using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201231시험
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { Name = "Lee", Salary = 9000 };

            HR hr = new HR();
            Console.WriteLine(emp.Salary);
            hr.RaiseSalary(ref emp);
            Console.WriteLine(emp.Salary);
        }
    }

    struct Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    class HR
    {
        public void RaiseSalary(ref Employee emp)
        {
            emp.Salary += 1000;
        }
    }
}
