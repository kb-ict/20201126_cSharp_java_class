import java.util.Scanner;

public class Yeje2 {

	public static void main(String[] args) {
		// ( 예제 2 ) 숫자 2개, 사칙연산자 이용한 계산기 프로그램
		String line = "-----------------------------";
		Scanner sc = new Scanner(System.in);
		
		System.out.println(line);
		System.out.println("    간단한 계산기 프로그램 v1.0");
		System.out.println(line);
		System.out.print("1. Num1 입력 => ");
		int num1 = sc.nextInt();
		System.out.print("2. Num2 입력 => ");
		int num2 = sc.nextInt();
		System.out.print("3. 연산자 입력 => ");
		String oper = sc.next();
		int gye = 0;
		
		switch (oper) {
		case "+":
			gye = num1 + num2;
			break;
			
		case "-":
			gye = num1 - num2;
			break;
			
		case "X":
			gye = num1 * num2;
			break;
			
		case "/":
			if (num2==0) {
				System.out.println(line);
				System.out.println("0으로 나눌 수 없습니다.");
			}
			sc.close();
			System.exit(0);
			gye = num1 / num2;
			break;
			
		default : {
				System.out.println(line);
				System.out.println("+, -, X, /중에서 입력하세요.");
				sc.close();
				System.exit(0);
			}
			
		}
		
		System.out.println(line);
		System.out.printf("%d %s %d = %d",num1, oper, num2, gye);
		sc.close();

	}

}
