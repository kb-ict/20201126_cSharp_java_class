package class_20210106_1;

public class Student {
	// 인스턴스 변수 - 속성(특징)
	private String name;
	private String tel;
	private String email;
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
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
		System.out.println("학생 정보");
		System.out.println("------------------------");
		System.out.println("이름 : " + name);
		System.out.println("전화 : " + tel);
		System.out.println("이메일 : " + email);
		System.out.println("------------------------");
	}
	
	
}
