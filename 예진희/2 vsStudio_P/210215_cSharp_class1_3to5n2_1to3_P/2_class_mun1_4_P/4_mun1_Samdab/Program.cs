using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_mun1_Samdab
{
    class Program
    {
        static void Main(string[] args)
        {   // 메소드는 호출, 클래스는 인스턴스 생성(객체생성), 메모리공간 : heap에 생성
            // 생성객체는 가비지컬렉터가 관리(객체지향 언어)

            //_ [메소드]* - [heap]** - [stack]*** / 메소드* : static변수, const, / heap** ↓ : 객체생성시 잡힘 / stack*** ↑ :일반메소드
            //_ 기존   : []-[data]-[heap]-[stack]
            //_ 클래스 : 사용자 정의 타입
            Car2 c = new Car2(); //_ 선언된 곳으로 이동 : f12
            c.Model = "그랑쉘";
            c.Company = "청우";
            c.Color = "노란색";
            c.Price = "3천5백만";
            c.showCarInfo();


            //new Car().showCarInfo(); //_ 마킹변수(위치정보)가 없어 재사용 불가능
            //new Car().showCarInfo(); //_ new로 생성된 인스턴스 다 다른거
            //_ 싱글톤 : 만든객체 재사용(로그인)

            Car c2 = new Car("현대", "흰색", "G80", "6천만원");
            c2.showCarInfo();

            // 입력 처리
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            Console.WriteLine($"이름 : {name}");

            Console.Write("나이 입력: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"나이 : {age}");
        }
    }
}
