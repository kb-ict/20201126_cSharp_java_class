using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_mun1_Samdab
{
    class Car
    {   // 클래스 상수변수
        public const string DAERI = "동대구 영업소";
        // public: 완전공용 , const : static개념+
        // const string DAERI = "동대구 영업소";

        // 인스턴스 변수 (변수추려내는 거 - 추상화)
        private string company;
        private string color;
        private string price;
        private string model;

        // 기본생성자
        public Car()
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
        }

        // 매개변수가 있는 생성자
        // 생성자 오버로딩
         public Car(string company, string color, string model, string price)
        {
            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }


        public string Company
        {
            get { return company; }
            set { company = value; }
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
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public void showCarInfo()
        {
            Console.WriteLine("제조사\t:"+company);
            Console.WriteLine("색상\t:"+color);
            Console.WriteLine("모델\t:"+model);
            Console.WriteLine("가격\t:"+price);
            Console.WriteLine("영업소\t:" + DAERI);
            Console.WriteLine("------------------------\n");
        }
    }
}
