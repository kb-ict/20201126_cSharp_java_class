package beak;

import java.util.Scanner;

public class Baek3009 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[][] arr = new int[3][2];
		int[] result = new int[2];
//		3개의 좌표
		for (int i = 0; i < arr.length; i++) {
//			[]:x []:y
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = sc.nextInt();
			}
		}
		sc.close();
		/*
		 * for (int i = 0; i < arr.length; i++) { for (int j = 0; j < arr[i].length;
		 * j++) { System.out.print(arr[i][j]+" "); } System.out.println(); }
		 */
		if (arr[0][0] == arr[1][0]) {
			result[0] = arr[2][0];
		} else if (arr[0][0] == arr[2][0]) {
			result[0] = arr[1][0];
		} else if (arr[1][0] == arr[2][0]) {
			result[0] = arr[0][0];
		}

		if (arr[0][1] == arr[1][1]) {
			result[1] = arr[2][1];
		} else if (arr[0][1] == arr[2][1]) {
			result[1] = arr[1][1];
		} else if (arr[1][1] == arr[2][1]) {
			result[1] = arr[0][1];
		}

		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
	}

}
