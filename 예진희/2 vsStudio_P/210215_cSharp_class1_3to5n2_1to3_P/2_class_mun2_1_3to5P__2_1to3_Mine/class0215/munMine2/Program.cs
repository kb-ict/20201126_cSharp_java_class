using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munMine2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.학생관리 프로그램을 위한 학생(Student) 클래스 설계.

            //조건01) 프로젝트를 생성할때 패키지명을 com.(회사명 또는 본인 이니셜).앱이름으로 생성.
            //조건02) 학생 클래스, main()를 포함하는 클래스 2개 사용. (java파일 총 2개 생성)
            //조건03) 클래스의 속성은 이름, 나이, 성별, 주소를 선언하고 다른 클래스에서 접근을 차단함.
            //       -속성의 데이터 타입은 아래의 조건7을 참고 바람.
            //조건04) 매개변수 이름, 나이, 성별, 주소를 사용하는 생성자 추가.
            //조건05) 속성에 대한 getter / setter 멤버 메쏘드 추가.
            //조건06) 모든 속성 정보를 출력하는 showStudentInfo() 멤버 메쏘드 추가.
            //조건07) main()에서 다음의 학생 정보 배열 초기화.

            //String[] name = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
            //int[] age = {20, 25, 30, 35, 40};
            //char[] gender = { '남', '여' };
            //String[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};

            //조건08) main()에서 10명의 학생 정보를 저장할수있는 Student 객체 생성.
            //조건09) 이름, 나이, 성별, 주소 정보들을 랜덤하게 가져와 생성자 매개변수로 전달하기.
            //조건10) 10명의 학생정보가 생성되었으면 showStudentInfo()를 통해서 모두 출력하기.
            //       -출력 형태는 깔끔하게 정리하여 보여주기.
            //조건11) 10번째 학생의 정보를 아래의 정보로 변경하기.
            // "전우치", 24, '남', "조선 한양인근 두메산골"
            //조건12) 조건11 에서 설정한 정보들을 showStudentInfo() 를 통해서 출력.
            Random r = new Random();
            string line = "----------------";
            Console.WriteLine($"\n{line} 객체 지향 클래스 2번째 {line}");
            Console.WriteLine($"\n{line} 문제2-1 {line}");

            String[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            String[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };

            Student2_1mine[] st1 = new Student2_1mine[10];
            for (int i = 0; i < st1.Length; i++)
            {
                Console.WriteLine($"{line} {i + 1}번째 학생 {line}");
                st1[i] = new Student2_1mine();
                st1[i].set2_1mine(name[r.Next(0, 5)], age[r.Next(0, 5)], gender[r.Next(0, 2)], address[r.Next(0, 5)]);
                st1[i].showStudentInfo();
            }

            Console.WriteLine("\n\n");
            st1[9].set2_1mine("전우치", 24, '남', "조선 한양인근 두메산골");
            for (int i = 7; i < st1.Length; i++)
            {
                Console.WriteLine($"{line} {i + 1}번째 학생 {line}");
                st1[i].showStudentInfo();
            }

            //2.고객 차량 관리 프로그램을 위한 클래스 설계. (3개의 클래스가 사용되니 조건을 상세하게 확인!)

            //조건01) 프로젝트를 생성할때 패키지명을 com.회사명 또는 본인 이니셜.carApp 으로 설정하고
            //       클래스명은 CarAppMain 으로 생성. (main() 메쏘드가 존재함)
            //조건02) 프로젝트에 새로운 패키지 com.회사명 또는 이니셜.carApp.car 를 만들고 클래스 Car를 생성 추가.
            //조건03) Car 클래스에 멤버변수 모델명, 색상, 연식, 제조사를 생성하고 접근 차단.
            //       - 속성 타입은 조건12 참고.
            //조건04) 속성 정보들을 설정하는 매개 변수를 가지는 생성자 추가.
            //조건05) Car 클래스 속성들을 위한 getter / setter 추가.
            //조건06) 모든 속성 정보들을 출력하는 메쏘드 printCarInfo() 작성.
            //조건07) 새로운 패키지 com.회사명 또는 이니셜.carApp.customer 를 만들고 클래스 Customer 추가.
            //조건08) 고객 클래스에 고객명, 전화번호, 주소, Car 클래스 속성들을 생성하고 접근 차단.
            //조건09) 속성 정보들을 설정하는 매개변수를 가지는 Customer 생성자 추가.
            //조건10) 고객 속성에 대해서 getter/ setter 생성.
            //조건11) 고객정보와 차량정보를 출력하는 printCustomerInfo() 추가.
            //조건12) main() 에서 다음의 정보들을 이용하여 객체를 생성하시오.

            //String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
            //String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278","010-4523-1978", "010-7890-2134"};
            //String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
            //String model[] = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
            //String color[] = { "블랙", "은색", "흰색", "회색", "빨강" };
            //int year[] = { 2016, 2017, 2016, 2017, 2016 };
            //String company[] = { "삼성르노", "현대", "현대", "기아", "현대" };

            //조건13) main()에서 10명의 고객정보를 위한 객체 생성.
            //조건14) 생성한 객체에 조건12의 정보들을 랜덤하게 설정한후 printCustomerInfo()로
            //        모든 고객정보와 구매한 차량정보를 출력.

            Console.WriteLine($"\n\n{line} 문제2-2 {line}");

            //조건12) main() 에서 다음의 정보들을 이용하여 객체를 생성하시오.
            String[] name2 = { "2홍길동", "2김길동", "2박길동", "2이길동", "2최길동" };
            String[] tel2 = { "010-1234-5678", "010-4321-5678", "010-3478-1278", "010-4523-1978", "010-7890-2134" };
            String[] address2 = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };

            String[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
            String[] color = { "블랙", "은색", "흰색", "회색", "빨강" };
            int[] year = { 2016, 2017, 2016, 2017, 2016 };
            String[] company = { "삼성르노", "현대", "현대", "기아", "현대" };

            //조건13) main()에서 10명의 고객정보를 위한 객체 생성.
            CarCustomer2_2mine[] c2_2 = new CarCustomer2_2mine[10];
            for (int i = 0; i < c2_2.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 고객 ----------------");
                c2_2[i] = new CarCustomer2_2mine();
                //name2[r.Next(0, 5)] //0~4까지 랜덤숫자***
                //name2[r];
                //Console.WriteLine(name2[r.Next(0, 5)]);
                //Console.WriteLine(name2[r]);

                //c2_2[i].CarCustomerSetInfo(~, new Car2_2mine().carSetInfo(model[r.Next(0, 5)], color[r.Next(0, 5)], year[r.Next(0, 5)], company[r.Next(0, 5)]));
                // 객체로 해야돼서 안됨.. ★

                c2_2[i].CarCustomerSetInfo(name2[r.Next(0, 5)], tel2[r.Next(0, 5)], address2[r.Next(0, 5)],
                    new Car2_2mine(model[r.Next(0, 5)], color[r.Next(0, 5)], year[r.Next(0, 5)], company[r.Next(0, 5)]));

                c2_2[i].printCustomerInfo();
            }
            // new Car2_2mine(model[r.Next(0, 5)], color[r.Next(0, 5)], year[r.Next(0, 5)], company[r.Next(0, 5)])
            //_ 출시전 debug(디버깅 정보), 출시 : release(디버깅 뺀거), 용량 少



            Console.WriteLine($"\n\n{line} 문제2-3 싱글톤 {line}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(SingleTest2_3mine.getInstance().getData());
            }

            //3.싱글톤 - 실무에서 많이 사용하는 기본 디자인 패턴이므로 반드시 이해하기.

            //조건1) main() 에서 SingleTest 클래스 객체를 2개 생성해서 getData()로 값을 확인.
            //조건2) getInstance()를 2개 이상 사용해서 getData()로 값 확인.

            //System.out.println(SingleTest.getInstance().getData());

            //예제 코드)
            //class SingleTest
            //{
            //    private static SingleTest inst;
            //    private int data;

            //    SingleTest()
            //    {
            //        data = (int)(Math.random() * 100);
            //    }

            //    public static SingleTest getInstance()
            //    {
            //        if (inst == null)
            //        {
            //            inst = new SingleTest();
            //        }
            //        return inst;
            //    }

            //    public int getData()
            //    {
            //        return data;
            //    }
            //}
        }
    }
}
