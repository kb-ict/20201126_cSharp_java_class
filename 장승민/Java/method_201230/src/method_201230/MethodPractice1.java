package method_201230;

import java.util.Arrays;
import java.util.Scanner;

public class MethodPractice1 {
//1,3,4,5,8
	public static void main(String[] args) {
		
		Scanner sc= new Scanner(System.in);
		
		int arr[]=new int [3];
		
		for (int i = 0; i < 3; i++) {
			arr[i] = sc.nextInt();
		}	
		
		sc.close();
		
		func(arr);
		
		for (int i = 2; i >= 0; i--) {
			System.out.print(arr[i]);
			if (i>0) {
				System.out.print("-");
			}
		}

	}

	public static void func(int arr[]) {
		Arrays.sort(arr);
	}
}
