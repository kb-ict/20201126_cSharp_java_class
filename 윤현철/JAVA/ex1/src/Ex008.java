import java.util.Scanner;

public class Ex008 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("-----------------------");
		System.out.println(" 간단한 계산기 프로그램 1.0 ");
		System.out.println("-----------------------");
		System.out.print("첫번째 숫자를 입력 하세요 : ");
		int num1 = sc.nextInt();
		System.out.print("두번째 숫자를 입력 하세요 : ");
		int num2 = sc.nextInt();
		System.out.print("연산자를 입력 하세요(+ , - , * , /) : ");
		String a =sc.next();
		if (a.equals("+")) {
			System.out.println(num1 + a + num2 + " = " + (num1 + num2));
		}
		else if (a.equals("-")) {
			System.out.println(num1 + a + num2 + " = " + (num1 - num2));
		}
		else if (a.equals("*")) {
			System.out.println(num1 + a + num2 + " = " + (num1 * num2));
		}
		else {System.out.println(num1 + a + num2 + " = " + (num1 / num2));
		}
		sc.close();
	}	
}
