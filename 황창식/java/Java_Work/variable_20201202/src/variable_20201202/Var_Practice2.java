package variable_20201202;

import java.util.Scanner;

public class Var_Practice2 {

	public static void main(String[] args) {

		// 원의 면적을 구하는 프로그램
		final double PI = 3.14;
		int r = 4;
		System.out.println("반지름 x 반지름 x PI = " + (r * r * PI) + "(원의 면적)\n");

		// 성적표
		int korean;
		int english;
		int math;
		int scien;

		korean = 90;
		english = 80;
		math = 70;
		scien = 60;
		System.out.println("모든 과목의 평균은 " + ((korean + english + math + scien) / 4) + "점 입니다\n");

		// 알파벳과 한글의 자음, 모음을 구하는 프로그램
		int Eng1; // 영어 자음
		int Eng2; // 영어 모음
		int Kor1; // 한글 자음
		int Kor2; // 한글 모음

		Eng1 = 21;
		Eng2 = 5;
		Kor1 = 19;
		Kor2 = 21;

		System.out.println("영어의 자음의 갯수는 " + Eng1 + "개, 모음의 갯수는 " + Eng2 + "개 입니다");
		System.out.println("한글의 자음의 갯수는 " + Kor1 + "개, 모음의 갯수는 " + Kor2 + "개 입니다\n");

		// 온도를 구하는 프로그램
		float F; // 화씨온도
		float C; // 섭씨온도
		F = 40;
		System.out.println("화씨온도가 " + F + "일때, 섭씨온도는 " + ((F - 32) / 1.8) + "입니다\n");

		// 원주율, 점수 입력하여 값 구하기

		Scanner sc = new Scanner(System.in);
		System.out.print("반지름을 입력하세요 : ");
		int R = sc.nextInt();
		System.out.println("반지름이 " + R + "인 원의 원주율의 값은" + (R * R * PI) + "입니다\n");

		System.out.print("국어점수를 입력하세요 : ");
		int KOREAN = sc.nextInt();
		System.out.print("영어점수를 입력하세요 : ");
		int ENGLISH = sc.nextInt();
		System.out.print("수학점수를 입력하세요 : ");
		int MATH = sc.nextInt();
		System.out.print("과학점수를 입력하세요 : ");
		int SCIEN = sc.nextInt();
		System.out.println("-----------------");
		/*
		 * System.out.printf("\n국어의 점수는 : %d점 입니다\n", KOREAN);
		 * System.out.printf("엉어의 점수는 : %d점 입니다\n", ENGLISH);
		 * System.out.printf("수학의 점수는 : %d점 입니다\n", MATH);
		 * System.out.printf("과학의 점수는 : %d점 입니다\n", SCIEN);
		 */
		System.out.println("\n국어의 점수는 " + KOREAN + "점 입니다");
		System.out.println("영어의 점수는 " + ENGLISH + "점 입니다");
		System.out.println("수학의 점수는 " + MATH + "점 입니다");
		System.out.println("과학의 점수는 " + SCIEN + "점 입니다");
		System.out.println("\n모든 점수의 평균은 " + ((KOREAN + ENGLISH + MATH + SCIEN) / 4.0) + "입니다");

	}

}
