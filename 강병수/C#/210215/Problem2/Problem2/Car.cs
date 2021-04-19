using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Car
    {
        private string model;
        private string color;
        private int year;
        private string company;

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }

        public Car(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public void showCarInfo()
        {
            Console.WriteLine("모델: " + model);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("연도: " + year);
            Console.WriteLine("회사: " + company);
        }
    }
}
