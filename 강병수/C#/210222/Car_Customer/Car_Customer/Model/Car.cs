using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Customer
{
    class Car
    {
        private string model;
        private string price;
        private string color;
        private string company;
        private int serial;

        public Car(int serial, string model, string price, string color, string company)
        {
            this.serial = serial;
            this.model = model;
            this.price = price;
            this.color = color;
            this.company = company;

        }

        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public int Serial { get => serial; set => serial = value; }
    }
}
