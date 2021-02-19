//import java.util.ArrayList;

public class Mun3_Main {

	public static void main(String[] args) {

		Student s[] = new Student[2];
		s[0] = new Student("이동준", 2009038033, '남');
		s[1] = new Student("이제영",2007012034,'여');
		
		
		// 출력 후 확인
//		s[0].showStudent();
//		s[1].showStudent();
//		s[0].setHakbun(2019038033);
//		s[0].showStudent();
		
		// 수정하는거 기억안나서 하다 접음
//		ArrayList<Student> arrList = new ArrayList<>();
//		arrList.add(new Student("이동준",2009038033,'남'));
//		arrList.add(new Student("이제영",2007012034,'여'));
	}

}

class Student {
	private String name;
	private int hakbun;
	private char gender;

	// 매개변수로 인스턴스 변수 설정하는 생성자
	public Student(String name, int hakbun, char gender) {
		super();
		this.name = name;
		this.hakbun = hakbun;
		this.gender = gender;
	}

	// 출력용 인스턴스 메소드
	public void showStudent() {
		System.out.println("이름 : " + name);
		System.out.println("학번 : " + hakbun);
		System.out.println("성별 : " + gender);
	}

	// getter & setter
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getHakbun() {
		return hakbun;
	}

	public void setHakbun(int hakbun) {
		this.hakbun = hakbun;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}

}
