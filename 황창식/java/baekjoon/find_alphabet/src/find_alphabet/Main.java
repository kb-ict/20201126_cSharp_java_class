package find_alphabet;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		String str = scan.next();
		char[] ch = str.toCharArray();
		for (int i = 0; i < ch.length; i++) {
			if(ch[i] > 90)
				ch[i] = (char)((int)ch[i]-32);
			System.out.println(ch[i]);
		}
		
	}
	
	

}
