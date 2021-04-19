using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Util
{
    class RandomData
    {
        static string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동"};
        static string[] tel = { "010-1234-5678", "010-4321-5678", "010-3478-1278",
                             "010-4523-1978", "010-7890-2134"};
        static string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동",
                                "인천시 동구 신암4동", "광주시 동구 신암4동"};
        static string[] email = { "hong@gmail.com", "kim@gmail.com", "park@gmail.com", "lee@gmail.com", "choi@naver.com"};

        Random r;

        public RandomData(Random r)
        {
            this.r = r;
        }

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public string getTel()
        {
            return tel[r.Next(0, 5)];
        }

        public string getAddress()
        {
            return email[r.Next(0, 5)];
        }

        public string getEmail()
        {
            return email[r.Next(0, 5)];

        }

        public string getRandomID()
        {
            string rdata = "abcdefghijklmnopqrstuvwxyyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            return rs.ToString();
        }
    }
}
