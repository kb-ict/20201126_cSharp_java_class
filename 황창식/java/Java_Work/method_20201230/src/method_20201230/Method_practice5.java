package method_20201230;

import java.util.Scanner;

public class Method_practice5 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("몇단이 궁금한가? : ");
		gugudan(s.nextInt());

	}
	
	public static void gugudan(int a) {
		for(int i = 1; i < 10; i++) {
			System.out.printf("%d x %d = %d\n", a, i, a*i);
		}
	}

}
