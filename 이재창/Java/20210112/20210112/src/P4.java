import java.util.Random;

public class P4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
//		StudentScore ss = new StudentScore();
//		ss.showHakjum();
		
		StudentScore[] sc = new StudentScore[5];
		
		for (int i = 0; i < sc.length; i++) {
			sc[i] = new StudentScore();
			sc[i].showHakjum();
		}
	}

}

class StudentScore {
	private int kor;
	private int eng;
	private int math;
	private int hap;
	private int avg;
	private char hakjum;
	
	public StudentScore() {
		makeRandom();
	}
	
	public void makeRandom() {
		Random rand = new Random();
		kor = rand.nextInt(101);
		eng = rand.nextInt(101);
		math = rand.nextInt(101);
		hap = kor + eng + math;
		avg = hap / 3;
		makeHakjum();
	}
	
	private void makeHakjum() {
		if (avg <= 100 && avg >= 90) {
			hakjum = 'A';
		}
		else if (avg <= 89 && avg >= 80) {
			hakjum = 'B';
		}
		else if (avg <= 79 && avg >= 70) {
			hakjum = 'C';
		}
		else if (avg <= 69 && avg >= 60) {
			hakjum = 'D';
		}
		else {
			hakjum = 'F';
		}
	}
	
	public void showHakjum() {
		System.out.println("국어: " + kor);
		System.out.println("영어: " + eng);
		System.out.println("수학: " + math);
		System.out.println("총점: " + hap);
		System.out.println("평균: " + avg);
		System.out.println("학점: " + hakjum);
	}
}