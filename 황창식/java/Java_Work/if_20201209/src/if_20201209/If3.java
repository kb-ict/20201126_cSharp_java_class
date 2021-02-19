package if_20201209;

import java.util.Scanner;

public class If3 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("숫자를 입력하세요 : ");
		int num = s.nextInt();

		if (num % 2 == 1) {
			System.out.println(num + "은 홀수입니다");
		} else if (num % 2 == 0) {
			System.out.println(num + "은 짝수입니다");
		} else {
			System.out.println("잘못 입력하였습니다");
		}
		s.close();

	}

}
