import java.util.Scanner;

public class Problem1 {

	public static void main(String[] args) {
		Scanner fal = new Scanner(System.in);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ ");
		System.out.println("   짝수 홀수 구분 프로그램 v 1.0    ");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ ");
		for (int i = 1; i <= 5; i++) {
			System.out.print("숫자 입력: ");
			int k = fal.nextInt();
			System.out.printf("%d. Num%d => %d\n", i, i, k);
			if (k % 2 == 0) {
				System.out.println("짝수입니다.");
			} else {
				System.out.println("홀수입니다.");
			}
		}
		fal.close();
	}

}
