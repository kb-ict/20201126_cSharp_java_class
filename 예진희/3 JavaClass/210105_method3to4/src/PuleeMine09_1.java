import java.util.Scanner;

public class PuleeMine09_1 {

	static int[] bigyo(int[] arr) {
		int max = arr[0];
		int min = arr[0];

		for (int i = 0; i < arr.length; i++) {
			if (arr[i] > max) {
				max = arr[i];
			}
			if (arr[i] < min) {
				min = arr[i];
			}
		}
		System.out.println("최대값: " + max);
		System.out.println("최소값: " + min);
		return arr;
	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		/*9. 3개의 숫자를 입력받아서 최대, 최소값 구하는 프로그램
		 * 조건1) 3개의 숫자는 main()에서 입력 받음.
		 * 조건2) 3개의 숫자를 메쏘드의 매개변수로 전달.
		 * 조건3) 메쏘드에서 최대, 최소값을 구한다음 배열에 저장하여 리턴하기.
		 * 조건4) 반드시 main()에서 배열을 리턴받아 최대, 최대값 출력.
		*/

		int[] arr = new int[3];
		System.out.println("3개의 숫자를 입력");
		System.out.println("----------------------");
		for (int i = 0; i < arr.length; i++) {
			System.out.print((i + 1) + ". 수 입력: ");
			arr[i] = s.nextInt();
		}
		System.out.println("----------------------");
		bigyo(arr);

		s.close();
	}
}
