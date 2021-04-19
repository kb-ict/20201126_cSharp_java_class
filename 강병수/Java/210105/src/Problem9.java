import java.util.Arrays;
import java.util.Scanner;

public class Problem9 {

	public static int[] arr(int num[]) {

		Arrays.sort(num);
		System.out.println("최소값: " + num[0]);
		System.out.println("최대값: " + num[2]);
		return num;
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int num[] = new int[3];
		for (int i = 0; i < 3; i++) {
			num[i] = sc.nextInt();
		}
		int arr[] = arr(num);
		sc.close();
	}

}
