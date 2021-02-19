import java.util.Scanner;

public class Arr1 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] arr = new int[4];
		int sum = 0;

		System.out.println("1번째 숫자 입력 : ");
		arr[0] = sc.nextInt();
		System.out.println("2번째 숫자 입력 : ");
		arr[1] = sc.nextInt();
		System.out.println("3번째 숫자 입력 : ");
		arr[2] = sc.nextInt();
	
		sc.close();
		
//		sum = arr[0]+ arr[1]+ arr[2];
//		System.out.println("배열의 합 : " + sum);
		for (int i = 0; i < 3; i++) {
			sum = sum + arr[i];   		//		sum += arr[i]
		}
		System.out.println("배열의 합 : " + sum);

	
	}

}
