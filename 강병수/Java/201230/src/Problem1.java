import java.util.Arrays;
import java.util.Scanner;

public class Problem1 {

	public static void func(int num[]) { //배열 정렬 메소드
		Arrays.sort(num);

	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int num[] = new int[3];
		for (int i = 0; i < 3; i++) {
			num[i] = sc.nextInt();
		}
		func(num);
		for (int i = 2; i > 0; i--) {
			System.out.print(num[i] + "-");
		}
		System.out.println(num[0]);
		sc.close();
	}

}
