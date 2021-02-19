package beak;

import java.util.Scanner;

public class Beak14910 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String str = sc.nextLine();
		String[] num = str.split("\\s");
		int[] number = new int[num.length];
		for (int i = 0; i < num.length; i++) {
			number[i] = Integer.parseInt(num[i]);
		}

		String result = "";
		if (number.length == 1) {
			result = "Good";
		}
		for (int i = 0; i < number.length - 1; i++) {
			 if (number[i + 1] < number[i]) {
				result = "Bad";
				break;
			} else {
				result = "Good";
			}

		}
		System.out.println(result);

	}

}
