package class_210106;

public class Class2 {

	public static void main(String[] args) {
		Student2 s = new Student2();
		s.setName("장승민");
		s.setEmail("jsm6066@gmai.com");
		s.setTel("010 2353 4220");

		System.out.println(s.getEmail());
		System.out.println(s.getName());
		System.out.println(s.getTel());
		System.out.println("과정 :" + Student2.category);

		Student2 ss = new Student2();
		ss.setName("최길동");
		ss.setEmail("jsm4220@gmai.com");
		ss.setTel("010 5714 6066");

		System.out.println(ss.getEmail());
		System.out.println(ss.getName());
		System.out.println(ss.getTel());

		// 익명 개체
		new Student2().setName("이길동");
		System.out.println(new Student2().getName());
	}
}
