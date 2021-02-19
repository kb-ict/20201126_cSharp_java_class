import java.util.Scanner;

public class Switch3 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("첫번째 숫자 입력: ");
		double op1 = sc.nextDouble(); //소수점 존재 숫자
		System.out.print("연산식 입력: ");
		String oper = sc.next();
		System.out.print("두번째 숫자 입력: ");
		double op2 = sc.nextDouble(); //소수점 존재 숫자
		double result = 0;
		
		switch (oper) {
		case "+":
			result = op1 + op2;
			break;
			
		case "-":
			result = op1 - op2;
			break;
			
		case "*":
			result = op1 * op2;
			break;
			
		case "/":
			if (op2 == 0) {
				System.out.println("분모 0 에러!");
				// 실행 프로그램 강제 종료
				sc.close();
				System.exit(0);
			}
			result = op1 / op2;
			break;
			
		default:
			System.out.println("잘못된 연산자 입력");
			sc.close();
			System.exit(0); // 결과값 보여주지 않고 프로그램 종료
		}
		System.out.println("------------------");
		System.out.println("결과값: "+(int)result);
		// sc.close(); exit되기 전에 넣는다.

	}

}
