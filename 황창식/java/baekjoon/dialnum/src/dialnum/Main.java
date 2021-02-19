package dialnum;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String str = s.next();
		char[] ch = str.toCharArray();
		int result = 0;
		for (int i = 0; i < ch.length; i++) {
			result += getNum(ch[i])+1;
		}
		System.out.println(result);

	}
	
	public static int getNum(char ch) {
		int result = 0;
		switch(ch) {
		case 'A':
		case 'B':
		case 'C':
			result = 2;
			break;
		case 'D':
		case 'E':
		case 'F':
			result = 3;
			break;
		case 'G':
		case 'H':
		case 'I':
			result = 4;
			break;
		case 'J':
		case 'K':
		case 'L':
			result = 5;
			break;
		case 'M':
		case 'N':
		case 'O':
			result = 6;
			break;
		case 'P':
		case 'Q':
		case 'R':
		case 'S':
			result = 7;
			break;
		case 'T':
		case 'U':
		case 'V':
			result = 8;
			break;
		case 'W':
		case 'X':
		case 'Y':
		case 'Z':
			result = 9;
			break;
		}
		return result;
		
	}

}
