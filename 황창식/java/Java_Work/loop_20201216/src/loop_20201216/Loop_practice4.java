package loop_20201216;

import java.util.Scanner;

public class Loop_practice4 {

	public static void main(String[] args) {
		System.out.println("------------------");
		System.out.println("구구단 프로그램 v1.0");
		System.out.println("------------------");
		Scanner s = new Scanner(System.in);
		System.out.print("숫자를 하나 입력하세요 : ");
		int num1 = s.nextInt();
		int result = 0;
		System.out.println("------------------");
		System.out.println("For 문\n");
		System.out.println(num1 + "단");
		for (int i = 0; i < 9; i++) {
			result = num1 * (i + 1);
			System.out.println(num1 + " x " + (i + 1) + " = " + result);
		}

		System.out.println("------------------");
		System.out.println("While 문\n");
		System.out.println(num1 + "단");
		int i = 0;
		while (i < 9) {
			result = num1 * (i + 1);
			System.out.println(num1 + " x " + (i + 1) + " = " + result);
			i++;
		}

		System.out.println("------------------");
		System.out.println("Do While 문\n");
		System.out.println(num1 + "단");
		i = 0;
		do {
			result = num1 * (i + 1);
			System.out.println(num1 + " x " + (i + 1) + " = " + result);
			i++;
		} while (i < 9);

	}

}
