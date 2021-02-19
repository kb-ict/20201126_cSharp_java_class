package class0106_2;

public class Student {
	private String name;
	private String tel;
	private String email;
	
	
	public String getName() {
		return name;
	}
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
