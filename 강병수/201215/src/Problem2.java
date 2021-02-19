import java.util.Scanner;

public class Problem2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		
		System.out.print("Num1 입력 => ");
		int Num1 = sc.nextInt();
		System.out.print("Num2 입력 => ");
		int Num2 = sc.nextInt();
		System.out.print("연산자 입력(+-*/) => ");
		String oper = sc.next();
		
		switch (oper) {
		case "+":
			int result = Num1 + Num2;
			System.out.println(Num1 + "+" +  Num2 + "=" + result);
			break;
		case "-":
			int result1 = Num1 - Num2;
			System.out.println(Num1 + "-" +  Num2 + "=" + result1);
			break;
		case "*":
			int result2 = Num1 * Num2;
			System.out.println(Num1 + "*" +  Num2 + "=" + result2);
			break;
		case "/":
			int result3 = Num1 / Num2;
			System.out.println(Num1 + "/" +  Num2 + "=" + result3);
			break;
		}
		sc.close();
	}
	

}
