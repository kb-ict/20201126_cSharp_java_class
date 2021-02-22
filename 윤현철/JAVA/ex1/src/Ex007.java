import java.util.Scanner;

public class Ex007 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("-------------------");
		System.out.println(" 대소 비교 프로그램 1.0 ");
		System.out.println("-------------------");
		System.out.println("첫번째 숫자를 입력 하세요 : ");
		int num1 = sc.nextInt();
		System.out.println("두번째 숫자를 입력 하세요 : ");
		int num2 = sc.nextInt();
		if (num1 > num2) {
			System.out.println("num1이 num2보다 크다");
		}
		else if (num1 < num2) {
			System.out.println("num2가 num1보다 크다");
		}
		else {
			System.out.println("num1과 num2는 같다");
		}
		sc.close();
	}

}
