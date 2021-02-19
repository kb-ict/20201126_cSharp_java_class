package condition;

import java.util.Scanner;

public class DeaSo {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("-------------------");
		System.out.println("대소 비교 프로그램 v.1.0");
		System.out.println("-------------------");
		System.out.print("num1 입력 => ");
		int num1 =sc.nextInt();
		
		System.out.print("num2 입력 => ");
		int num2 =sc.nextInt();
		
		System.out.println("-------------------");
		if (num1>num2)
		{
			System.out.println("num1이 num2보다 크다.");
		}
		else if (num1<num2)
		{
			System.out.println("num2가 num1보다 크다.");
		}
		else
		{
			System.out.println("num1과 num2는 같다.");
		}
		
	}

}
