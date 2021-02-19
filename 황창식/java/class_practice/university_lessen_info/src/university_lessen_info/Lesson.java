package university_lessen_info;

public class Lesson {
	private String language;
	private String lesson1;
	private String lesson2;
	private Student student[];

	public String getLanguage() {
		return language;
	}

	public void setLanguage(String language) {
		this.language = language;
	}

	public String getLesson1() {
		return lesson1;
	}

	public void setLesson1(String lesson1) {
		this.lesson1 = lesson1;
	}

	public String getLesson2() {
		return lesson2;
	}

	public void setLesson2(String lesson2) {
		this.lesson2 = lesson2;
	}

	public Student[] getStudent() {
		return student;
	}

	public void setStudent(Student[] student) {
		this.student = student;
	}
	
	public Lesson(String language, String lesson1, String lesson2, Student[] student) {
		super();
		this.language = language;
		this.lesson1 = lesson1;
		this.lesson2 = lesson2;
		this.student = student;
	}

	public void showLessonInfo() {
		System.out.println("한국대학교 " + getLanguage() + " 강좌");
		System.out.println("-------------------------------------");
		System.out.println("[기본 강의 내용]");
		System.out.println("1. " + getLanguage() + " 기본 문법 학습");
		System.out.println("2. " + getLanguage() + " 기본 로직 학습");
		System.out.println("-------------------------------------");
		System.out.println("[추가 강의 내용]");
		System.out.println("1. " + getLanguage() + " " + getLesson1());
		System.out.println("2. " + getLesson2());
		System.out.println("-------------------------------------");
		System.out.println("번호\t이름\t성별\t나이\t직업");
		for (int i = 0; i < 6; i++) {
			student[i].showStuInfo(i+1);
		}
		System.out.println("-------------------------------------");
		System.out.println();
	}

}
