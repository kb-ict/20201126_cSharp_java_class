using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210208
{
    class Car
    {
        // 클래스 상수 변수
        public const string DAERI = "동대구 영업소";

        // 인스턴스 변수
        private string company;
        private string color;
        private string model;
        private string price;

        // 기본 생성자
        public Car()
        {
            /*company = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";*/
        }

        // 오버로딩 (중복 정의)
        // 생성자
        public Car(string company, string color, string model, string price)
        {
            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        // 람다식 표현
        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }


        /*public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }*/

        public void showCarInfo()
        {
            Console.WriteLine("--------차량 정보--------");
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("색생 : " + color);
            Console.WriteLine("모델명 : " + model);
            Console.WriteLine("가격 : " + price);
            Console.WriteLine("대리점명 : " + DAERI);
            Console.WriteLine();
        }
    }
}
