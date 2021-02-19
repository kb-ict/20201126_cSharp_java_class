using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_munje1_mine
{
    class Class_mun1_Car
    {
        //https://blog.naver.com/hack4ork/221671058863
        //1.자동차에 대한 클래스 작성하기.

        //조건1)	속성(멤버 변수) - 대리점명은 상수 클래스변수(static 변수)로 선언.
        //조건2)	속성(멤버 변수) - 제조사, 색상, 가격, 모델명은 인스턴스 변수로 선언.
        //조건3)	기본 생성자를 만들고 아래의 속성값들을 초기화 바람.
        //        제조사 - "기아", 색상 - "블랙", 이름 - "K7"
        //        가격 - "사천만원", 대리점명 - "동대구 영업소"
        //조건4)	모든 속성들을 매개변수로 전달하여 객체를 생성할수있는 생성자 추가.
        //조건5)	모든 속성 정보들을 출력하는 인스턴스 메쏘드(함수) 추가.

        // static, const 같이 X
        public static string DAERIJUM = "동대구 영업소";
        private string company;
        private string color;
        private string price;
        private string modelName;

        public Class_mun1_Car()
        {
            company = "기아";
            color = "블랙";
            modelName = "K7";
            price = "사천만원";
        }


        public Class_mun1_Car(string company, string color, string price, string modelName)
        {
            this.company = company;
            this.color = color;
            this.price = price;
            this.modelName = modelName;
        }

        public void showCarInfo()
        {
            Console.WriteLine("제조사\t: "+ company);
            Console.WriteLine("색상\t: " + color);
            Console.WriteLine("가격\t: " + price);
            Console.WriteLine("이름\t: " + modelName);
            Console.WriteLine("대리점\t: " + DAERIJUM);
            Console.WriteLine("----------------------\n");
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }
    }
}
