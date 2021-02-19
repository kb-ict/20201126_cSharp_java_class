package method_20201230;

import java.util.Scanner;

public class Method_practice2 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자 입력 : ");
		int num1 = s.nextInt();
		System.out.print("두번째 숫자 입력 : ");
		int num2 = s.nextInt();
		System.out.print("연산자 입력 : ");
		String oper = s.next();
		System.out.println(calculator(num1, num2, oper));

	}

	public static int calculator(int a, int b, String c) {
		int result = 0;
		switch (c) {
		case "+":
			result = a + b;
			break;
		case "-":
			result = a + b;
			break;
		case "*":
			result = a + b;
			break;
		case "/":
			result = a + b;
			break;
		}
		return result;
	}

}
