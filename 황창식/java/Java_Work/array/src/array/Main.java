package array;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		char arr[] = new char[s.nextInt()];
		int num = s.nextInt();
		String number = Integer.toString(num);
		int sum = 0;
		for (int i = 0; i < arr.length; i++) {
			arr[i] = number.charAt(i);
			num = Character.getNumericValue(arr[i]);
			sum += num;
		}
		System.out.println(sum);
		
		
		
	}

}
