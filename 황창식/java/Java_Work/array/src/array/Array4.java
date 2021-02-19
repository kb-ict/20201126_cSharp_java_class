package array;

import java.util.Arrays;

public class Array4 {

	public static void main(String[] args) {

		int[] arr1 = new int[10]; // 배열의 모든 요소는 0으로 초기화
		String[] arr2 = new String[10]; // 배열의 모든 요소는 NULL로 초기화

		int[] ar1 = new int[10];
		int[] ar2 = new int[10];

		Arrays.fill(ar1, 7); // 배열 ar1을 7로 초기화
		System.arraycopy(ar1, 0, ar2, 3, 4); // 배열 ar1을 ar2로 부분 복사 : ar1[0] 부분을 ar2[3] 부터 4길이로 복사

		for (int i = 0; i < ar1.length; i++) {
			System.out.print(ar1[i] + " ");
		}
		System.out.println();
		
		for(int j = 0; j < ar2.length; j++) {
			System.out.print(ar2[j] + " ");
		}

	}

}
