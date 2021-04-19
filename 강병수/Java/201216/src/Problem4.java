import java.util.Scanner;

public class Problem4 {

	public static void main(String[] args) {
		Scanner ts = new Scanner(System.in);
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.println("입력받는수의 합을 구하는 프로그램 v1.0");
		System.out.println("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
		System.out.print("첫번째 수 입력: ");
		int i = ts.nextInt();
		int h = i;
		System.out.print("두번째 수 입력: ");
		int j = ts.nextInt();
		while (j < i) {
			System.out.println("오류: 첫번째 수보다 두번째 수가 커야합니다.");
			System.out.print("두번째 수 입력: ");
			j = ts.nextInt();
		}
		int k = 0;
		do {
			k = k + i;
			i++;

		} while (i <= j);
		System.out.printf("%d부터 %d까지의 합: %d", h, j, k);
		ts.close();
	}
}
