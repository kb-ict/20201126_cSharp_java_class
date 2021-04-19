using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            string[] tel = { "010-1234-5678", "010-4321-5678", "010-3478-1278",
                             "010-4523-1978", "010-7890-2134"};
            string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동",
                                "인천시 동구 신암4동", "광주시 동구 신암4동"};
            string[] model = { "SM6", "소나타", "산타페", "K7", "그랜저" };
            string[] color = { "블랙", "은색", "흰색", "회색", "빨강" };
            int[] year = { 2016, 2017, 2016, 2017, 2016 };
            string[] company = { "삼성르노", "현대", "현대", "기아", "현대" };
            Car[] car = new Car[10];
            Customer[] customer = new Customer[10];
            Random r = new Random();

            for(int i = 0; i<car.Length; i++)
            {
                car[i] = new Car(model[r.Next(0, 5)], color[r.Next(0, 5)], year[r.Next(0, 5)], company[r.Next(0, 5)]);
                customer[i] = new Customer(name[r.Next(0, 5)], tel[r.Next(0, 5)], address[r.Next(0, 5)]);
                car[i].showCarInfo();
                customer[i].showCustomerInfo();
            }



        }
    }
}
