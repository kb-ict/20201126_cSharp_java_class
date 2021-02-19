using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_5
{
    class Lecture
    {
        private string language;
        private string lecture1;
        private string lecture2;

        protected string Language { get => language; set => language = value; }
        protected string Lecture1 { get => lecture1; set => lecture1 = value; }
        protected string Lecture2 { get => lecture2; set => lecture2 = value; }
    }
}
