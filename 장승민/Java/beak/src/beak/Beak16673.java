package beak;

import java.util.Scanner;

public class Beak16673 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
//		// C 수집 년수
		int C = sc.nextInt();
		//	K 애착정도 	
		int K = sc.nextInt();
		// P 구매중독	
		int P = sc.nextInt();
		//KC + PC^2
		int sum = 0;
		for (int i = 0; i < C; i++) {
			
		sum += (K*(i+1))+(P*(i+1)*(i+1));
			
		
		}
		System.out.println(sum);
	
	
	
	}

}
