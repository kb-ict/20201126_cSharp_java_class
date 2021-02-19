import java.util.Scanner;

public class Calculator {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num1 = 0;
		int num2 = 0;
		String a = "";
		int result = 0;

		String line = "-----------------------";
		System.out.println(line);
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println(line);
		System.out.print("1.Num1 입력 => ");
		num1 = sc.nextInt();
		System.out.print("2.Num2 입력 => ");
		num2 = sc.nextInt();
		System.out.print("3.연산자 입력 => ");
		a = sc.next();

		switch (a) {
		case "+":
			result = num1 + num2;
			System.out.printf("%d + %d = %d ", num1, num2, result);
			break;

		case "-":
			result = num1 - num2;
			System.out.printf("%d - %d = %d ", num1, num2, result);
			break;

		case "*":
			result = num1 * num2;
			System.out.printf("%d * %d = %d ", num1, num2, result);
			break;

		case "/":
			double result2 = 0;
			result2 = (double)num1 / (double)num2;
			System.out.printf("%d / %d = %s ", num1, num2, result2);
			break;

		default:
			System.out.println("계산을 할수 없습니다.");
			break;
			
		}
			

	}

}
