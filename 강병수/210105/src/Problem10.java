import java.util.Scanner;

public class Problem10 {

	public static void main(String[] args) {
		Scanner sc=new Scanner(System.in);
		System.out.print("숫자 입력: ");
		int num = sc.nextInt();
		System.out.println(factorial(num));
		sc.close();

	}
	public static int factorial(int n) {
		if (n == 0) {
			return 1;
		}
		
		if (n == 1)
		{
			return 1;
		}
		else
		{
			return n* factorial(n-1);
		}
	}
}
