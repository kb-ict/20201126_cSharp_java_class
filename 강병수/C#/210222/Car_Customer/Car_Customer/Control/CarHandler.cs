using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Customer.Control
{
    class CarHandler
    {
        List<Car> cars = new List<Car>();

        public void addCarInfo()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     차량 정보 입력");
            Console.WriteLine("=======================");
            Console.Write("모델: ");
            string model = Console.ReadLine();
            Console.Write("가격: ");
            string price = Console.ReadLine();
            Console.Write("색상: ");
            string color = Console.ReadLine();
            Console.Write("제조사: ");
            string company = Console.ReadLine();
            Console.Write("일련번호: ");
            int serial = int.Parse(Console.ReadLine());
            cars.Add(new Car(serial, model, price, color, company));
            Console.WriteLine("차량 정보가 정상적으로 저장됨");
        }

        public void viewCarInfo()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     차량 정보 열람 ");
            Console.WriteLine("=======================");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("일련번호: " + cars[i].Serial);
                Console.WriteLine("모델: " + cars[i].Model);
                Console.WriteLine("가격: " + cars[i].Price);
                Console.WriteLine("색상: " + cars[i].Color);
                Console.WriteLine("제조사: " + cars[i].Company);
                Console.WriteLine("=======================");
            }
        }

        public void modifyCarInfo(int car_number)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (car_number == cars[i].Serial)
                {

                    Console.WriteLine("=======================");
                    Console.WriteLine("       정보 수정 ");
                    Console.WriteLine("=======================");
                    Console.Write("모델: ");
                    string model = Console.ReadLine();
                    cars[i].Model = model;
                    Console.Write("가격: ");
                    string price = Console.ReadLine();
                    cars[i].Price = price;
                    Console.Write("색상: ");
                    string color = Console.ReadLine();
                    cars[i].Color = color;
                    Console.Write("제조사: ");
                    string company = Console.ReadLine();
                    cars[i].Company = company;
                    Console.WriteLine("=======================");
                    Console.WriteLine("       수정 완료 ");
                    Console.WriteLine("=======================");
                }
            }
        }

        public void deleteCarInfo(int remove_num)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (remove_num.Equals(cars[i].Serial))
                {
                    cars.RemoveAt(i);
                }
            }
            Console.WriteLine("=======================");
            Console.WriteLine("       삭제 완료 ");
            Console.WriteLine("=======================");
        }

        public void clearCarInfo()
        {
            cars.Clear();
            Console.WriteLine("모든 정보가 삭제되었습니다.");
        }
    }
}
