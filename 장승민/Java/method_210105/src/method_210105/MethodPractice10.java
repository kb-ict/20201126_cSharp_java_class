package method_210105;

import java.util.Scanner;

public class MethodPractice10 {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		System.out.println("수를 입력하시오.");
		int num =sc.nextInt();
		sc.close();
		System.out.println(fact(num));

	}

	public static int fact(int num) {
		int i =num-1;
		while (i>0) {
			num*=i;
			i--;
		}
		return num;
	}
}
