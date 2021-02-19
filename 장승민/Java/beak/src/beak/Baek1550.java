package beak;

import java.util.Scanner;

public class Baek1550 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String str = sc.nextLine();
		sc.close();
		int sum = 0;
		char[] ch = str.toCharArray();
		if (ch.length < 7) {
			for (int i = 0; i < ch.length; i++) {
				if ((int) ch[i] > 57) {
					sum += ((ch[i] - 55) * Math.pow(16, ch.length - 1 - i));

				} else if ((int) ch[i] >= 48 && (int) ch[i] <= 57) {
					sum += ((ch[i] - 48) * Math.pow(16, ch.length - 1 - i));
				
				} else {
					System.out.println("잘못된 수를 입력하셨습니다.");
				}
			}
			System.out.println(sum);
		
		}
	}
}
