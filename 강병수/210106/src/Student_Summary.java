
public class Student_Summary {
	private String name;
	private String email;
	private String tel;
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getTel() {
		return tel;
	}
	public void setTel(String tel) {
		this.tel = tel;
	}
	
	public void ShowStudentInfo() {
		System.out.println("이름: " + name);
		System.out.println("전화: " + tel);
		System.out.println("이메일: " + email);
	}
}
