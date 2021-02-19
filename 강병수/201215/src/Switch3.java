import java.util.Scanner;

public class Switch3 {

	public static void main(String[] args) {
		Scanner aa = new Scanner(System.in);
		System.out.print("첫번째 숫자 입력: ");
		double num1 = aa.nextDouble();
		System.out.print("연산식 입력: ");
		String oper = aa.next();
		System.out.print("두번째 숫자 입력: ");
		double num2 = aa.nextDouble();
		double result = 0;
		switch (oper) {
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
			if (num2 == 0) {
				System.out.println("분모는 0이 될 수 없습니다.");
				// 실행 프로그램 강제종료 명령어
				System.exit(0);
			}
			result = num1 / num2;
			break;
		default:
			System.out.println("잘못된 연산자 입력");
			aa.close();
			System.exit(0);
		}
		System.out.println("결과값: " + result);
		aa.close();


	}

}
