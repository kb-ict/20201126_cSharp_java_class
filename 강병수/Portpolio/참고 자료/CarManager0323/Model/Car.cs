using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Car
    {
        string model;
        string year;
        string price;
        string color;

        public Car(string model, string year, string price, string color)
        {
            this.model = model;
            this.year = year;
            this.price = price;
            this.color = color;
        }

        public string Model { get => model; set => model = value; }
        public string Year { get => year; set => year = value; }
        public string Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
    }
}
