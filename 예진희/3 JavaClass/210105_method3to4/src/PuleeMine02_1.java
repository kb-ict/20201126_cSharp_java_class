import java.util.Scanner;

public class PuleeMine02_1 {

	public static void main(String[] args) {//함수 다 따로 만듦
		Scanner sc = new Scanner(System.in);
		/* 2. 숫자2개와 사칙연산자를 입력받아서 동작하는 간단한 계산기 프로그램.
		 * 조건1) 숫자2개와 사칙연산자(+,-,*,/)는 main()에서 입력받음.
		 * 조건2) 숫자2개와 사칙연산을 메쏘드에 매개변수로 전달.
		 * 조건3) 계산 결과값은 메쏘드에서 리턴값을 받아서 출력하기.
		*/

		System.out.print("숫자1 입력: ");
		int num1 = sc.nextInt();

		System.out.print("숫자2 입력: ");
		int num2 = sc.nextInt();

		while (true) {
			System.out.print("연산자 입력: ");
			String oper = sc.next();

			switch (oper) {
			case "+":
				int result = plus(num1, num2);
				System.out.println("합 : " + result);
				return;
			case "-":
				result = minus(num1, num2);
				System.out.println("차 : " + result);
				return;
			case "*":
				result = gob(num1, num2);
				System.out.println("곱 : " + result);
				return;
			case "/":
				if (num2 == 0) {
					System.out.println("0으로 나눌 수 없습니다.");
					return;
				}
				result = dev(num1, num2);
				System.out.println("나누기 : " + result);
				return;
			default:
				System.out.println("잘못된 연산자 다시입력하시오.");

			}
			sc.close();
		}
	}

	//public static int plus(int num1, int num2, String Oper) {
	public static int plus(int num1, int num2) {
		int result = num1 + num2;
		return result;
	}

	public static int minus(int num1, int num2) {
		int result = num1 - num2;
		return result;
	}

	public static int gob(int num1, int num2) {
		int result = num1 * num2;
		return result;
	}

	public static int dev(int num1, int num2) {
		int result = num1 / num2;
		return result;
	}
}
