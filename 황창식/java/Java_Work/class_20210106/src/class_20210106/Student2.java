package class_20210106;

// 클래스를 독자적인 클래스 파일로 생성가능
public class Student2 {
	static String category = "통합 응용 SW 과정";

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
}
