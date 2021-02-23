
public class Class1 {

	public static void main(String[] args) {
		Student s = new Student(); //클래스 호출과 변수 s 생성
		s.name = "고길동";
		s.Email = "sword@gmail.com";
		s.tel = "010-5025-0000";
		s.name = "둘리"; //name 변수에 덮어씌워짐
		
		System.out.println("이름: " + s.name);
		System.out.println("이메일: " + s.Email);
		System.out.println("전화번호: " + s.tel);
		System.out.println("과정: " + Student.category);
		
		Student ss = new Student(); //s 변수와 다른 ss 변수 생성
		ss.name = "또치";
		ss.Email = "duck@gmail.com";
		ss.tel = "010-1234-5678";
		
		System.out.println("이름: " + ss.name);
		System.out.println("이메일: "+ ss.Email);
		System.out.println("전화번호: " + ss.tel);
		System.out.println("과정: " + Student.category);

	}

}
// 주소록 클래스 정의
class Student {
	static String category = "통합응용SW과정"; //클래스 변수

	//인스턴스 변수
	String name;
	String tel;
	String Email;
}