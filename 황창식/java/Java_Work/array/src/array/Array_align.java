package array;

import java.util.Scanner;

public class Array_align {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int arr[] = new int[s.nextInt()];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (int)(Math.random()*50)+1;
		}
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
		System.out.println("\n---------정렬 완료---------");
		arr = align(arr);
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}
	
	public static int[] align(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			for (int j = i; j < arr.length; j++) {
				int copy = arr[i];
				if(arr[i] > arr[j]) {
					arr[i] = arr[j];
					arr[j] = copy;
				}
			}
		}
		return arr;
//		for (int i = 0; i < arr.length; i++) {
//			System.out.print(arr[i] + " ");
//		}
	}

}
