using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_munje1_mine
{
    class Class_mun5
    {
        private string fullName;
        //5. 랜덤하게 이름을 생성하는 NameData 클래스 작성.

        //first[]   = {"김", "박", "이", "최", "장"};
        //mid[]     = {"가", "나", "다", "라", "마"};
        //last[]    = {"바", "사", "아", "자", "차"};

        //조건1) 풀네임을 저장하는 속성 추가.
        //조건2) 랜덤하게 풀네임을 만들어 반환하는 메쏘드 추가.

        public Class_mun5(string first, string mid, string last)
        {
            fullName = first + mid + last;
            Console.WriteLine(fullName);
        }

        
}
}
