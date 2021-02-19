using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_4
{
    class NameData
    {
        private string fullName;

        public NameData(string first, string mid, string last)
        {
            fullName = first + mid + last;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

    }
}
