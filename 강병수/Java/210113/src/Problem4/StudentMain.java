package Problem4;

import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
		
//		1. 생성자 내부에 매소드가 아무것도 없을때
//		StudentScore student = new StudentScore();
//		student.makeRandom();
//		student.getGrade();
//		student.showGrade();
//		2. 생성자 내부에 메소드가 모두 존재
//		for (int i=0; i<5 ; i++) {
//			new StudentScore();	
//		}
		
//		3. 생성자 내부에 메소드 2개만 존재
//		makeRandom();
//		getGrade();
		StudentScore sc[] = new StudentScore[5];
		for (int i = 0; i<sc.length; i++) {
			sc[i] = new StudentScore();
		}
	}

}

class StudentScore {
	private int kor;
	private int eng;
	private int math;
	private int sum;
	private int avr;
	private char grade;
	
	public StudentScore() {
		makeRandom();
		getGrade();
		showGrade();
	}
	
	public void makeRandom() {
		Random ran = new Random();
		kor = ran.nextInt(101);
		eng = ran.nextInt(101);
		math = ran.nextInt(101);
		sum = kor + eng + math;
		avr = sum/3;
	}
	
	public char getGrade() {
		if (avr <= 100 && avr >= 90) {
			grade = 'A';
		}
		else if (avr < 90 && avr >= 80) {
			grade = 'B';
		}
		else if (avr < 80 && avr >= 70) {
			grade = 'C';
		}
		else if (avr < 70 && avr >= 60) {
			grade = 'D';
		}
		else if (avr < 60 && avr >= 0) {
			grade = 'F';
		}
		return grade;
		
	}
	
	public void showGrade() {
		System.out.println("국어: " + kor);
		System.out.println("영어: " + eng);
		System.out.println("수학: " + math);
		System.out.println("총점: " + sum);
		System.out.println("평균: " + avr);
		System.out.println("학점: " + grade);
		System.out.println("----------------------------");
	}
	
}


