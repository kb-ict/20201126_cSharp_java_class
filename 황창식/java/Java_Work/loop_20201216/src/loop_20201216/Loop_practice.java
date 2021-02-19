package loop_20201216;

import java.util.Random;
import java.util.Scanner;

public class Loop_practice {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		System.out.println("-------------------------");
		System.out.println("짝수, 홀수 구분 프로그램 v1.0");
		System.out.println("-------------------------");

		System.out.println("For 문");
		System.out.println("-------------------------");
		for (int i = 0; i < 5; i++) {
			System.out.printf("%d. Num%d ==> ", i + 1, i + 1);
			int num = s.nextInt();
			if (num % 2 == 0) {
				System.out.println("짝수입니다.");
			} else {
				System.out.println("홀수입니다");
			}
		}
		System.out.println("-------------------------");

		System.out.println("While 문");
		System.out.println("-------------------------");
		int i = 0;
		while (i < 5) {
			System.out.printf("%d. Num%d ==> ", i + 1, i + 1);
			int num = s.nextInt();
			if (num % 2 == 0) {
				System.out.println("짝수입니다.");
			} else {
				System.out.println("홀수입니다");
			}
			i++;
		}
		System.out.println("-------------------------");

		System.out.println("Do While 문");
		System.out.println("-------------------------");
		i = 0;
		do {
			System.out.printf("%d. Num%d ==> ", i + 1, i + 1);
			int num = s.nextInt();
			if (num % 2 == 0) {
				System.out.println("짝수입니다.");
			} else {
				System.out.println("홀수입니다");
			}
			i++;
		} while (i < 5);

		

	}

}
