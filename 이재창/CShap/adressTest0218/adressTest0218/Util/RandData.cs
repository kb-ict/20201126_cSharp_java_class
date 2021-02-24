using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressTest0218
{
    /// <summary>
    /// 랜덤 데이터를 사용 가능한 클래스
    /// </summary>
    public static class RandData
    {
        static string[] name =
                {"홍길동", "김길동",
                "이길동", "박길동", "최길동"};
        static string[] tel = {"010-1111-1111",
                "010-2222-2222", "010-2222-3333",
                "010-2222-4444", "010-2222-5555"};
        static string[] address = {"대구시 동구 신암동",
                "광주시 동구 신암동", "서울시 동구 신암동",
                "대전시 동구 신암동", "부산시 동구 신암동"};
        static string[] email = {"hong@naver.com",
                "kim@naver.com", "lee@naver.com",
                "park@naver.com", "choi@naver.com"};
        static Random r;

        static RandData()
        {
            r = new Random();
        }

        public static string GetName()
        {
            return name[r.Next(0, 5)];
        }
        public static string GetTel()
        {
            return tel[r.Next(0, 5)];
        }
        public static string GetAddress()
        {
            return address[r.Next(0, 5)];
        }
        public static string GetEmail()
        {
            return email[r.Next(0, 5)];
        }

        public static string GetId()
        {
            string rdata =
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "ABCDEFGHIJKLMNPQRSTUVWXYZ" +
                "~!@#$%^&*?";
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }

            return rs.ToString();
        }
    }
}
