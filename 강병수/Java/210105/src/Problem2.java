import java.util.Scanner;

public class Problem2 {

	public static int sum(int num1, int num2, String oper) {
		int sum = 0;
		switch (oper) {
		case "+":
			sum = num1 + num2;
			break;
		case "-":
			sum = num1 - num2;
			break;
		case "*":
			sum = num1 * num2;
			break;
		case "/":
			sum = num1 / num2;
			break;
		default:
			System.out.println("잘못된 사칙연산 입력");
			System.exit(0);
		}
		return sum;
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num1 = sc.nextInt();
		int num2 = sc.nextInt();
		String oper = sc.next();
		System.out.println(sum(num1, num2, oper));
		sc.close();
	}

}
