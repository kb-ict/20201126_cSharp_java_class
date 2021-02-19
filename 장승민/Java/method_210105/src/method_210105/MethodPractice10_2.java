package method_210105;

import java.util.Scanner;

public class MethodPractice10_2 {

	public static void main(String[] args) {
		Scanner sc= new Scanner(System.in);
		System.out.print("팩토리얼 수 입력 : ");
		int num = sc.nextInt();
		sc.close();
		int result = factoraial(num);
		
		System.out.println(num + "! = "+ result);
	}

	public static int factoraial(int num) {
		if (num==0) {
			return 1;
		}
		else {
			return num*factoraial(num-1);
		}
	}
}
