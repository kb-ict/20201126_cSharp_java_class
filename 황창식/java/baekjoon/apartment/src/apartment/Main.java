package apartment;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
//		int t = s.nextInt();
		int k = s.nextInt();
		int n = s.nextInt();
		int arr[][] = new int[k+1][n+1];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				if(i == 0) {
					arr[i][j] = j;
				}
				else {
					int count = 0;
					for (int l = 0; l < j; l++) {
						count += arr[i-1][j];
					}
					arr[i][j] = count;
				}
			}
		}
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + " ");
			}
			System.out.println();
		}

	}

}
