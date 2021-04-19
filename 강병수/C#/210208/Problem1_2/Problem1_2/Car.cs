using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_2
{
    class Car
    {

        // 클래스 상수 변수
        const string STORE = "동대구점";

        // 이하 4개 인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;



        // 기본 생성자
        public Car()
        {
            company = "기아";
            color = "블랙";
            price = "사천만원";
            model = "K7";
        }

        // 생성자 오버로딩
        public Car(string company, string color, string price, string model)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.model = model;
        }
        // 람다식
        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        public void printCarInfo()
        {
            Console.WriteLine("대리점: " + STORE);
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("가격: " + price);
            Console.WriteLine("모델명: " + model);
        }


    }
}
