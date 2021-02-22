using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    public static class StudentJson
    {
        public static void Load(StudentManager manager)
        {
            try
            {
                string strJson = File.ReadAllText("주소록.json");
                JObject root = JObject.Parse(strJson);

                foreach (var token in root["AddressBook"])
                {
                    manager.Students.Add(new Student(
                        token.Value<string>("Name"),
                        token.Value<string>("Tel"),
                        token.Value<string>("Address"),
                        token.Value<string>("Email"),
                        token.Value<string>("Id")));
                }
            }
            catch (Exception)
            {

            }
        }
        public static void Save(StudentManager manager)
        {
            JObject root = new JObject();
            JArray jArray = new JArray();

            for (int i = 0; i < manager.Students.Count; i++)
            {
                JObject jObject = new JObject(
                    new JProperty("Name", manager.Students[i].Name),
                    new JProperty("Tel", manager.Students[i].Tel),
                    new JProperty("Address", manager.Students[i].Address),
                    new JProperty("Email", manager.Students[i].Email),
                    new JProperty("Id", manager.Students[i].Id));
                jArray.Add(jObject);
            }

            root.Add(new JProperty("AddressBook", jArray));
            File.WriteAllText("주소록.json", root.ToString());
        }
    }
}
