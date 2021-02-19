package method_210105;

import java.util.Scanner;

public class MethodPractice2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);


		System.out.println("숫자 2개를 입력하시오.");
		int num1 = sc.nextInt();
		int num2 = sc.nextInt();
		System.out.println("사칙연산자를 입력하시오.(+,-,*,/)");
		String str = sc.next();
		sc.close();
		
		
		if (str.equals("/")) {
			double result = cals2(num1, num2, str);
			System.out.println(num1 +" "+str+ " "+num2 );
			System.out.println(result);					
		}
		else {
			int result = cals(num1, num2, str);
			System.out.println(num1 +" "+str+ " "+num2 );
			System.out.println(result);
		}
		}

	public static int cals(int num1, int num2, String str) {
		int result =0;
		switch (str) {
		case "+":
			result = num1 + num2;
			break;
		case "-":
			result = num1 - num2;
			break;

		case "*":
			result = num1 * num2;
			break;
		}
		return result;
	}
	
	
	public static double cals2(int num1, int num2, String str) {
		double result =0;
		result = (double)num1 / (double)num2;
		return result;
	}
}
