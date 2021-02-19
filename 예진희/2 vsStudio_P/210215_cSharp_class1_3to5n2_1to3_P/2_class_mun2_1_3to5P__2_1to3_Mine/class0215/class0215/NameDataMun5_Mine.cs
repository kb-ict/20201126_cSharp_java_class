using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0215
{
    class NameDataMun5_Mine
    {
        //조건1) 풀네임을 저장하는 속성 추가.
        //조건2) 랜덤하게 풀네임을 만들어 반환하는 메쏘드 추가.
        private string first;
        private string mid;
        private string last;
        private string fullName;

        public NameDataMun5_Mine()
        {
        }
        public void setName(string first, string mid, string last)
        {
            this.first = first;
            this.mid = mid;
            this.last = last;
        }

        public string makeName()
        {
            fullName = first + mid + last;
            return fullName;
        }
    }
}
