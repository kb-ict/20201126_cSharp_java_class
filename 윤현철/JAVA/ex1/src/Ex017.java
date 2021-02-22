import java.util.Scanner;

public class Ex017 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("--------------------------------");
		System.out.println("입력받는 수의 합을 구하는 프로그램 v1.0");
		System.out.println("--------------------------------");
		System.out.print("1. 첫번째 숫자입력 ==> ");
		int num1 = sc.nextInt();
		System.out.print("2. 두번째 숫자입력 ==> ");
		int num2 = sc.nextInt();
		while(num1 >= num2) {
			System.out.println("잘못입력하셧습니다.");
			System.out.print("2. 두번째 숫자입력 ==> ");
			num2 = sc.nextInt();
		}
		int sum = 0;
		for(int n = num1; n <= num2; n++) {
			sum = sum + n;			
		}
		System.out.println(num1 + " ~ " + num2 + "까지의 합 : " + sum);
		sc.close();
	}
}
