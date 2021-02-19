package class0106_2;

public class Student {
	private String name;
	private String tel;
	private String email;
	// 인스턴스 변수 - 속성(특징) 
	// 인스턴스 변수 메소드만 구성: 데이터 클래스, 모델클래스
	// private: 클래스 내부에서만 접근
	// 접근 위해서 클래스는 public, 가비지컬렉터 자동관리
	
	// getter
	public String getName() {
		return name;
	}
	
	// setter
	public void setName(String name) {
		this.name = name;
		//name = name1; jdk = this있다고 간주함.
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
	
	public void showStudentInfo() {
		System.out.println("이름: "+name);
		System.out.println("전화: "+tel);
		System.out.println("이메일: "+email);
		System.out.println();
	}
}
