using System;
using System.Text;

namespace Class_practice_20210218.util
{
    class RandData
    {
        private string[] lastName = { "김", "이", "박", "최", "강" };
        private string[] firstName1 = { "춘", "덕", "광", "미", "용" };
        private string[] firstName2 = { "삼", "배", "자", "국", "봉", "심", "숙", "식" };
        private string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
        private string[] emailId = { "hong", "kim", "park", "choi", "kang", "lee" };
        private string[] emailadd = { "@naver.com", "@gmail.com", "@hanmail.net" };

        Random r;
        
        public RandData(Random r)
        {
            this.r = r;
        }
        
        public string getName()
        {
            return lastName[r.Next(0, lastName.Length)] + firstName1[r.Next(0, firstName1.Length)] + firstName2[r.Next(0, firstName2.Length)];
        }

        public string getTel()
        {
            return "010 - " + Convert.ToString(r.Next(1000, 10000)) + " - " + Convert.ToString(r.Next(1000, 10000));
        }

        public string getAddress()
        {
            return address[r.Next(0, address.Length)];
        }

        public string getEmail()
        {
            return emailId[r.Next(0, emailId.Length)] + emailadd[r.Next(0, emailadd.Length)];
        }

        public string getId()
        {
            string rdata = "abcdefghijklmnopqrstuvwxyz" + "ABCDEFGHIJKLMNPQRSTUVWXYZ" + "0123456789" + "~!@#$%^&*?";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(rdata[(int)(r.NextDouble() * rdata.Length)]);
            }
            return sb.ToString();
        }
    }
}
