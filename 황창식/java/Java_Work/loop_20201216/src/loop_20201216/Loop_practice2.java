package loop_20201216;

import java.util.Scanner;

public class Loop_practice2 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		System.out.print("두번째 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		int result = 0;
		
		System.out.println("------------------------");
		System.out.println("For 문");
		if(num1 >= num2) {
			System.out.println("Error!!");
		}
		else {
			for(int i = num1; i <= num2; i++) {
				result = result + i;
			}
			System.out.println(num1 + "부터 " + num2 + "까지의 합 : " + result);
		}
		
		
		System.out.println("------------------------");
		System.out.println("For 문");
		int i = num1;
		result = 0;
		if(num1 >= num2) {
			System.out.println("Error!!");
		}
		else {
			while(i <= num2) {
				result += i;
				i++;
			}
			System.out.println(num1 + "부터 " + num2 + "까지의 합 : " + result);
		}
		
		System.out.println("------------------------");
		System.out.println("For 문");
		i = num1;
		result = 0;
		if(num1 >= num2) {
			System.out.println("Error!!");
		}
		else {
			do {
				result += i;
				i++;
			} while(i <= num2);
			System.out.println(num1 + "부터 " + num2 + "까지의 합 : " + result);
		}
		
		
	}

}
