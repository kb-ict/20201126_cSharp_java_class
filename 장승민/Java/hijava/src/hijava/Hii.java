package hijava;

import java.util.Scanner;

public class Hii {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.println("1. 곱할 수를 입력하시오.");
		int num1 = sc.nextInt();
		
		System.out.println("2. 곱할 수를 입력하시오.");
		int num2 = sc.nextInt();
		
		
		
		System.out.println(num1*(num2%10));
		System.out.println((num1*((num2%100)/10)));
		System.out.println(num1*(num2/100));
		
		System.out.println(num1*num2);
		
		
		System.out.println();
		System.out.println();
		System.out.println(num1);
		System.out.println("*");
		System.out.println(num2);
		System.out.println("-------");
		System.out.println(num1*(num2%10));
		System.out.println((num1*((num2%100)/10)));
		System.out.println(num1*(num2/100));
		System.out.println("-------");
		System.out.println(num1*num2);
	}

}
