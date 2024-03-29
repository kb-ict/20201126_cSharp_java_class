import java.util.Scanner;

public class Arr1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] arr = new int[4]; // int형 빈공간을 가지는 4개의 배열
		int hap = 0;

		System.out.print("1번째 숫자 입력: ");
		arr[0] = s.nextInt();
		System.out.print("2번째 숫자 입력: ");
		arr[1] = s.nextInt();
		System.out.print("3번째 숫자 입력: ");
		arr[2] = s.nextInt();

		hap = arr[0] + arr[1] + arr[2];
		System.out.println("배열의 합: " + hap); // 반복문 미사용

		// ------------- 반복문 사용 -------------//
		hap = 0;

		for (int i = 0; i < 3; i++) {
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("배열의 합: " + hap);

		s.close();
	}
}
