package class_20210106;

public class Class2 {
	public static void main(String[] args) {

		Student2 s = new Student2();
		s.setName("홍길동");
		s.setEmail("hong@gmail.com");
		s.setTel("010-1234-5678");
				
		System.out.println("이름 : " + s.getName());
		System.out.println("이메일 : " + s.getEmail());
		System.out.println("전화번호 : " + s.getTel());
		System.out.println("과정 : " + Student2.category);
		System.out.println("----------------------");
		
		Student2 ss = new Student2();
		ss.setName("최길동");
		ss.setEmail("choi@gmail.com");
		ss.setTel("010-8765-4321");
		
		System.out.println("이름 : " + ss.getName());
		System.out.println("이메일 : " + ss.getEmail());
		System.out.println("전화번호 : " + ss.getTel());
		System.out.println("과정 : " + Student2.category);
		System.out.println("----------------------");
		
		// 익명 객체 : 일반 객체와 다르게 객체를 나타내는 변수가 없다.
		// 매개변수 전달용
		new Student2().setName("이길동");
		// 변수에 다시 접근할 방법이 없음
		System.out.println(new Student2().getName());
		
	}

}

//class Student2 {
//	static String category = "통합 응용 SW 과정";
//	// 캡슐화(정보 은닉) : 변수가 선언된 클래스 내에서만 변수에 접근 가능
//		
//	// public : 외부 클래스에서 접근 가능
//	// private : 외부 클래스에서 접근 불가
//	private String name;
//	private String tel;
//	private String email;
//	
//	// 인스턴스 메쏘드
//	// getter : 값을 가져오는 메쏘드
//	public String getName() {
//		return name;
//	}
//	// setter : 값을 설정하는 메쏘드
//	public void setName(String name) {
//		// 인스턴스 변수에만 this 가능
//		this.name = name;
//	}
//	public String getTel() {
//		return tel;
//	}
//	public void setTel(String tel) {
//		this.tel = tel;
//	}
//	public String getEmail() {
//		return email;
//	}
//	public void setEmail(String email) {
//		this.email = email;
//	}
//	
//		 
//}
