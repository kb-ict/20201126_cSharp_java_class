package method_20210105;

import java.util.Scanner;

public class Method_practice2 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		System.out.print("연산자를 입력하세요 : ");
		String oper = s.next();
		System.out.print("두번째 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		System.out.println(calc(num1, oper, num2));

	}
	
	public static int calc(int num1, String oper, int num2) {
		int result = 0;
		switch(oper) {
		case "+":
			result = num1 + num2;
			break;
		case "-":
			result = num1 - num2;
			break;
		case "*":
			result = num1 * num2;
			break;
		case "/":
			result = num1 / num2;
			break;
		default : 
			System.out.println("잘못 입력하였습니다.");
		}
		return result;
	}

}
