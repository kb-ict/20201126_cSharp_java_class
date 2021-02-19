package class0106_2;

public class Main {

	public static void main(String[] args) {
		Student s = new Student();
		s.setName("홍길동");
		s.setTel("000-1234-1234");
		s.setEmail("hgd@naver.com");
		s.showStudentInfo();
		
		
		Student s2 = new Student();
		s2.setName("최길동");
		s2.setTel("000-2234-2234");
		s2.setEmail("Choigd@naver.com");
		s2.showStudentInfo();
	}
}
