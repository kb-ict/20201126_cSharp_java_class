package method_20201230;

import java.util.Scanner;

public class Method_practice9 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("3개의 수 입력 : ");
		
		int result[] = maxmin(s.nextInt(), s.nextInt(), s.nextInt());
		System.out.println("최대값 : " + result[0]);
		System.out.println("최소값 : " + result[1]);
		
	}
	public static int[] maxmin(int a, int b, int c) {
		int arr[] = {a, b, c};
		int max = arr[0];
		int min = arr[0];
		
		for (int i = 0; i < arr.length; i++) {
			if(max < arr[i]) {
				max = arr[i];
			}
			if(min > arr[i]) {
				min = arr[i];
			}
		}
		int result[] = {max, min};
		return result;
	}

}
