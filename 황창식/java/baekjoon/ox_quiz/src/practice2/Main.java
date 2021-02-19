package practice2;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String[] oxq = new String[s.nextInt()];
		for (int i = 0; i < oxq.length; i++) {
			oxq[i] = s.next();
		}
		
		for (int i = 0; i < oxq.length; i++) {
			System.out.println(score(oxq[i]));
		}
		s.close();
	}
	public static int score(String str) {
		int sum = 0;
		int count = 0;
		char[] chs = str.toCharArray();
		for (int i = 0; i < chs.length; i++) {
			if(chs[i] == 'O') {
				count++;
				sum += count;
			}
			else if(chs[i] == 'X') {
				count = 0;
			}
		}
		return sum;
	}

}
