package beak;

import java.util.Arrays;
import java.util.Scanner;

public class Beak10817 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int [] arr = new int[3];
		for (int i = 0; i < arr.length; i++) {
			arr[i]=sc.nextInt();
		}
		sc.close();
		Arrays.sort(arr);
		System.out.println(arr[1]);

	}

}
