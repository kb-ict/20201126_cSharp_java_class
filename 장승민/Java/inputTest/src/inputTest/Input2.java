package inputTest;

import java.util.Scanner;

public class Input2 {

	public static void main(String[] args) {
		
		Scanner scan = new Scanner(System.in);
		System.out.print("첫번째 정수값 입력 : ");
		int num1 = scan.nextInt();
		
		System.out.print("두번째 정수값 입력 : ");
		int num2 = scan.nextInt();
		
		System.out.print("세번째 정수값 입력 : ");
		int num3 = scan.nextInt();
		
		int sum = num1 + num2 + num3;
		int avg = sum / 3;
		
		System.out.println("총 점 : " + sum);
		System.out.println("평 균 : " + avg);
		scan.close();
		
	}

}
