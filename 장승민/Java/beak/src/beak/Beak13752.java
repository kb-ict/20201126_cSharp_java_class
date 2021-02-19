package beak;

import java.util.Scanner;

public class Beak13752 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int cnt = sc.nextInt();
		for (int i = 0; i < cnt; i++) {
			int num = sc.nextInt();
			for (int j = 0; j < num; j++) {
				System.out.print("=");
			}
			System.out.println();
		}

	}

}
