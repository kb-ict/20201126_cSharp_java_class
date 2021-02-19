package beak;

import java.util.Scanner;

public class Beak10101 {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		int [] arr = new int[3];
		int sum =0;
		for (int i = 0; i < arr.length; i++) {
			arr[i]=sc.nextInt();
			sum+=arr[i];
		}
		if(!(sum==180)) {
			System.out.println("Error");
		}else if(arr[0]==arr[1]&&arr[1]==arr[2]) {
			System.out.println("Equilateral");
		}else if(arr[0]==arr[1]||arr[1]==arr[2]||arr[0]==arr[2]) {
			System.out.println("Isosceles");
		}else if(arr[0]!=arr[1]&&arr[1]!=arr[2]&&arr[0]!=arr[2]) {
			System.out.println("Scalene");
		}
	}

}
