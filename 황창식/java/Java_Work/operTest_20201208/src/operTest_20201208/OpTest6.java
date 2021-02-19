package operTest_20201208;

import java.util.Scanner;

public class OpTest6 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);

		int a = 0; // 500원 갯수
		int b = 0; // 100원 갯수
		int c = 0; // 50원 갯수
		int d = 0; // 10원 갯수
		int e = 0; // 남은 금액

		/*
		 * System.out.print("금액을 입력하세요 : "); int m = s.nextInt();
		 * 
		 * a = m / 500; b = (m % 500) / 100; c = ((m % 500) % 100) / 50; d = (((m % 500)
		 * % 100) % 50) / 10; e = (((m % 500) % 100) % 50) % 10;
		 * 
		 * 
		 * System.out.println("--------------------");
		 * System.out.println(" 동전 교환기 프로그램 1.0");
		 * System.out.println("--------------------");
		 * System.out.println("   500원 갯수 : " + a); System.out.println("   100원 갯수 : " +
		 * b); System.out.println("    50원 갯수 : " + c);
		 * System.out.println("    10원 갯수 : " + d); System.out.println("     나머지   : " +
		 * e); System.out.println("--------------------");
		 */

		int coin500 = 0;
		int coin100 = 0;
		int coin50 = 0;
		int coin10 = 0;
		int extra = 0;
		int input = 0;

		System.out.print("금액을 입력하세요 : ");
		input = s.nextInt();

		coin500 = input / 500;
		extra = input % 500;
		coin100 = extra / 100;
		extra = extra % 100; // extra %= 100
		coin50 = extra / 50;
		extra = extra % 50;
		coin10 = extra / 10;
		extra = extra % 10;

		System.out.println("--------------------");
		System.out.println("동전 교환기 프로그램 v1.0");
		System.out.println("--------------------");
		System.out.println(" 500원 갯수 : " + coin500 + "개");
		System.out.println(" 100원 갯수 : " + coin100 + "개");
		System.out.println(" 50원 갯수  : " + coin50 + "개");
		System.out.println(" 10원 갯수  : " + coin10 + "개");
		System.out.println(" 남은 금액	  : " + extra + "원");
		System.out.println("--------------------");
		s.close();

	}

}
