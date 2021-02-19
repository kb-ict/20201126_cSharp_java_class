package beak;

import java.util.Scanner;

public class Beak10987 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String word = sc.next();
		sc.close();
		char [] ch = word.toCharArray();
		int cnt=0;
		for (int i = 0; i < ch.length; i++) {
			switch (ch[i]) {
				case 'a' : cnt++;break;
				case 'e' : cnt++;break;
				case 'i' : cnt++;break;
				case 'o' : cnt++;break;
				case 'u' : cnt++;break;
			}
		}
		System.out.println(cnt);
	}
}
