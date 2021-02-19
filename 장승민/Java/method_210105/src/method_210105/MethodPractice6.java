package method_210105;

import java.util.Random;

public class MethodPractice6 {

	public static void main(String[] args) {
		int lotto[] = arr();
		for (int i = 0; i < lotto.length; i++) {
			System.out.println(lotto[i]);
		}
	}
	
	public static int[] arr() {
		Random rd = new Random();
		int arr[]= new int [6];
		for (int i = 0; i < arr.length; i++) {
			arr[i]=rd.nextInt(45)+1;
			for (int j = 0; j < i; j++) {
				if (arr[i]==arr[j]) {
					i--;
				}
			}
		}
		return arr;
	}

}
