
public class ClassYeje2_1 {
	public static void main(String[] args) {
		// 객체지향 설계
		// 1. 캡슐화 (변수를 노출x : 정보은닉, overloading, override)
		// 정보 바로접근 안맞음
		
		
		Student2 s = new Student2();
		s.setName("홍길동");
		s.setEmail("idid@example.com");
		s.setTel("000-0000-0000");
		
		System.out.println("이름\t: "		+s.getName());
		System.out.println("이메일\t: "	+s.getEmail());
		System.out.println("전화\t: "		+s.getTel());		
		System.out.println("과정\t: "		+Student.category+"\n");	
		
		Student2 ss = new Student2();
		
		ss.setName("최길동");
		ss.setEmail("Chidid@example.com");
		ss.setTel("000-0000-0001");
		
		System.out.println("이름\t: "		+ss.getName());
		System.out.println("이메일\t: "	+ss.getEmail());
		System.out.println("전화\t: "		+ss.getTel());
		System.out.println("과정\t: "		+Student.category);
		
	}
}


/*
// 주소록 클래스 정의
class Student2 {
	// 클래스 변수
	static String category = "통합응용SW과정";
	// private	: 외부 클래스에서 접근 불가 /x 클래스 안에서만 접근가능, 캡슐화(정보를 외부로노출 x, 감싼다)
	// public	: 외부 클래스에서 접근 가능
	// 인스턴스 변수
	private String name;
	private String tel;
	private String email;
	
	// 인스턴스 메소드
	// setter 값을 설정하는거
	public void setName(String name) {
		//x 매개변수로 정보전달 name 전(지역) / 뒤(지역)
		//x this: 객체생성된 위치정보 갖고있음, 인스턴스 변수에만 가능
		this.name = name;
		//x name = name1(지역)		
	}
	// getter 정보를 가져옴
	public String getName() {
		return name;
	}
	public String getTel() {
		return tel;
	}
	public void setTel(String tel) {
		this.tel = tel;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
}

// 클래스 2 하나는 메인 갖고있음
// 인스턴스 변수 프라이빗 -> 게터 세터
*/