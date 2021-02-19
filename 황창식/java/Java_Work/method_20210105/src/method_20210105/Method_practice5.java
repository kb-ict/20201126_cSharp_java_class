package method_20210105;

import java.util.Scanner;

public class Method_practice5 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("몇 단이 궁금? : ");
		gugudan(s.nextInt());

	}
	
	public static void gugudan(int num) {
		for (int i = 1; i < 10; i++) {
			System.out.printf("%d x %d = %d\n", num, i, num*i);
		}
	}

}
