package array;

import java.util.Arrays;

public class Array {

	public static void main(String[] args) {

		int a[] = { 2, 1, 6, 4, 3 };
		int[] b = { 6, 7, 8, 9, 10 };

		for (int i = 0; i < a.length; i++) {
			System.out.print(a[i] + "\t");
		}
		System.out.println();

		Arrays.sort(a);

		for (int i = 0; i < a.length; i++) {
			System.out.print(a[i] + "\t");
		}
	}

}
