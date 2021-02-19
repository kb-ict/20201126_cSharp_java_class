package method_20210105;

import java.util.Scanner;

public class Method_practice4 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("국어점수를 입력하세요 : ");
		int kor = s.nextInt();
		System.out.print("영어점수를 입력하세요 : ");
		int eng = s.nextInt();
		System.out.print("수학점수를 입력하세요 : ");
		int math = s.nextInt();
		sumave(kor, eng, math);
	}
	
	public static void sumave(int num1, int num2, int num3) {
		int sum = num1 + num2 + num3;
		int ave = sum/3;
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + ave);
	}

}
