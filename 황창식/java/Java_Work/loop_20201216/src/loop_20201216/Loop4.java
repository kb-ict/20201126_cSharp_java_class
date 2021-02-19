package loop_20201216;

import java.util.Scanner;

public class Loop4 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int hap = 0;
		System.out.print("숫자 입력 : ");
		int num = s.nextInt();
		
		for (int i = 0; i < num; i++) {
			hap += (i + 1);
		}
		
		System.out.println("1 ~ " + num + "까지의 합 : " + hap);
		System.out.printf("1 ~ %d까지의 합 : %d\n", num, hap);
	}

}
