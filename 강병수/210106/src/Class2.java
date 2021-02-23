
public class Class2 {

	public static void main(String[] args) {
		Student_Class2 s = new Student_Class2();
		s.setName("고길동");
		s.setEmail("sword@gmail.com");
		s.setTel("010-5025-0000");
		s.setName("둘리");

		System.out.println("이름: " + s.getName());
		System.out.println("이메일: " + s.getEmail());
		System.out.println("전화번호: " + s.getTel());
		System.out.println("과정: " + Student_Class2.category);

		Student_Class2 ss = new Student_Class2();
		ss.setName("또치");
		ss.setEmail("duck@gmail.com");
		ss.setTel("010-1234-5678");

		System.out.println("이름: " + ss.getName());
		System.out.println("이메일: " + ss.getEmail());
		System.out.println("전화번호: " + ss.getTel());
		System.out.println("과정: " + Student_Class2.category);
		
		//익명 객체(변수 선언을 하지않음)
		new Student_Class2().setName("마이콜");
		System.out.println(new Student_Class2().getName());
	}

}