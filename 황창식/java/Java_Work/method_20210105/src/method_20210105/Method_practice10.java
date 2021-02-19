package method_20210105;

import java.util.Scanner;

public class Method_practice10 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("factorial ? : ");
		System.out.println(factorial(s.nextInt()));
		

	}
	
	public static int factorial(int num) {
		if(num == 1) {
			return 1;
		}
		else {
			return num * factorial(num-1);
		}
	}

}
