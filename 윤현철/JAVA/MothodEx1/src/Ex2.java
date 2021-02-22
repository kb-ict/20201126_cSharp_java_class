import java.util.Scanner;

public class Ex2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		System.out.print("두번째 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		System.out.print("사칙 연산자를 입력하세요 : ");
		String a = s.next();
		func(num1,num2,a);
		s.close();
	}
	public static int func(int num1,int num2, String a) {
		int result =0;
		if (a.equals("+")) {
			result = num1 + num2;
			System.out.printf("%d + %d = %d",num1,num2,result);
		}
		else if (a.equals("-")) {
			result = num1 - num2;
			System.out.printf("%d - %d = %d",num1,num2,result);
		}
		else if (a.equals("*")) {
			result = num1 * num2;
			System.out.printf("%d x %d = %d",num1,num2,result);
		}
		else if (a.equals("/")) {
			result = num1 / num2;
			System.out.printf("%d / %d = %d",num1,num2,result);
		}
		else {
			System.out.println("잘못 입력하셧습니다.");
		}
		return result;
	}
}
