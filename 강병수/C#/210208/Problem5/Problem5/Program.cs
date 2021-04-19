using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            NameData name = new NameData();
            //name.makeName();
            //name.showName();
        }


    }


    // 기본 생성자에서 초기화
    class NameData
    {
        private string[] first = { "김", "박", "이", "최", "장" };
        private string[] mid = { "가", "나", "다", "라", "마" };
        private string[] last = { "바", "사", "아", "자", "차" };
        // 풀네임을 저장하는 속성 추가
        private string[] fullName = new string[50];

        public NameData()
        {
            makeName();
            showName();
        }


        Random r = new Random();

        // 풀네임을 랜덤하게 50개를 만드는 메소드 추가
        public void makeName()
        {
            for (int i = 0; i < fullName.Length; i++)
            {
                fullName[i] = first[r.Next(0, 5)] + mid[r.Next(0, 5)] + last[r.Next(0, 5)];
            }
        }

        // 풀네임을 출력하는 메소드 추가
        public void showName()
        {
            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine(fullName[i]); ;
            }
        }
    }
}
