using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car);
            Car car2 = new Car("ASUS", "레드", "삼천만원", "RTX2060");
            Console.WriteLine(car);
            Console.WriteLine(car2);
        }
    }

    class Car
    {
        public const string Agency = "동대구 영업소";
        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private string money;
        public string Money
        {
            get { return money; }
            set { money = value; }
        }

        public Car()
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            money = "사천만원";
        }

        public Car(string company, string color, string money, string model)
        {
            this.company = company;
            this.color = color;
            this.money = money;
            this.model = model;
        }

        public override string ToString()
        {
            return $"제조사: {company}\n색상: {color}\n가격: {money}\n모델명: {model}\n";
        }
    }
}
