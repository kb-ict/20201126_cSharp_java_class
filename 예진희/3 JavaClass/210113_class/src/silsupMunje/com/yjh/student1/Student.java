package silsupMunje.com.yjh.student1;

public class Student {
	private String name;
	private int age;
	private char gender;
	private String address;
	
//	private String[] name;
//	private int[] age;
//	private char[] gender;
//	private String[] address;
	
	public Student(String name2, int age2, char gender2, String address2) {
		super();
		this.name = name2;
		this.age = age2;
		this.gender = gender2;
		this.address = address2;
	}
	
	public void showStudent() {
		System.out.println("이름: "+name);
		System.out.println("나이: "+age);
		System.out.println("성별: "+gender);
		System.out.println("주소: "+address);
		System.out.println("--------------------\n");
	}


	public String getName() {
		return name;
	}


	public void setName(String name) {
		this.name = name;
	}


	public int getAge() {
		return age;
	}


	public void setAge(int age) {
		this.age = age;
	}


	public char getGender() {
		return gender;
	}


	public void setGender(char gender) {
		this.gender = gender;
	}


	public String getAddress() {
		return address;
	}


	public void setAddress(String address) {
		this.address = address;
	}
	
	
	
}
