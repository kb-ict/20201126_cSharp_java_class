package method_210105;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class MethodPractice1 {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		Integer arr[] = new Integer[3];
		
		for (int i = 0; i < arr.length; i++) {
			arr[i]= sc.nextInt();
		}
		sc.close();
		mySort(arr);
	}

	public static void mySort(Integer arr[]) {
		Arrays.sort(arr, Collections.reverseOrder());
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}
}
