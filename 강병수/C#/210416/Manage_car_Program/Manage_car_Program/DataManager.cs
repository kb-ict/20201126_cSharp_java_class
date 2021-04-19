using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Manage_car_Program
{
    class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            /*
                <parkingSpot>1</parkingSpot>
                <carNumber>33후3523</carNumber>
                <driverName>가나다</driverName>
                <phoneNumber>010-1111-1343</phoneNumber>
                <parkingTime>2021-04-16 오전 11:40:58</parkingTime>
            */
            Cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carsXElement = XElement.Parse(carsOutput);
                foreach (var item in carsXElement.Descendants("car"))
                {
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value == "" ?
                        DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);

                    ParkingCar tempCar = new ParkingCar()
                    {
                        ParkingSpot = tempParkingSpot,
                        CarNumber = tempCarNumber,
                        DriverName = tempDriverName,
                        PhoneNumber = tempPhoneNumber,
                        ParkingTime = tempParkingTime
                    };

                    Cars.Add(tempCar);

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                // 만약 파일이 없어서 여기로 진입한 경우라면 
                CreateFile(); // 파일을 다시 만들고
                Save(); // 그 파일을 저장한 다음
                Load(); // 다시 불러들여본다.

                //단, Load 함수 자체가 잘못된거라면 이 코드는 무한루프에 빠진다.
            }

            CreateFile();
            //example();
        }

        private void example()
        {

        }

        private static void CreateFile()
        {
            //Cars.xml 파일을 만듬

            string FileName = @"./Cars.xml";
            StreamWriter writer = new StreamWriter(FileName); // 파일이 없으면 해당 파일 생성
            writer.Dispose(); // 메모리 해제
        }

        public static void Save()
        {
            string BooksOutput = "";
            BooksOutput += "<cars>\n"; // \n 대신에 Enviroment.NewLine 써도 가능
            if(Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    BooksOutput += "<car>\n";
                    BooksOutput += $"   <parkingSpot>{item.ParkingSpot}</parkingSpot>";
                    BooksOutput += $"   <carNumber>{item.CarNumber}</carNumber>";
                    BooksOutput += $"   <driverName>{item.DriverName}</driverName>";
                    BooksOutput += $"   <phoneNumber>{item.PhoneNumber}</phoneNumber>";
                    BooksOutput += $"   <parkingTime>{item.ParkingTime}</parkingTime>";
                    BooksOutput += "</car>\n";
                }
                
            }
            else //xml 파일에 아무것도 없는 경우
            {
                for (int i = 1; i<=5; i++)
                {
                    BooksOutput += "<car>\n";
                    BooksOutput += $"   <parkingSpot>{i}</parkingSpot>";
                    BooksOutput += $"   <carNumber></carNumber>";
                    BooksOutput += $"   <driverName></driverName>";
                    BooksOutput += $"   <phoneNumber></phoneNumber>";
                    BooksOutput += $"   <parkingTime></parkingTime>";
                    BooksOutput += "</car>\n";
                }
            }
            BooksOutput += "</cars>";
            File.WriteAllText(@"./Cars.xml", BooksOutput);
        }

        //두번째 파라미터를 넣지 않으면 name에는 parkingHistory가 들어감
        public static void printLog(string contents, string name = "parkingHistory")
        {
            DirectoryInfo di = new DirectoryInfo("parkingHistory");
            //if(di.Exists == false)
            if(!di.Exists)
            {
                di.Create(); // 폴더 만들기
            }
            // 앞에 @가 있으면
            // \을 한 개만 적는다.
            // @가 없으면 // 이렇게 해야 1개로 인식함
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt"))
            using (StreamWriter writer = new StreamWriter(@"parkingHistory\"+ name + ".txt", true))

            {
                writer.WriteLine(contents);
            }
        }

    }
}
