package kb411;

import java.util.Scanner;

public class sample4 {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine();
		char[] test = new char[] {
				'ぁ', 'い', 'ぇ', 'ぉ', 'け'
				, 'げ', 'さ', 'し', 'じ', 'ず'
				, 'せ', 'ぜ', 'そ', 'ぞ', 'た'
				, 'ち', 'っ', 'づ', 'で', 'に'
				, 'ぬ', 'ば', 'ぱ', 'び'
		};
		
		for( int i=0; i<input.length(); i++ ) {
			System.out.println(
					test[input.charAt(i) - (int)'a'] 
					);
		}
		System.out.println();
		
	}
}
