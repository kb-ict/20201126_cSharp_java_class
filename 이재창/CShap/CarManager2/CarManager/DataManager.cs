using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CarManager
{
    class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            LoadXml();
        }

        public static void LoadXml()
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(@"ParkingCar.xml");

                XmlNode carsNode = xml.SelectSingleNode("cars");

                foreach (XmlNode carNode in carsNode.SelectNodes("car"))
                {
                    ParkingCar car = new ParkingCar();
                    car.ParkingSpot = Convert.ToInt32(
                        carNode.SelectSingleNode("parkingSpot").InnerText);
                    car.CarNumber = carNode.SelectSingleNode("carNumber").InnerText;
                    car.DriverName = carNode.SelectSingleNode("driverName").InnerText;
                    car.PhoneNumber = carNode.SelectSingleNode("phoneNumber").InnerText;
                    car.ParkingTime = (carNode.SelectSingleNode("parkingTime").InnerText == string.Empty)
                        ? DateTime.Now : DateTime.Parse(carNode.SelectSingleNode("parkingTime").InnerText);
                    Cars.Add(car);
                }
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show(
                    "저장된 파일이 없어 새 파일을 만듭니다.\nParkingCar.xml파일 생성!");
                SaveXml();
                LoadXml();
            }  
        }

        public static void SaveXml()
        {
            XmlDocument xml = new XmlDocument();
            XmlNode carsNode = xml.CreateElement("cars");

            // 데이터를 입력이 되어있을 때
            if (Cars.Count > 0)
            {
                foreach (var car in Cars)
                {
                    XmlNode carNode = xml.CreateElement("car");

                    carNode.AppendChild(xml.CreateElement("parkingSpot"));
                    carNode["parkingSpot"].InnerText = car.ParkingSpot.ToString();
                    carNode.AppendChild(xml.CreateElement("carNumber"));
                    carNode["carNumber"].InnerText = car.CarNumber;
                    carNode.AppendChild(xml.CreateElement("driverName"));
                    carNode["driverName"].InnerText = car.DriverName;
                    carNode.AppendChild(xml.CreateElement("phoneNumber"));
                    carNode["phoneNumber"].InnerText = car.PhoneNumber;
                    carNode.AppendChild(xml.CreateElement("parkingTime"));
                    carNode["parkingTime"].InnerText = car.ParkingTime.ToString();

                    carsNode.AppendChild(carNode);
                }
            }
            // xml파일이 없을 때(처음 실행 했을 때)
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    XmlNode carNode = xml.CreateElement("car");

                    carNode.AppendChild(xml.CreateElement("parkingSpot"));
                    carNode["parkingSpot"].InnerText = (i + 1).ToString();
                    carNode.AppendChild(xml.CreateElement("carNumber"));
                    carNode.AppendChild(xml.CreateElement("driverName"));
                    carNode.AppendChild(xml.CreateElement("phoneNumber"));
                    carNode.AppendChild(xml.CreateElement("parkingTime"));

                    carsNode.AppendChild(carNode);
                }
            }
           
            xml.AppendChild(carsNode);
            xml.Save(@"ParkingCar.xml");
        }
    }
}
