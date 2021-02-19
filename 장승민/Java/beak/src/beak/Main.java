package beak;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);

		int N = 99;
		int cnt=1;
		int max=0;
		for (int i = 1; i <10; i++) {
			N=sc.nextInt();
			if (max<N) {
				max=N;
				cnt=i;
			}
			}
		System.out.println(max);
		System.out.println(cnt);
		
	}

}
