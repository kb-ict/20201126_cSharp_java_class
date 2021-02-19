package algori;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class NePulee1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("배열의 크기 입력: ");
		int[] arr1 = new int [s.nextInt()];
		//System.out.printf("배열의 크기: %d", arr1.length);
		int max = 0;
		int min = arr1[0];
		
		for (int i = 0; i < arr1.length; i++) {
			System.out.printf("%d번째 값: ",(i+1));
			arr1[i] = s.nextInt();
			if (max<arr1[i]) {
				max = arr1[i];
			}
			if (min>arr1[i]) {
				min = arr1[i];
			}
		}System.out.printf("최대값은 %d", max);


		
	}

}
