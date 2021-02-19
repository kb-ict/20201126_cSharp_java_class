package class0113;

import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
// 문제 4
		
// 1 기본 생성자 내부 메소드 아무것도 없을 때 -------------
//		StudentScore sc = new StudentScore();
//		sc.makeRandom();
//		sc.getHakjum();
//		sc.showHakjum();

// 2 생성자 내부 메소드가 모두 존재 --------------------		
//		for (int i = 0; i < 5; i++) {
//			new StudentScore();
//		}

		
// 속도 배열이 제일빠름
// 3 생성자 내부 메소드 2개만 존재 makeRandom(); / getHakjum(); -----
		StudentScore sc[] = new StudentScore[2];
		for (int i = 0; i < sc.length; i++) {
			sc[i] = new StudentScore();
			sc[i].showHakjum();
		}

	}

}

// public = 자기이름 가지는 파일 있어야함, 보통 파일로 생성
// 내부에 있으려면 public 제거
class StudentScore {
	private int kor;
	private int eng;
	private int math;
	private int hap;
	private int avg;
	private char hakjum;

	public StudentScore() {
		makeRandom();
		getHakjum();
		showHakjum();
	}

	public void makeRandom() {
		Random r = new Random();
		kor = r.nextInt(101);
		eng = r.nextInt(101);
		math = r.nextInt(101);

		hap = kor + eng + math;
		avg = hap / 3;

//		getHakjum();
//		showHakjum();

	}

	public char getHakjum() {
		if (avg <= 100 && avg >= 90) {
			hakjum = 'A';
		} else if (avg <= 89 && avg >= 80) {
			hakjum = 'B';
		} else if (avg <= 79 && avg >= 70) {
			hakjum = 'C';
		} else if (avg <= 69 && avg >= 60) {
			hakjum = 'D';
		} else {
			hakjum = 'F';
		}
		return hakjum;
	}

	public void showHakjum() {
		System.out.println("국어: " + kor);
		System.out.println("영어: " + eng);
		System.out.println("수학: " + math);
		System.out.println("총점: " + hap);
		System.out.println("평균: " + avg);
		System.out.println("학점: " + hakjum);
		System.out.println("---------------------");
	}
}
