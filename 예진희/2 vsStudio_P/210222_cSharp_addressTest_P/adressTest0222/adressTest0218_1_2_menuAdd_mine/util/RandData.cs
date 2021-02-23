using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218.util
{
    class RandData
    {
        static string[] name = { "홍길동", "김길동", "이길동", "박길동", "최길동" }; //readonly, 객체 생성여러번 돼도 한번만 생성관리
        static string[] tel = { "010-1111-1111", "010-2222-2222", "010-2222-3333", "010-2222-4444", "010-2222-5555" };
        static string[] address = { "대구시 동구 신암동", "광주시 동구 신암동", "서울시 동구 신암동", "대전시 동구 신암동", "부산시 동구 신암동" };
        static string[] email = { "hong@naver.com", "kim@naver.com", "lee@naver.com", "park@naver.com", "choi@naver.com" };
        Random r;

        public RandData(Random r) // 많이 씀, 싱글톤, getter-setter
        {
            this.r = r;
        }

        public string getName()
        {
            return name[r.Next(0, name.Length)];
        }

        public string getTel()
        {
            return tel[r.Next(0, 5)];
        }

        public string getAddr()
        {
            return address[r.Next(0, 5)];
        }

        public string getEmail()
        {
            return email[r.Next(0, 5)];
        }

        public string getId()
        {
            string rdata =
                /*"abcdefghijklmnopqrstuvwxyz" +*/
                "0123456789"/* +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "~!@#$%^&*?"*/;
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            //Console.WriteLine("id: " + rs.ToString());
            return rs.ToString();
        }
    }
}
