package kakao_dart;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String str = s.next();
		char ch[] = str.toCharArray();
		int result = 0;
		for (int i = 0; i < ch.length; i++) {
			switch(ch[i]) {
			case 'S':
				result += Character.getNumericValue(ch[i-1]);
				break;
			case 'D':
				result += (Character.getNumericValue(ch[i-1])*Character.getNumericValue(ch[i-1]));
				break;
			case 'T':
				result += (Character.getNumericValue(ch[i-1])*Character.getNumericValue(ch[i-1])*Character.getNumericValue(ch[i-1]));
				break;
			case '*':
				result *= 2;
				break;
			case '#':
				result -= 1;
				break;
			default :
				continue;
			}
		}
		System.out.println(result);
	}
}
