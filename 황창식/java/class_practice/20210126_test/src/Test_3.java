public class Test_3 {
	public static void main(String[] args) {
		Student std[] = new Student[2];
		std[0] = new Student("이동준", 2009038033, '남');
		std[1] = new Student("이제영", 2007012034, '여');
		System.out.println("변경 전 학생정보");
		for (int i = 0; i < std.length; i++) {
			std[i].showStudentInfo();
		}
		std[0].setHakbeon(2019038033);
		System.out.println("변경 후 학생정보");
		for (int i = 0; i < std.length; i++) {
			std[i].showStudentInfo();
		}
	}
}

class Student{
	private String name;
	private int hakbeon;
	private char gender;
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getHakbeon() {
		return hakbeon;
	}
	public void setHakbeon(int hakbeon) {
		this.hakbeon = hakbeon;
	}
	public char getGender() {
		return gender;
	}
	public void setGender(char gender) {
		this.gender = gender;
	}
	public Student(String name, int hakbeon, char gender) {
		super();
		this.name = name;
		this.hakbeon = hakbeon;
		this.gender = gender;
	}
	public void showStudentInfo() {
		System.out.println("이름 : " + name);
		System.out.println("학번 : " + hakbeon);
		System.out.println("성별 : " + gender);
		System.out.println("----------------------");
	}
}