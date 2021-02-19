package beak;

import java.util.Scanner;

public class Cycle {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);

		int N=0;
		int count = 0;
	
		N=sc.nextInt();
		sc.close();
		
		int res=N;
		
		while (true) {
			N = ((N % 10) * 10) + (((N / 10) + (N % 10)) % 10);
			count++;
			
			if (res==N) {
				break;
			}
		}
		System.out.println(count);
	}

}
