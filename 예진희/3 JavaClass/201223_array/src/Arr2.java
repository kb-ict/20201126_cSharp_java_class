import java.util.Scanner;

public class Arr2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] arr = new int[4]; // int형 빈공간을 가지는 4개의 배열
		int hap = 0;

		for (int i = 0; i < 3; i++) {
			System.out.print((i + 1) + "번째 숫자 입력: ");
			arr[i] = s.nextInt();

		}

		for (int i = 0; i < 3; i++) {
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("배열의 합: " + hap);

		s.close();
	}
}
