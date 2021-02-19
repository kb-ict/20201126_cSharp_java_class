package beak;

import java.util.Scanner;

public class Beak2577 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int a = sc.nextInt();
		int b = sc.nextInt();
		int c = sc.nextInt();
		int mul = a * b * c;
		int arr[] = new int[9];
		int j = 0;
		int zero = 0;
		int one = 0;
		int two = 0;
		int three = 0;
		int four = 0;
		int five = 0;
		int six = 0;
		int seven = 0;
		int eight = 0;
		int nine = 0;
		for (int i = 9; i > 0; i--) {

			arr[j] = mul / ((int) Math.pow(10, i - 1));
			mul -= arr[j] * ((int) Math.pow(10, i - 1));
			j++;

		}
		if (arr[0] == 0) {
			for (int i = 1; i < 9; i++) {
				if (arr[i] == 9) {
					nine++;
				} else if (arr[i] == 8) {
					eight++;
				} else if (arr[i] == 7) {
					seven++;
				} else if (arr[i] == 6) {
					six++;
				} else if (arr[i] == 5) {
					five++;
				} else if (arr[i] == 4) {
					four++;
				} else if (arr[i] == 3) {
					three++;
				} else if (arr[i] == 2) {
					two++;
				} else if (arr[i] == 1) {
					one++;
				} else if (arr[i] == 0) {
					zero++;
				}
			}
		} else if (arr[0] == 0 && arr[1] == 0) {
			for (int i = 2; i < 9; i++) {
				if (arr[i] == 9) {
					nine++;
				} else if (arr[i] == 8) {
					eight++;
				} else if (arr[i] == 7) {
					seven++;
				} else if (arr[i] == 6) {
					six++;
				} else if (arr[i] == 5) {
					five++;
				} else if (arr[i] == 4) {
					four++;
				} else if (arr[i] == 3) {
					three++;
				} else if (arr[i] == 2) {
					two++;
				} else if (arr[i] == 1) {
					one++;
				} else if (arr[i] == 0) {
					zero++;
				}
			}
		} else {
			for (int i = 0; i < 9; i++) {
				if (arr[i] == 9) {
					nine++;
				} else if (arr[i] == 8) {
					eight++;
				} else if (arr[i] == 7) {
					seven++;
				} else if (arr[i] == 6) {
					six++;
				} else if (arr[i] == 5) {
					five++;
				} else if (arr[i] == 4) {
					four++;
				} else if (arr[i] == 3) {
					three++;
				} else if (arr[i] == 2) {
					two++;
				} else if (arr[i] == 1) {
					one++;
				} else if (arr[i] == 0) {
					zero++;
				}
			}

		}

		System.out.println(zero);
		System.out.println(one);
		System.out.println(two);
		System.out.println(three);
		System.out.println(four);
		System.out.println(five);
		System.out.println(six);
		System.out.println(seven);
		System.out.println(eight);
		System.out.println(nine);
	}

}
