package beak;

import java.util.Scanner;

public class Baek7891 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int cnt = sc.nextInt();
		int a, b;
		for (int i = 0; i < cnt; i++) {
			a = sc.nextInt();
			b = sc.nextInt();
			System.out.println(a+b);
		}
		sc.close();

	}

}
