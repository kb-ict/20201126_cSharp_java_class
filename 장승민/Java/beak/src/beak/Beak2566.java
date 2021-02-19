package beak;

import java.util.Scanner;

public class Beak2566 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[][] arr = new int [9][9];
		int x = 0;
		int y = 0;
		int max =0;
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = sc.nextInt();
				if(max<=arr[i][j]) {
					max = arr[i][j];
					x=i+1;
					y=j+1;
				}
			}
		}
		sc.close();
		System.out.println(max);
		System.out.println(x +" " +y);
	}

}
