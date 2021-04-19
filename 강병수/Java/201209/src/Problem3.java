import java.util.Scanner;

public class Problem3 {

	public static void main(String[] args) {
		Scanner operation = new Scanner(System.in);

		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

		System.out.print("num1 입력: ");
		int num1 = operation.nextInt();
		System.out.print("num2 입력: ");
		int num2 = operation.nextInt();
		System.out.print("연산자(+-*/) 입력: ");
		String oper = operation.next();

		if (oper.equals("+")) {
			System.out.println(num1 + "+" + num2 + "=" + (num1 + num2));
		} else if (oper.equals("-")) {
			System.out.println(num1 + "-" + num2 + "=" + (num1 - num2));
		} else if (oper.equals("*")) {
			System.out.println(num1 + "*" + num2 + "=" + (num1 * num2));
		} else if (oper.equals("/")) {
			System.out.println(num1 + "/" + num2 + "=" + (num1 / num2));
		}
		operation.close();
	}

}
