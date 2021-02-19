package method_201230;

import java.util.Scanner;

public class MethodPractice5 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num = sc.nextInt();
		sc.close();
		func(num);
	}

	public static void func(int a) {
		for (int i = 0; i < 9; i++) {
			System.out.printf("%d x %d = %d\n",a,(i+1),(a*(i+1)));
		}
	}
}
