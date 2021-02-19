package method_20201230;

import java.util.Scanner;

public class Method_practice4 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("국어점수 입력 : ");
		int kor = s.nextInt();
		System.out.print("영어점수 입력 : ");
		int eng = s.nextInt();
		System.out.print("수학점수 입력 : ");
		int math = s.nextInt();
		score(kor, eng, math);

	}
	
	public static void score(int a, int b, int c) {
		if(a > 100 || b > 100 || c > 100) {
			System.out.println("잘못 입력하셨습니다.");
		}
		else {
			System.out.println("총점 : " + (a + b + c));
			System.out.println("평균 : " + (a + b + c)/3.0);
		}
		
		
	}

}
