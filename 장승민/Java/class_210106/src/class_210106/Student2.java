package class_210106;

public class Student2 {

	static String category="통합응용SW과정";		
	//public : 외부 클래스에서 접근 가능
	//private : 외부 클래스에서 접근 불가  class Student2 안에서만 적용됨. 
	//
	private String name;	
	private String tel;
	private String email;

	// 인스턴스 메쏘드
	// setter : 값을 설정하는 녀석
	public void setName(String name) {
		this.name = name;
	}
	// getter : 값을 가져오는 녀석
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
