package darray;

import java.util.Scanner;

public class Arr4 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("행의 개수 입력");
		int row = sc.nextInt();
		System.out.println("열의 개수 입력");
		int col = sc.nextInt();

		int arr[][] = new int [row][col];
		int value =1;

		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) {
				arr[i][j] = value++;

			}

		}
		System.out.printf("arr[0][0] ~ arr[%d][%d]\n",row,col);
		
		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) {
				System.out.print(arr[i][j]);
			}System.out.println();
		
		}

	}



}
