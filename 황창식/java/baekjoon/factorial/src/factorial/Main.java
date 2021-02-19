package factorial;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println(factorial(s.nextInt()));
	}
	
	public static int factorial(int num) {
		if(num == 1 || num == 0) {
			return 1;
		}
		else {
			return num * factorial(num - 1);
		}
	}

}
