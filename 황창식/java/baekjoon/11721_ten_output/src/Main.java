import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		String input = s.next();
		
		char ch[] = input.toCharArray();
		
		for (int i = 0; i < ch.length; i++) {
			System.out.print(ch[i]);
			if((i+1)%10 == 0) {
				System.out.println();
			}
		}
	}
}
