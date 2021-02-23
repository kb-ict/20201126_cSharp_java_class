
public class Student_Class2 {
	static String category = "통합응용SW과정"; // 클래스 변수

	// private: 외부 클래스에 접근 불가
	// public: 외부 클래스에서 접근 가능
	// 인스턴스 변수 - 속성(특징)
	private String name;
	private String tel;
	private String email;

	// 인스턴스 메소드
	// setter
	public void setName(String name) {
		this.name = name; //this 옆에 있는 변수는 전역변수에서 가져온거 우변쪽은 지역변수
	}

	// getter
	public String getName() {
		return name;
	}

	// 작업표시줄 source/Generate getters and setters..에서 설정하여 일괄 생성
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
