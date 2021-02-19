package beak;

import java.util.Scanner;

public class Beak8958 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num = sc.nextInt();
		String [] ox = new String[num];
		for (int i = 0; i < num; i++) {
			ox[i] = sc.next();
			int cnt =0;
			int sum =0;
			for (int j = 0; j < ox[i].length(); j++) {
				if (ox[i].charAt(j)=='O') {
					sum+=++cnt;
				}
				else {
					cnt=0;
				}
			}System.out.println(sum);
		}
		sc.close();

	}
}




