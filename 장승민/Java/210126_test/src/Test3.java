

public class Test3 {

	public static void main(String[] args) {
//		학생들에 대한 정보를 저장할 수 있는 변수 생성  2
		Student st1 = new Student("이동준", 2009038033, '남');
		Student st2 = new Student("이제영", 2007012034, '여');
//		해당 학생들을 하나의 배열에 저장  3
		Student[] studentArray = { st1, st2 };

//		이름이 이동준인 학생의 학번 변경 4
		st1.setNum(2019038033);
//		for (int i = 0; i < studentArray.length; i++) {
//			Student student = studentArray[i];
//			if(student.name.equals("이동준"))
//			
//		}
		
//		최종 완성된 배열 출력
		for (int i = 0; i < studentArray.length; i++) {
			studentArray[i].showStudentInfo();
		}
	}

}

// 학성 정보 저장 Class 생성 1
class Student {
	String name;
	private int num;
	private char gender;

//	매개변수를 받는 생성자 생성
	public Student(String name, int num, char gender) {
		super();
		this.name = name;
		this.num = num;
		this.gender = gender;
	}

//	getter & setter 생성
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getNum() {
		return num;
	}

	public void setNum(int num) {
		this.num = num;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}
// 학생들의 정보를 보여주는 메쏘드
	public void showStudentInfo() {
		System.out.println("이름: " + name + ", 학번: " + num + ", 성별: " + gender);
	}

}
