using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student[] students = new Student[]
            {
                new Student { Name = "둘리", Age = 100, Address = "지구", PhoneNumber = "010-0001-9999"},
                new Student { Name = "도우너", Age = 100, Address = "깐따삐야", PhoneNumber = "010-0001-9999"},
                new Student { Name = "또치", Age = 100, Address = "지구", PhoneNumber = "010-0001-9999"}
            };           
            string strJson = JsonConvert.SerializeObject(students);
            JArray jarr = JArray.Parse(strJson);
            File.WriteAllText(@"json.json", jarr.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            string strJson = File.ReadAllText(@"json.json");
            Student[] students = JsonConvert.DeserializeObject<Student[]>(strJson);

            listBox1.Items.Clear();
            foreach (var student in students)
            {
                listBox1.Items.Add(student);
            }
        }
    }
}
