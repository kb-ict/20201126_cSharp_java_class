package string_numsum;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		char sapnum[] = new char[n];
		String num = s.next();
		sapnum = num.toCharArray();
		int sum = 0;
		for (int i = 0; i < sapnum.length; i++) {
			sum += Character.getNumericValue(sapnum[i]);
		}
		System.out.println(sum);

	}

}
