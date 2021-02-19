package beak;

import java.util.Scanner;

public class Baek4892 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int i = 1;
		while (true) {
			int n0 = sc.nextInt();
			if (n0 == 0) {
				break;
			}
			int n1 = 3 * n0;
			int n2 = 0;
			if (n1 % 2 != 0) {
				n2 = (n1 + 1) / 2;
			} else {
				n2 = n1 / 2;
			}
			int n3 = 3 * n2;
			int n4 = n3 / 9;
			
			if (n1 % 2 != 0) {
				System.out.println(i + ". odd " + n4);

			} else if (n1 % 2 == 0) {
				System.out.println(i + ". even " + n4);

			}
			i++;

		}
		sc.close();
	}

}
