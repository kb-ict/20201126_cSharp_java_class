using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munMine2
{
    class Car2_2mine
    {
        private string model;
        private string color;
        private int year;
        private string company;

        public Car2_2mine()
        {
        }
        public Car2_2mine(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public void carSetInfo(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public void printCarInfo()
        {
            Console.WriteLine($"- 모델명\t:{model}");
            Console.WriteLine($"- 색상\t\t:{color}");
            Console.WriteLine($"- 연식\t\t:{year}");
            Console.WriteLine($"- 제조사\t:{company}");
            Console.WriteLine("-------------------------");
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }

    }
}
