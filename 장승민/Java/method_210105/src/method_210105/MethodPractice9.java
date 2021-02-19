package method_210105;

import java.util.Arrays;
import java.util.Scanner;


public class MethodPractice9 {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		
		int num1=sc.nextInt();
		int num2=sc.nextInt();
		int num3=sc.nextInt();
		sc.close();
		
		int[] num = num(num1, num2, num3);
		
		System.out.println("최소값 : " + num[0]);

		System.out.println("최대값 : " + num[2]);

	}

	public static int[] num(int a, int b, int c) {
		int[] num ={a,b,c};
		Arrays.sort(num);
		return num;
	}
}
