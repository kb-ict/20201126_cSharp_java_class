package class_20210106_1;

public class Main {

	public static void main(String[] args) {

		Student s = new Student();
		s.setName("홍길동");
		s.setTel("010-1234-5678");
		s.setEmail("hong@naver.com");
		s.showStudentInfo();
		
		Student ss = new Student();
		ss.setName("최길동");
		ss.setTel("010-8765-4321");
		ss.setEmail("choi@naver.com");
		ss.showStudentInfo();
		
	}

}
