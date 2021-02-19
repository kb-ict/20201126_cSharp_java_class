//main이 없는 클래스파일 생성
//public은 자기 클래스 파일(.java)이 무조건 있어야함 (Student2.java 생성 됨)
public class Student2 {
	// 클래스 변수
	static String category = "통합응용SW과정";
	// private : 외부 클래스에서 접근 불가 /x 클래스 안에서만 접근가능, 캡슐화(정보를 외부로노출 x, 감싼다)
	// public : 외부 클래스에서 접근 가능
	// 인스턴스 변수
	private String name;
	private String tel;
	private String email;

	// 인스턴스 메소드
	// setter 값을 설정하는거
	public void setName(String name) {
		// x 매개변수로 정보전달 name 전(지역) / 뒤(지역)
		// x this: 객체생성된 위치정보 갖고있음, 인스턴스 변수에만 가능
		this.name = name;
		// x name = name1(지역)
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
