package prj1;

public class A1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Student s = new Student();
		s.name = "±Ë¥Î«—";
		s.email = "abc@naver.com";
		s.tel = "010-0101-0101";
	}
}

class Student {
	static int num;
	String name;
	String tel;
	String email;
	
	public void setName(String name) {
		this.name = name;
	}
	
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