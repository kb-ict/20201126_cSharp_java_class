package text_repeat;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		String p[] = new String[scan.nextInt()];
		for (int i = 0; i < p.length; i++) {
			int r = scan.nextInt();
			String s = scan.next();
			char[] spell = s.toCharArray();
			String result = "";
			for (int j = 0; j < spell.length; j++) {
				for (int k = 0; k < r; k++) {
					result += spell[j];
				}
			}
			p[i] = result;
		}
		
		for (int i = 0; i < p.length; i++) {
			System.out.println(p[i]);
		}
	}

}
