using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 정규식
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 객체 생성 방법
#if false
            string str = "대구광역시 동구 율하동 율하휴먼시아";
            Regex regex = new Regex("율하");
            /*Match m = regex.Match(str);
            while (m.Success)
            {
                Console.WriteLine($"{m.Index} : {m.Value}");
                m = m.NextMatch();
            }*/
            var mc = regex.Matches(str);
            foreach (Match m in mc)
            {
                Console.WriteLine($"{m.Index} : {m.Value}");
            } 
#endif
            #endregion
            #region 여러가지
#if false
            string str = "대구광역시 동구 율하동 율하휴먼시아 율12하 율로하 율하";
            //string str = "서울시 강남구 역삼동 강남아파트";
            string str2 = "xpdlfmw424@co.kr.io";
            //var mc = Regex.Matches(str2, @"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");
            var mc = Regex.Matches(str, @"율하|광역시");

            foreach (Match m in mc)
            {
                Group g = m.Groups[0];
                Console.WriteLine($"{g.Index} : {g.Value}");
                //Console.WriteLine($"{m.Index} : {m.Value}");
            }  
#endif
            #endregion
            #region 그룹(전화번호)
#if false
            string str = "02-632-5432; 032-645-8454";
            Regex regex = new Regex(@"(?<areaNum>\d+)-(?<phoneNum>\d+-\d+)");
            var mc = regex.Matches(str);

            foreach (Match m in mc)
            {
                string area = m.Groups["areaNum"].Value;
                string phone = m.Groups["phoneNum"].Value;
                Console.WriteLine($"({area}) {phone}");
            }  
#endif
            #endregion
            string str = "가나다/123 바사아/456";
            Regex regex = new Regex(@"(?<korean>\w+)/(?<number>[0-9]+)");
            var mc = regex.Matches(str);

            foreach  (Match m in mc)
            {
                Console.WriteLine($"{m.Groups["korean"]}/{m.Groups["number"]}");
            }
        }
    }
}
