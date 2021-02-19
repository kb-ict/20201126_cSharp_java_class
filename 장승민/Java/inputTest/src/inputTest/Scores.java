package inputTest;

import java.util.Scanner;

public class Scores {

	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);
		
		System.out.println("국어 점수 : ");
		int kor = s.nextInt();
		
		System.out.println("영어 점수 : ");
		int eng = s.nextInt();

		System.out.println("수학 점수 : ");
		int math = s.nextInt();

		System.out.println("과학 점수 : ");
		int sci = s.nextInt();
		s.close();
		
		int sum = kor + eng + math + sci ;
		double avg = sum / (double)4;
		
		System.out.println("총 점 : "+sum);
		System.out.println("평 균 : "+ avg);

	}

}
