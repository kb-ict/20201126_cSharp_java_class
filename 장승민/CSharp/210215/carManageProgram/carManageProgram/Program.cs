using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carManageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] name = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
            String[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            String[] address = { "대구시 동구 신암4동", "원주시 동구 신암4동", "인천시 동구 신암4동", "부산시 동구 신암4동", "서울시 동구 신암4동" };
            String[] model = { "SM6", "코나", "GV80", "G70", "쏘렌토" };
            String[] color = { "은색", "블랙", "화이트", "빨강", "파랑" };
            int[] year = { 2016, 2017, 2018, 2019, 2020 };
            String[] company = { "현대", "기아", "르노삼성", "BMW", "벤츠" };

            Random rd = new Random();
            Car[] car = new Car[10];
            Customer[] cs = new Customer[10];
            for (int i = 0; i < car.Length; i++)
            {
                car[i] = new Car(model[rd.Next(0, 4)], color[rd.Next(0, 4)], year[rd.Next(0, 4)], company[rd.Next(0, 4)]) ;
            }
            for (int i = 0; i < cs.Length; i++)
            {
                cs[i] = new Customer(name[rd.Next(0, 4)], tel[rd.Next(0, 4)], address[rd.Next(0, 4)], car[i]);
            }
            for (int i = 0; i < cs.Length; i++)
            {
                cs[i].printCustomerInfo();
            }

        }
    }
}
