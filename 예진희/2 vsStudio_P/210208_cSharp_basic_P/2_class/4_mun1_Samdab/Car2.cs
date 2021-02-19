using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_mun1_Samdab
{
    class Car2
    {
        // 클래스 상수변수
        public const string DAERI = "동대구 영업소";
        private string company;
        private string color;
        private string price;
        private string model;

        // 기본생성자
        public Car2()
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
        }

        public Car2(string company, string color, string price, string model)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.model = model;
        }


        // 람다식(익명메소드), 객체지향(무거움) x
        public string Company { get => company; set => company = value; }
        /*
         public string Company
        {
            get { return company; }
            set { company = value; }
        }
         */

        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        public void showCarInfo()
        {
            Console.WriteLine("제조사\t:" + company);
            Console.WriteLine("색상\t:" + color);
            Console.WriteLine("모델\t:" + model);
            Console.WriteLine("가격\t:" + price);
            Console.WriteLine("영업소\t:" + DAERI);
            Console.WriteLine("------------------------\n");
        }
    }
}

