class Student {
	private String name;
	private int number;
	private char gender;

	public Student(String name, int number, char gender) {
		super();
		this.name = name;
		this.number = number;
		this.gender = gender;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getNumber() {
		return number;
	}

	public void setNumber(int number) {
		this.number = number;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}

	public void showStudentInfo() {
		System.out.println("이름: " + name);
		System.out.println("학번: " + number);
		System.out.println("성별:" + gender);
	}

}

public class Problem3 {

	public static void main(String[] args) {
		String name[] = { "이동준", "이재영" };
		int number[] = { 2009038033, 2007012034 };
		char gender[] = { '남', '여' };

		number[0] = 2019038033;

		for (int i = 0; i < 2; i++) {
			new Student(name[i], number[i], gender[i]).showStudentInfo();
			System.out.println("=============================");
		}
	}

}
