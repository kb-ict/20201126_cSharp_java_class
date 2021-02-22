using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Company { get; set; }

        public Car(string model, string color, int year, string company)
        {
            Model = model;
            Color = color;
            Year = year;
            Company = company;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"모델명: {Model}");
            Console.WriteLine($"색상: {Color}");
            Console.WriteLine($"연식: {Year}");
            Console.WriteLine($"제조사: {Company}");
            Console.WriteLine();
        }
    }
}
