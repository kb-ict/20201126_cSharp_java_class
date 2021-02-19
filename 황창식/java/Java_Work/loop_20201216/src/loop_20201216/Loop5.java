package loop_20201216;

import java.util.Scanner;

public class Loop5 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("구구단 입력 : ");
		int gugu = s.nextInt();
		int result = 0;
		for (int i = 0; i < 9; i++) {
			result = gugu * (i + 1);
			System.out.printf("%d x %d = %d\n", gugu, i + 1, result);
			//System.out.println(gugu + " x " + (i + 1) + " = " + result);
		}

	}

}
