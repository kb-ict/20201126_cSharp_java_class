package method_20201230;

import java.util.Scanner;

public class Method_practice3 {

	public static void main(String[] args) {
		int arr[] = new int[10];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (int)(Math.random()*100)+1;
		}
		holjjack(arr);
	}
	
	public static void holjjack(int arr[]) {
		for(int i : arr) {
			if(i % 2 != 0) 
				System.out.println(i + "는 홀수입니다.");
			else
				System.out.println(i + "는 짝수입니다.");
		}
	}
	

}
