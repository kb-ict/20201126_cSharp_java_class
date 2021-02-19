using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            string[] tel = { "010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7890-2134" };
            string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
            string[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
            string[] color = { "블랙", "은색", "흰색", "회색", "빨강" };
            string[] company = { "삼성르노", "현대", "기아", "BMW", "아우디" };

            Customer[] customers = new Customer[10];
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Customer(name[r.Next(0, 5)], tel[r.Next(0, 5)], address[r.Next(0, 5)], new Car(model[r.Next(0, 5)], color[r.Next(0, 5)], r.Next(2010, 2021), company[r.Next(0, 5)]));
                customers[i].printCustomerInfo();
            }
        }
    }
}
