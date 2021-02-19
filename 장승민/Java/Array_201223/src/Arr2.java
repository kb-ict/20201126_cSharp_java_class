import java.util.Scanner;

public class Arr2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] arr = new int[3];
		int sum = 0;
		for (int i = 0; i < 3; i++) {
			System.out.println((i+1) + "번째 숫자 입력 : ");
			arr[i] = sc.nextInt();
		}

		sc.close();

//		sum = arr[0]+ arr[1]+ arr[2];
//		System.out.println("배열의 합 : " + sum);
		for (int i = 0; i < 3; i++) {
			sum = sum + arr[i]; // sum += arr[i]
		}
		System.out.println("배열의 합 : " + sum);

	}

}
