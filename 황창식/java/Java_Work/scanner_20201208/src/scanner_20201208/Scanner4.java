package scanner_20201208;

import java.util.Scanner;

public class Scanner4 {

	public static void main(String[] args) {

		final double PI = 3.14;
		Scanner s = new Scanner(System.in);
		System.out.print("반지름을 입력하세요 : ");
		int r = s.nextInt();
		
		System.out.println("\n원의 면적 : " + (r * r * PI));
		
		
		System.out.print("\n국어 점수를 입력하세요 : ");
		int kor = s.nextInt();
		System.out.print("영어 점수를 입력하세요 : ");
		int eng = s.nextInt();
		System.out.print("수학 점수를 입력하세요 : ");
		int math = s.nextInt();
		System.out.print("과학 점수를 입력하세요 : ");
		int sci = s.nextInt();
		
		int sum = kor + eng + math + sci;
		double ave = sum / 4.00;
		
		System.out.println("\n총점 : " + sum);
		System.out.println("평균 : " + ave);
		s.close();

	}

}
