package Test3;

public class Student {
	private String name;
	private int hackbun;
	private char gender;
	public Student(String name, int hackbun, char gender) {
		super();
		this.name = name;
		this.hackbun = hackbun;
		this.gender = gender;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getHackbun() {
		return hackbun;
	}
	public void setHackbun(int hackbun) {
		this.hackbun = hackbun;
	}
	public char getGender() {
		return gender;
	}
	public void setGender(char gender) {
		this.gender = gender;
	}
	public void showstudentInfo() {
		System.out.print("이름 : "+name+", ");
		System.out.print("학번 : "+hackbun+", ");
		System.out.println("성별 : "+gender);
	}
}
