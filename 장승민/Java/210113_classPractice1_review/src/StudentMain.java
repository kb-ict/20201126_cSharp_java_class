import java.util.ArrayList;
import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
// 		1.생성자 내부에 메쏘드가 없을때 
//		StudentScore ss = new StudentScore();
//		ss.makeRandom();
//		ss.getHakjum();
//		ss.showHakjum();
		
//		2.생성자 내부에 메쏘드가 모두 존재
//		for (int i = 0; i < 5; i++) {
//			 new StudentScore();
//		}
		
//		3. 출력하는 메쏘드가 생성자 내부에 없을 때
//		StudentScore ss[] = new StudentScore[5];
//		for (int i = 0; i < 5; i++) {
//			ss[i] = new StudentScore();
//			ss[i].showHakjum();
//		}
		ArrayList<StudentScore> arrList = new ArrayList<>();
		for(int i=0;i<5;i++) {
			arrList.add(new StudentScore());
		}
		for (int i = 0; i < arrList.size(); i++) {
			arrList.get(i);
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
		getHakjum();
		showHakjum();
	}
	public void makeRandom() {
		Random rd = new Random();
		kor = rd.nextInt(60) + 41;
		eng = rd.nextInt(60) + 41;
		math = rd.nextInt(60) + 41;
		hap = kor + eng + math;
		avg = hap/3;
		
//		getHakjum();
//		showHakjum();
		
	}
	public char getHakjum() {
		if(avg<=100&&avg>=90) hakjum = 'A';
		else if(avg<90&&avg>=80) hakjum = 'B';
		else if(avg<80&&avg>=70) hakjum = 'C';
		else if(avg<70&&avg>=60) hakjum = 'D';
		else if(avg<60&&avg>=50) hakjum = 'E';
		else if(avg<50&&avg>=0) hakjum = 'F';
		return hakjum;
		
	
	}
	
	public void showHakjum() {
		System.out.println("국어 : "+kor);
		System.out.println("영어 : "+eng);
		System.out.println("수학 : "+math);
		System.out.println("총점 : "+hap);
		System.out.println("평균 : "+avg);
		System.out.println("학점 : "+hakjum);
		System.out.println("---------------");
	}
	
}