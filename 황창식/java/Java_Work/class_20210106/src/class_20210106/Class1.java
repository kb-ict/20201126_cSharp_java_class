package class_20210106;

public class Class1 {
	public static void main(String[] args) {
		Student s = new Student();
		s.name = "홍길동";
		s.email = "hong@gmail.com";
		s.tel = "010-1234-5678";
				
		System.out.println("이름 : " + s.name);
		System.out.println("이메일 : " + s.email);
		System.out.println("전화번호 : " + s.tel);
		// 클래스 변수는 클래스 이름만으로 접근 가능
		System.out.println("과정 : " + Student.category);
		System.out.println("----------------------");
		
		Student ss = new Student();
		ss.name = "최길동";
		ss.email = "choi@gmail.com";
		ss.tel = "010-8765-4321";
		
		System.out.println("이름 : " + ss.name);
		System.out.println("이메일 : " + ss.email);
		System.out.println("전화번호 : " + ss.tel);
		System.out.println("과정 : " + Student.category);
		System.out.println("----------------------");
		
	}

}

// 주소록 클래스 정의
class Student {
	// 추상화(Abstraction)
	
	// 클래스 변수 (인스턴스에 상관없이 하나의 값을 가지는 변수)
	static String category = "통합 응용 SW 과정";
	
	// 인스턴스 변수
	String name;
	String tel;
	String email;
	
}
