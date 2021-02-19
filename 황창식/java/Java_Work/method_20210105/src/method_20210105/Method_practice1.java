package method_20210105;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Method_practice1 {

	public static void main(String[] args) {
		Scanner s= new Scanner(System.in);
		System.out.print("숫자를 3개 입력하세요 : ");
		numcomp(s.nextInt(), s.nextInt(), s.nextInt());
		
	}
	
	public static void numcomp(int num1, int num2, int num3) {
		Integer arr[] = {num1, num2, num3};
		Arrays.sort(arr,Collections.reverseOrder());
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
		
		
	}

}
