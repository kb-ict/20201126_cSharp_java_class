using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Student> lStudent = new List<Student>();
            Student student;
            string strJson;
            using (StreamReader sr = new StreamReader("test2.json"))
            {
                strJson = sr.ReadToEnd();
                student = JsonConvert.DeserializeObject<Student>(strJson);
            }
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Sex);
            Console.WriteLine(student.Fronted);*/
            using (StreamReader sr = new StreamReader("student.json"))
            {
                string strJson = sr.ReadToEnd();
                JObject json = JObject.Parse(strJson);
                var temp = json["학생"][0].Value<bool>("앞자리");
                Console.WriteLine(temp);
            }
        }
    }
}
