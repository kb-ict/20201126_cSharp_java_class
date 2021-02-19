package practice;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		double arr[] = new double[s.nextInt()];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		double max = max(arr);
		double sum = 0;
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (arr[i]/max)*100;
			sum += arr[i];
		}
		double ave = sum/arr.length;
		System.out.println(ave);
		
		
	}
	
	public static double max(double[] arr) {
		Arrays.sort(arr);
		double max = arr[arr.length-1];
		return max;
	}
}
