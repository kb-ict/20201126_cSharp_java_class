import java.util.Scanner;

public class Ex012 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("첫번째 숫자를 입력 하세요 : ");
		int num1 = sc.nextInt();
		System.out.print("두번째 숫자를 입력 하세요 : ");
		int num2 = sc.nextInt();
		System.out.print("연산자를 입력 하세요 : ");
		String a =sc.next();
		switch (a) {
		case "+" :
			System.out.println(num1 + " + " + num2 + " = " + (num1 + num2));
			break;
		case "-" :
			System.out.println(num1 + " - " + num2 + " = " + (num1 - num2));
			break;
		case "*" :
			System.out.println(num1 + " * " + num2 + " = " + (num1 * num2));
			break;
		default :
			System.out.println(num1 + " / " + num2 + " = " + (num1 / num2));
		}
		sc.close();
	}

}
