using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    /// <summary>
    /// 주소록을 Json으로 다룰 수 있게 해주는 클래스
    /// </summary>
    public class StudentJson
    {
        public StudentManager Manager { get; set; }
        public string Path { get; set; }

        public StudentJson() { }

        /// <summary>
        /// Student매니저와 파일의 저장 경로를 초기화합니다.
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="path"></param>
        public StudentJson(StudentManager manager, string path)
        {
            Manager = manager;
            Path = path;
        }

        /// <summary>
        /// 파일을 불러옵니다.
        /// </summary>
        public void Load()
        {
            try
            {
                string strJson = File.ReadAllText(Path);
                JObject root = JObject.Parse(strJson);

                foreach (var token in root["AddressBook"])
                {
                    Manager.Students.Add(new Student(
                        token.Value<string>("Id"),
                        token.Value<string>("Name"),
                        token.Value<string>("Tel"),
                        token.Value<string>("Address"),
                        token.Value<string>("Email")));
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 파일로 저장합니다.
        /// </summary>
        public void Save()
        {
            JObject root = new JObject();
            JArray jArray = new JArray();

            for (int i = 0; i < Manager.Students.Count; i++)
            {
                JObject jObject = new JObject(
                    new JProperty("Id", Manager.Students[i].Id),
                    new JProperty("Name", Manager.Students[i].Name),
                    new JProperty("Tel", Manager.Students[i].Tel),
                    new JProperty("Address", Manager.Students[i].Address),
                    new JProperty("Email", Manager.Students[i].Email));
                jArray.Add(jObject);
            }

            root.Add(new JProperty("AddressBook", jArray));
            File.WriteAllText("주소록.json", root.ToString());
        }
    }
}
