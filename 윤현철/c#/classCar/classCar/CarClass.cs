using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCar
{
    class CarClass
    {
        public const string CLASS = "동대구 영업소";
        private string company;
        private string color;
        private string model;
        private string price;
        
        public CarClass(string company, string color, string model, string price)
        {
            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }


        /* public string Company
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
        public void printCarInfo()
        {
            Console.WriteLine("제조사   : "+Company);
            Console.WriteLine("색상     : "+Color);
            Console.WriteLine("이름     : "+Model);
            Console.WriteLine("가격     : "+Price);
            Console.WriteLine("대리점명 : "+CarClass.CLASS);
            Console.WriteLine("---------------------------------------------");
        }
    }
}
