
public class Class1 {

	public static void main(String[] args) {
		Student s = new Student();
		s.name = "홍길동";
		s.email = "hong@naver.com";
		s.tel = "010-1234-1123";
		System.out.println("이름 : "+s.name);
		System.out.println("이메일 : "+s.email);
		System.out.println("전화 : "+s.tel);
	}

}
class Student {
	String name;
	String tel;
	String email;
}