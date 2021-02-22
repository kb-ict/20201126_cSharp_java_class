using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace test1
{
    public partial class Form1 : Form
    {
        Student[] students;
        Point mousePoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region XML파일 읽기
            /*XmlDocument xml = new XmlDocument();
            string path = "student.xml";
            xml.Load(path);
            XmlNode studentNode = xml.SelectNodes("학생")[0];

            int studentCount = studentNode.SelectNodes("이름").Count;
            Student.Count = studentCount;
            students = new Student[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                string name = studentNode.SelectNodes("이름")[i].InnerText;
                int sex = (studentNode.SelectNodes("성별")[i].InnerText == "남") ? 1 : 2;
                bool fronted = Convert.ToBoolean(int.Parse(studentNode.SelectNodes("앞자리")[i].InnerText));
                students[i] = new Student(name, sex, fronted);
            }*/
            #endregion

            #region JSON파일 읽기     
            using (StreamReader sr = new StreamReader("student.json"))
            {
                string strJson = sr.ReadToEnd();
                JObject json = JObject.Parse(strJson);

                students = new Student[json["학생"].Count()];

                for (int i = 0; i < students.Length; i++)
                {
                    string name = json["학생"][i]["이름"].ToString();
                    string sex = json["학생"][i].Value<string>("성별");
                    bool fronted = json["학생"][i].Value<bool>("앞자리");
                    students[i] = new Student(name, sex, fronted);
                }
            }
            #endregion

            #region JSON파일 읽기(직렬화)
            /*List<Student> lStudent = new List<Student>();
            lStudent.Add
            //students = new Student[]
            string strJson = JsonConvert.DeserializeObject*/
            #endregion
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            Student.SeatAllocate(students);
          
            int seatNum = 1;
            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    c.Text = string.Empty;
                    for (int i = 0; i < students.Length; i++)
                    {
                        //if (students[i].SeatNum == seatNum)
                        if (c.Name == ("label" + students[i].SeatNum))
                        {
                            c.Text = students[i].Name;
                            if (students[i].Sex == "남")
                            {
                                c.BackColor = Color.FromArgb(255, 128, 255, 128);
                            }
                            else
                            {
                                c.BackColor = Color.Pink;
                            }
                        }
                    }
                    seatNum++;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); // 현재 마우스 좌표 저장
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 왼쪽 클릭시
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
