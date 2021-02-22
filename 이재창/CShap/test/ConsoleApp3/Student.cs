using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        private static int count;
        private string name;
        private bool fronted;
        private int sex;
        private int seatnum;

        public static int Count
        {
            get { return count; }
            set { count = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool Fronted
        {
            get { return fronted; }
            set { fronted = value; }
        }
        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public int SeatNum
        {
            get { return seatnum; }
            set { seatnum = value; }
        }

        public Student(string name, int sex, bool fronted)
        {
            Name = name;
            Sex = sex;
            Fronted = fronted;
        }

        // 자리배치 함수
        public static void SeatAllocate(Student[] students)
        {            
            int[] seatNums = new int[Student.Count];

            for (int i = 0; i < seatNums.Length; i++)
            {
                seatNums[i] = i + 1;
            }

            Random rand = new Random();

            while (true)
            {
                bool reset = false;

                for (int i = 0; i < seatNums.Length; i++)
                {
                    int rPos = rand.Next(1, seatNums.Length);
                    int temp = seatNums[i];
                    seatNums[i] = seatNums[rPos];
                    seatNums[rPos] = temp;
                }

                for (int i = 0; i < students.Length; i++)
                {
                    students[i].SeatNum = seatNums[i];
                }

                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i].Fronted && students[i].SeatNum > 4)
                    {
                        reset = true;
                        break;
                    }
                }
                if (!reset)
                {
                    break;
                }
            }
        }
    }
}
