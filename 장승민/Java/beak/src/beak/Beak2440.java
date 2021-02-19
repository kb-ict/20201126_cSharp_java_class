package beak;

import java.util.Scanner;

public class Beak2440 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num = sc.nextInt();
		sc.close();
		for (int i = 0; i < num; i++) {
			for (int j = 0; j < num-i; j++) {
				System.out.print("*");
			}
			System.out.println();
		}

	}

}
