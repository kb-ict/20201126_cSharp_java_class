package university_lessen_info;

public class Main {
	public static void main(String[] args) {
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		String gender[] = {"남자", "여자"};
		String job[] = {"학생", "강사", "백수", "뉴미디어 모니터링 요원"};
		
		String language[] = {"C/C++", "Python", "Java"};
		String lesson1[] = {"윈도우 프로그래밍 학습", "GUI 프로그래밍 학습"};
		String lesson2[] = {"중, 고급 알고리즘을 위한 자료구조 학습", "Python 네트웍 프로그래밍을 위한 TCP/IP 학습", "DB연동을 위한 JDBC 프로그래밍 학습"};
		
		Lesson lesson[] = new Lesson[3];
		Student[] stu = new Student[6];
		
		for (int i = 0; i < stu.length; i++) {
			stu[i] = new Student(name[(int)(Math.random()*5)], gender[(int)(Math.random()*2)],(int)(Math.random()*39)+1, job[(int)(Math.random()*4)]);
		}
		for (int i = 0; i < lesson.length; i++) {
			lesson[i] = new Lesson(language[i], lesson1[(int)(Math.random()*2)], lesson2[i], stu);
			lesson[i].showLessonInfo();
		}
	}

}
