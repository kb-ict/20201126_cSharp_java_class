
public class ClassYeje1 { //바로접근 하는 경우
	public static void main(String[] args) {
		//학생 정보관리
		//클래스의 객체 생성, heap공간 사용 프로그램 종료해도 값 살아있음
		Student s = new Student(); // == int a = 10;(stack공간 프로그램 종료시 날아감)
	//--타입---변수명=/ ------------ /생성자 constructure, /~/ : 객체 생성하는 역할
		//ex: int num, 
		//타입으로 간주 : 리턴, 매개변수로 전달, 배열처럼 쓸 수있음
		
		//---> 객체 or '인스턴스' 생성
		// 자바가 메모리에 임의 할당, s변수가 객체를 가리킴
		
		s.name = "홍길동";
		s.email = "idid@example.com";
		s.tel = "000-0000-0000";
		s.name = "김길동"; //변경
		//s.을 통해 객체 인스턴수 변수에 입력
		
		System.out.println("이름\t: "+s.name);
		System.out.println("이메일\t: "+s.email);
		System.out.println("전화\t: "+s.tel);				// 생성객체 참조
		System.out.println("과정\t: "+Student.category+"\n");	// 클래스 이름으로 접근
		
		// Student s != Student ss 변수가 생성개체를 마킹함, new로 생성된 객체는 각각 다름.
		Student ss = new Student();
		ss.name = "최길동";
		ss.email = "Chidid@example.com";
		ss.tel = "000-0000-0001";
		System.out.println("이름\t: "+ss.name);
		System.out.println("이메일\t: "+ss.email);
		System.out.println("전화\t: "+ss.tel);
		System.out.println("과정\t: "+Student.category);
		
	}
}


// 주소록 클래스 정의 / 메소드 = 호출, 클래스는 객체생성
// 클래스 생성 = 클래스 밖에서 선언
class Student {
	// 객체와 다른 메모리공간 사용, 클래스 이름으로 static변수에 접근
	// category는 1번만 만들어짐
	// static 변수 = 클래스 변수, 공용사용위함,	ex) static main class 1번만
	static String category = "통합응용SW과정";
	
	
	// object 대상, 공통특징
	// 특징(필요한것)만 뽑아내는 것 = 추상화 abstract
	// 객체로 접근 -> 특징을 변수로 선언
	String name;
	String tel;
	String email;	//-> 인스턴스 변수: 클래스 안에 선언된 변수
}

// OOP, Object Oriented Program 