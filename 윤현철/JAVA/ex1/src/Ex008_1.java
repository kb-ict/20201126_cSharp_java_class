import java.util.Scanner;

public class Ex008_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("-----------------------");
		System.out.println(" 간단한 계산기 프로그램 1.0 ");
		System.out.println("-----------------------");
		System.out.print(" 첫번째 숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		System.out.print(" 두번째 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		System.out.println(num1 + " + " + num2 + " = " + (num1 + num2));
		System.out.println(num1 + " - " + num2 + " = " + (num1 - num2));
		System.out.println(num1 + " * " + num2 + " = " + (num1 * num2));
		System.out.println(num1 + " / " + num2 + " = " + (num1 / num2));
		s.close();
	}
}
