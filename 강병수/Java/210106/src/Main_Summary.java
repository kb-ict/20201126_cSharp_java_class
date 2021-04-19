
public class Main_Summary {

	public static void main(String[] args) {
		Student_Summary s = new Student_Summary();
		s.setName("홍길동");
		s.setTel("010-1234-4321");
		s.setEmail("hong@gmail.com");
		s.ShowStudentInfo();
		
		Student_Summary s2 = new Student_Summary();
		s2.setName("최길동");
		s2.setTel("010-8332-1351");
		s2.setEmail("choi@gmail.com");
		s2.ShowStudentInfo();
		
		Student_Summary s3 = new Student_Summary();
		s3.setName("김길동");
		s3.setTel("010-2345-6537");
		s3.setEmail("kim@gmail.com");
		s3.ShowStudentInfo();
		
	}

}
