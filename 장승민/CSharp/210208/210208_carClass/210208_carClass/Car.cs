using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210208_carClass
{
    class Car
    {
        public const string STORE = "동대구 영업소";
        private string maker;
        private string color;
        private string model;
        private string price;

        public Car()
        {
            maker = "기아";
            color = "블랙";
            model = "K7";
            price = "사천만원";
        }
        public Car(string maker, string color, string model, string price)
        {
            this.maker = maker;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public string Maker { get => maker; set => maker = value; }
        public string Color { get => color; set => color = value; }
        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }



        /* public string Maker
         {
             get { return maker; }
             set { maker = value; }
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
            Console.WriteLine("제조사: " + maker);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("이름: " + model);
            Console.WriteLine("가격: " + price);
            Console.WriteLine(STORE);
            Console.WriteLine("=================");
        }

    }
}
