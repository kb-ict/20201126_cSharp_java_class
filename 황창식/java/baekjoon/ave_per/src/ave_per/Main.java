package ave_per;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
	
		Scanner s = new Scanner(System.in);
		int c = s.nextInt();
		double per[] = new double[c];
		for (int i = 0; i < per.length; i++) {
			double sum = 0;
			double count = 0;
			double ave = 0;
			double arr[] = new double[s.nextInt()];
			for (int j = 0; j < arr.length; j++) {
				arr[j] = s.nextInt();
				sum += arr[j];
			}
			ave = sum / arr.length;
			for (int j = 0; j < arr.length; j++) {
				if(arr[j] > ave) {
					count++;
				}
			}
			per[i] = (count/arr.length)*100;
		}
		
		for (int i = 0; i < per.length; i++) {
			System.out.println(String.format("%.3f", per[i]) + "%");
		}
		
	}

}
