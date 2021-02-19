package method_20201230;

import java.util.Scanner;

public class Method_practice10 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("팩토리얼 수 입력 : ");
		int n = s.nextInt();
		int result = factorial(n);
		
		System.out.println(n + " != " + result);
	}
	
	public static int factorial(int n) {
		if (n == 0) {
			return 1;
		}
		else {
			return n * factorial(n - 1);
		}
		
	}
}
