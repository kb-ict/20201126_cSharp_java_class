import java.util.Scanner;

public class Ex018 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("----------------------");
		System.out.println(" 간단 구구단 프로그램 v1.0");
		System.out.println("----------------------");
		System.out.print("1. 구구단 입력 ==> ");
		int num1 = sc.nextInt();
		for (int n = 1; n < 10; n++) {
			System.out.println(num1 + " * " + n + " = " + (num1 * n) + "	");
		}
		sc.close();
	}

}
